using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace etec.bg.abax.maitre.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public sealed class Session
        {

            private static volatile Session instance;
            private static object sync = new Object();

            private Session() { }

            public static Session Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (sync)
                        {
                            if (instance == null)
                            {
                                instance = new Session();
                            }
                        }
                    }
                    return instance;
                }

            }
            public int UserID { get; set; }
            public string Funcao { get; set; }
            public string Nome { get; set; }

        }
    }
}
