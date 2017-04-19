using System.Collections.Generic;

namespace OneNoteApiSample
{
	public static class Config
	{
		// TODO: Replace all of these with your own
		public static string MsaRedirectUri => "http://localhost:5001/msaoauthcallback";
		public static string MsaAppId => "8414ccf0-5668-40c2-8fb4-2d70c3b3b0d6";
		public static string MsaAppSecret => "orD4m05tYxooWHt5BZ460za";

		// TODO: Your app might require a different list of scopes.
		// See https://msdn.microsoft.com/en-us/Library/Azure/Ad/Graph/howto/azure-ad-graph-api-permission-scopes and https://developer.microsoft.com/en-us/graph/docs/authorization/permission_scopes
		public static List<string> MsaRequiredScopes => new List<string>()
		{
			"https://graph.microsoft.com/Notes.ReadWrite.All",
			"https://graph.microsoft.com/User.Read",
			"openid",
			"offline_access"
		};
	}
}
