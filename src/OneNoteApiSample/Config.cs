using System.Collections.Generic;

namespace OneNoteApiSample
{
	public static class Config
	{
		// TODO: Replace all of these with your own
		// Note: Redirect URIs should be HTTPS, but it is easier to deploy/play with HTTP
		public static string MsaRedirectUri => "https://OneNoteApiSampleGraph.azurewebsites.net/msaoauthcallback";
		public static string MsaAppId => "d35bde26-f003-4c4c-8bd0-2827a885ae02";
		public static string MsaAppSecret => "eRdutf8thhPLZEs1h4QjTHq";

		// TODO: Your app might require a different list of scopes.
		// See https://msdn.microsoft.com/en-us/library/office/dn807159.aspx and https://msdn.microsoft.com/en-us/library/hh243646.aspx#wlbasic
		public static List<string> MsaRequiredScopes => new List<string>()
		{
			"https://graph.microsoft.com/Notes.ReadWrite.All",
			"openid",
			"offline_access",
			"profile"
		};

		// TODO: This sample does not support O365 authentication
	}
}
