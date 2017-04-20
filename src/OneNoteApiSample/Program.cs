using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Hosting;

namespace OneNoteApiSample
{
	public class Program
	{
		public static void Main(string[] args)
		{

			// NOTE: This is only for development/testing purposes
#if DEBUG
			var redirectUri = new Uri(Config.MsaRedirectUri);
#endif

			var host = new WebHostBuilder()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseKestrel()
#if DEBUG
				// NOTE: This is only for development/testing purposes
				.UseUrls("http://localhost:5001")
#endif
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}
