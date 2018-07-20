using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace alba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static int Port { get; set; }
        public static IWebHost BuildWebHost(string[] args)
        {
            var wh = WebHost.CreateDefaultBuilder(args)
                            .UseStartup<Startup>();

            if (Port != 0) {
                wh.UseUrls("http://0.0.0.0:" + Port.ToString());
            }
            return wh.Build();
        }
    }
}
