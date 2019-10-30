using DinamikCRM.WebApi;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DinamikCRM
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
    }
}
