using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using NLog.Web;

namespace Item.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)    //产生一个IHostBuilder实例hostBuilder ,创建通用主机
                .Build()               //Build() 运行给定操作以初始化主机  这个只能调用一次
                .Run();                //运行应用程序并阻止调用线程，直至主机关闭
            //IHostBuilder hostBuilder = CreateHostBuilder(args);
            //IHost host = hostBuilder.Build();
            //host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //配置 
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
                //配置使用Nlog
                //.UseNLog();


        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    var builder = Host.CreateDefaultBuilder(args)
        //        .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //配置 
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });

        //    // 使用NLog作为日志记录
        //    builder.ConfigureLogging(logging =>
        //    {
        //        // 清除原有的日志器
        //        logging.ClearProviders();
        //    }).UseNLog();

        //    return builder;
        //}
    }
}
