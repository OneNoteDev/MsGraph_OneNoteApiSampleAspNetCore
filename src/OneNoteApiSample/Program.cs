﻿using System;
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
			var pfxFile = Path.Combine(Directory.GetCurrentDirectory(), "server.pfx");

			var host = new WebHostBuilder()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseKestrel(options =>
				{
					options.UseHttps(new X509Certificate2(pfxFile, "password"));
				})
#if DEBUG
				// NOTE: This is only for development/testing purposes
				.UseUrls("https://localhost:5001")
#endif
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}
