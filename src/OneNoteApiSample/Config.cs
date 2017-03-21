using System.Collections.Generic;

namespace OneNoteApiSample
{
	public static class Config
	{
		// TODO: Replace all of these with your own
		// Note: Redirect URIs should be HTTPS, but it is easier to deploy/play with HTTP
		// TODO: revert back to original URIs.
		public static string MsaRedirectUri => "http://localhost/msaoauthcallback";
		public static string MsaAppId => "12fb1c8f-df99-4d53-973c-0730812abd93";
		public static string MsaAppSecret => "m7rETtQVh2uFsUG91yjTwHD";

		// TODO: Your app might require a different list of scopes.
		// See https://msdn.microsoft.com/en-us/library/office/dn807159.aspx and https://msdn.microsoft.com/en-us/library/hh243646.aspx#wlbasic
		public static List<string> MsaRequiredScopes => new List<string>()
		{
			"https://graph.microsoft.com/Notes.ReadWrite.All",
			"openid",
			"offline_access"
		};

		// TODO: This sample does not support O365 authentication
	}
}
