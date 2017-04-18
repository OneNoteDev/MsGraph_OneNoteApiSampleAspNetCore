using System;
using System.IO;

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
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
#if DEBUG
				// NOTE: This is only for development/testing purposes
				// .UseUrls("http://testuri:80")
				.UseKestrel(cfg => cfg.UseHttps(cert))
				.UseUrls("https://localhost:5001")

#endif
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}
