using System.Collections.Generic;

namespace OneNoteApiSample
{
	public static class Config
	{
		// TODO: Replace all of these with your own
		public static string MsaRedirectUri => "https://localhost/msaoauthcallback";
		public static string MsaAppId => "0000000";
		public static string MsaAppSecret => "000000";

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
