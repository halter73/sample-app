using System;
using Microsoft.AspNetCore.Hosting;

namespace ServiceB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var port = 80;
            new WebHostBuilder()
                .UseKestrel(options =>
                {
                    options.ShutdownTimeout = TimeSpan.FromSeconds(20);
                })
                .UseStartup<Startup>()
                .UseUrls("http://*:" + port)
                .Build()
                .Run();
        }
    }
}
