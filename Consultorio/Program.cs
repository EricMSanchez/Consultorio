using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using Serilog.Events;

namespace Consultorio
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(
                path: "c:\\projects\\consultorio\\logs\\log-.txt",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                rollingInterval:RollingInterval.Day,
                restrictedToMinimumLevel:LogEventLevel.Information
                ).CreateLogger();

            try
            {
                Log.Information("Application Starting...");
                CreateHostBuilder(args).Build().Run();
            }catch(Exception e)
            {
                Log.Error(e.ToString());
                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
                
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).
            UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
