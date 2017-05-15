using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace OneNoteApiSample.Auth
{
	public class MsGraphAuthUtils
	{
		public static readonly MsGraphAuthUtils Instance = new MsGraphAuthUtils(Config.MsGraphAppId, Config.MsGraphAppSecret,
			Config.MsGraphRequiredScopes, Config.MsGraphRedirectUri);

		// Collateral used to refresh access token (only applicable when the app uses the wl.offline_access wl.signin scopes) 
		private const string MsGraphTokenRefreshUrl = "https://login.microsoftonline.com/common/oauth2/v2.0/token";
		private const string TokenRefreshContentType = "application/x-www-form-urlencoded";

		private string _appId;
		private string _appSecret;
		private string _redirectUrl;
		private IEnumerable<string> _scopes;

		public MsGraphAuthUtils(string appId, string appSecret, IEnumerable<string> scopes, string redirectUrl)
		{
			_appId = appId;
			_appSecret = appSecret;
			_scopes = scopes;
			_redirectUrl = redirectUrl;
		}

		private async Task<MsGraphGetTokenResponse> ExchangeCodeForAccessTokenPrivate(string code)
		{
			try
			{
				using (HttpClient client = new HttpClient())
				{
					var postFormParameters = new List<KeyValuePair<string, string>>()
					{
						new KeyValuePair<string, string>("client_id", _appId),
						new KeyValuePair<string, string>("redirect_uri", _redirectUrl),
						new KeyValuePair<string, string>("code", code),
						new KeyValuePair<string, string>("grant_type", "authorization_code"),
						new KeyValuePair<string, string>("scope", string.Join(" ", _scopes))
	
					};

					if (_appSecret != null)
					{
						// Secret isn't needed for client apps
						postFormParameters.Add(new KeyValuePair<string, string>("client_secret", _appSecret));
					}

					var formContent = new FormUrlEncodedContent(postFormParameters);
					client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", TokenRefreshContentType);

					HttpResponseMessage response = await client.PostAsync(MsGraphTokenRefreshUrl, formContent);
					string responseString = await response.Content.ReadAsStringAsync();
					MsGraphGetTokenResponse tokenResponse = JsonConvert.DeserializeObject<MsGraphGetTokenResponse>(responseString);
					return tokenResponse;
				}
			}
			catch (Exception ex)
			{
				// Log this??
				throw;
			}
		}

		public string BuildUrl()
		{
			string completeRedirectUrl =
				WebUtility.UrlEncode(_redirectUrl);

			string authUrl = "https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=" + _appId + "&scope=" +
				string.Join(" ", _scopes) + "&response_type=code&redirect_uri=" + completeRedirectUrl + "&response_mode=query";

			return authUrl;
		}

		public async Task<AuthTokenProperties> ExchangeCodeForAccessToken(string code)
		{
			MsGraphGetTokenResponse msGraphData = await ExchangeCodeForAccessTokenPrivate(code);
			return TransformMSGraphTokenResponseIntoAuthProperties(msGraphData);
		}

		private AuthTokenProperties TransformMSGraphTokenResponseIntoAuthProperties(MsGraphGetTokenResponse MSGraphData)
		{
			int expiresIn = -1;
			int.TryParse(MSGraphData.expires_in, out expiresIn);
			return new AuthTokenProperties(MSGraphData.access_token, expiresIn, MSGraphData.refresh_token, MSGraphData.id_token);
		}

		public async Task<AuthTokenProperties> ExchangeRefreshTokenForAuthInfo(string refreshToken)
		{
			try
			{
				using (HttpClient client = new HttpClient())
				{
					var postFormParameters = new List<KeyValuePair<string, string>>()
					{
						new KeyValuePair<string, string>("client_id", _appId),
						new KeyValuePair<string, string>("redirect_uri", _redirectUrl),
						new KeyValuePair<string, string>("refresh_token", refreshToken),
						new KeyValuePair<string, string>("grant_type", "refresh_token"),
					};
					if (_appSecret != null)
					{
						postFormParameters.Add(new KeyValuePair<string, string>("client_secret", _appSecret));
					}

					var formContent = new FormUrlEncodedContent(postFormParameters);

					client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", TokenRefreshContentType);

					var response = await client.PostAsync(MsGraphTokenRefreshUrl, formContent);
					string responseString = await response.Content.ReadAsStringAsync();
					MsGraphGetTokenResponse tokenResponse = JsonConvert.DeserializeObject<MsGraphGetTokenResponse>(responseString);
					return TransformMSGraphTokenResponseIntoAuthProperties(tokenResponse);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Failed to refresh token! " + ex);
				throw;
			}
		}
	}
}
