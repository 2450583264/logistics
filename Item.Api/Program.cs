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
            CreateHostBuilder(args)    //����һ��IHostBuilderʵ��hostBuilder ,����ͨ������
                .Build()               //Build() ���и��������Գ�ʼ������  ���ֻ�ܵ���һ��
                .Run();                //����Ӧ�ó�����ֹ�����̣߳�ֱ�������ر�
            //IHostBuilder hostBuilder = CreateHostBuilder(args);
            //IHost host = hostBuilder.Build();
            //host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //���� 
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
                //����ʹ��Nlog
                //.UseNLog();


        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    var builder = Host.CreateDefaultBuilder(args)
        //        .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //���� 
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });

        //    // ʹ��NLog��Ϊ��־��¼
        //    builder.ConfigureLogging(logging =>
        //    {
        //        // ���ԭ�е���־��
        //        logging.ClearProviders();
        //    }).UseNLog();

        //    return builder;
        //}
    }
}
