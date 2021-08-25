using Autofac;
using Item.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Service;
using Item.Repository;
using Service.BasicService;
using Swashbuckle.AspNetCore.Filters;
using Item.Common.Token;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Item.Api.Filter;
using Item.Common.Token;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Filters;
using Item.Api.Filter;

namespace Item.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region ȫ���쳣������
            services.AddControllers(options =>
            {
                options.Filters.Add<CustomerExceptionFilter>();
            });
            //services.AddControllers(options =>
            //{
            //    options.Filters.Add(new CustomerExceptionFilter());
            //});
            //������
            //services.AddMvc(
            // options =>
            // {
            //     options.Filters.Add<HttpGlobalExceptionFilter>();//ȫ��ע��
            // });
            #endregion


            var jwtConfig = Configuration.GetSection("Jwt");
            //������Կ
            var symmetricKeyAsBase64 = jwtConfig.GetValue<string>("Secret");
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);
            //��֤����
            services.AddAuthentication("Bearer")
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = false,//�Ƿ���֤ǩ��,����֤�Ļ����Դ۸����ݣ�����ȫ��Configure���������֤����
                    //4������Jwt��Token����
                    IssuerSigningKey = signingKey,//���ܵ���Կ
                    ValidateIssuer = true,//�Ƿ���֤�����ˣ�������֤�غ��е�Iss�Ƿ��ӦValidIssuer����
                    ValidIssuer = jwtConfig.GetValue<string>("Iss"),//������
                    ValidateAudience = true,//�Ƿ���֤�����ˣ�������֤�غ��е�Aud�Ƿ��ӦValidAudience����
                    ValidAudience = jwtConfig.GetValue<string>("Aud"),//������
                    ValidateLifetime = true,//�Ƿ���֤����ʱ�䣬�����˾;ܾ�����
                    ClockSkew = TimeSpan.Zero,//����ǻ������ʱ�䣬Ҳ����˵����ʹ���������˹���ʱ�䣬����ҲҪ���ǽ�ȥ������ʱ�� + ���壬Ĭ�Ϻ�����7���ӣ������ֱ������Ϊ0
                    RequireExpirationTime = true,
                };
            });

            services.AddTransient<Token>();




            //����  ���ݿ�  �ַ���
            ConfigHelper.ConnString = Configuration.GetConnectionString("Default");
            //����ע��
            services.AddTransient<UsersService>();
            services.AddTransient<RoleusersService>();
            services.AddTransient<MenuroleService>();
            services.AddTransient<MenuService>();
            services.AddTransient<FuelService>();
            services.AddTransient<OutsourceService>();
            services.AddTransient<PathService>();
            services.AddTransient<ShipperService>();
            services.AddTransient<VehicleService>();
            services.AddTransient<Token>();


            #region JWT������
            var jwtConfig = Configuration.GetSection("Jwt");
            //������Կ
            var symmetricKeyAsBase64 = jwtConfig.GetValue<string>("Secret");
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);
            //��֤����
            services.AddAuthentication("Bearer")
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = false,//�Ƿ���֤ǩ��,����֤�Ļ����Դ۸����ݣ�����ȫ��Configure���������֤����
                    //4������Jwt��Token����
                    IssuerSigningKey = signingKey,//���ܵ���Կ
                    ValidateIssuer = true,//�Ƿ���֤�����ˣ�������֤�غ��е�Iss�Ƿ��ӦValidIssuer����
                    ValidIssuer = jwtConfig.GetValue<string>("Iss"),//������
                    ValidateAudience = true,//�Ƿ���֤�����ˣ�������֤�غ��е�Aud�Ƿ��ӦValidAudience����
                    ValidAudience = jwtConfig.GetValue<string>("Aud"),//������
                    ValidateLifetime = true,//�Ƿ���֤����ʱ�䣬�����˾;ܾ�����
                    ClockSkew = TimeSpan.Zero,//����ǻ������ʱ�䣬Ҳ����˵����ʹ���������˹���ʱ�䣬����ҲҪ���ǽ�ȥ������ʱ�� + ���壬Ĭ�Ϻ�����7���ӣ������ֱ������Ϊ0
                    RequireExpirationTime = true,
                };
            });


            #endregion

            #region  ȫ���쳣������ע��
            services.AddControllers(options =>
            {
                options.Filters.Add(new CustomerExceptionFilter());
            });
            #endregion

            //services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "�ƽӿ�", Version = "v1" });
                // ��ȡxml�ļ���
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // ��ȡxml�ļ�·��
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // ��ӿ�������ע�ͣ�true��ʾ��ʾ������ע��
                c.IncludeXmlComments(xmlPath, true);

                #region swagger��JWT��֤
                //����Ȩ��С��
                c.OperationFilter<AddResponseHeadersFilter>();
                c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                //��header�����token�����ݵ���̨
                c.OperationFilter<SecurityRequirementsOperationFilter>();
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT��Ȩ(���ݽ�������ͷ�н��д���)ֱ���������������Bearer {token}(ע������֮����һ���ո�) \"",
                    Name = "Authorization",// tĬ�ϵĲ�������
                    In = ParameterLocation.Header,// tĬ�ϴ��Authorization��Ϣ��λ��(����ͷ��)
                    Type = SecuritySchemeType.ApiKey
                });
                #endregion
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app
                             , IWebHostEnvironment env
                              ,ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Item.Api v1"));
            }

            //��־
            loggerFactory.AddLog4Net();

            //��������
            //����Cors
            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();

                builder.AllowAnyOrigin();
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication(); //����������֤��
            app.UseAuthorization(); //����Ƿ������Դ�����Ȩ

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        //�Զ�ע������ע��
        public void ConfigureContainer(ContainerBuilder build)
        {
            
            var file = System.IO.Path.Combine(AppContext.BaseDirectory, "Item.Repository.dll");
            build.RegisterAssemblyTypes(Assembly.LoadFile(file)).AsImplementedInterfaces();
            //�����޸Ļ�û������
            //build.RegisterAssemblyTypes(typeof(UsersRepository).Assembly)
            //     .Where(x => x.Name.EndsWith("Repository"))
            //     .AsImplementedInterfaces();

            //build.RegisterAssemblyTypes(typeof(UsersService).Assembly)
            //     .Where(x => x.Name.EndsWith("Service"))
            //     .AsImplementedInterfaces();

            //var file1 = System.IO.Path.Combine(AppContext.BaseDirectory, "Service.dll");
            //build.RegisterAssemblyTypes(Assembly.LoadFile(file1)).AsImplementedInterfaces();

        }
    }
}
