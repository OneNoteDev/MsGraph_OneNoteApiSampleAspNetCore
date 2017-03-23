using System.Collections.Generic;

namespace OneNoteApiSample
{
	public static class Config
	{
		// TODO: Replace all of these with your own
		public static string MsaRedirectUri => "https://OneNoteApiSampleGraph.azurewebsites.net/msaoauthcallback";
		public static string MsaAppId => "d35bde26-f003-4c4c-8bd0-2827a885ae02";
		public static string MsaAppSecret => "eRdutf8thhPLZEs1h4QjTHq";

		// TODO: Your app might require a different list of scopes.
		// See https://msdn.microsoft.com/en-us/Library/Azure/Ad/Graph/howto/azure-ad-graph-api-permission-scopes and https://developer.microsoft.com/en-us/graph/docs/authorization/permission_scopes
		public static List<string> MsaRequiredScopes => new List<string>()
		{
			"https://graph.microsoft.com/Notes.ReadWrite.All",
			"openid",
			"offline_access"
		};

		// TODO: This sample does not support O365 authentication
	}
}
