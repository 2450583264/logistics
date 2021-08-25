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
            #region 全局异常过滤器
            services.AddControllers(options =>
            {
                options.Filters.Add<CustomerExceptionFilter>();
            });
            //services.AddControllers(options =>
            //{
            //    options.Filters.Add(new CustomerExceptionFilter());
            //});
            //过滤器
            //services.AddMvc(
            // options =>
            // {
            //     options.Filters.Add<HttpGlobalExceptionFilter>();//全局注册
            // });
            #endregion


            var jwtConfig = Configuration.GetSection("Jwt");
            //生成密钥
            var symmetricKeyAsBase64 = jwtConfig.GetValue<string>("Secret");
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);
            //认证参数
            services.AddAuthentication("Bearer")
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = false,//是否验证签名,不验证的画可以篡改数据，不安全在Configure方法添加认证方法
                    //4、生成Jwt的Token令牌
                    IssuerSigningKey = signingKey,//解密的密钥
                    ValidateIssuer = true,//是否验证发行人，就是验证载荷中的Iss是否对应ValidIssuer参数
                    ValidIssuer = jwtConfig.GetValue<string>("Iss"),//发行人
                    ValidateAudience = true,//是否验证订阅人，就是验证载荷中的Aud是否对应ValidAudience参数
                    ValidAudience = jwtConfig.GetValue<string>("Aud"),//订阅人
                    ValidateLifetime = true,//是否验证过期时间，过期了就拒绝访问
                    ClockSkew = TimeSpan.Zero,//这个是缓冲过期时间，也就是说，即使我们配置了过期时间，这里也要考虑进去，过期时间 + 缓冲，默认好像是7分钟，你可以直接设置为0
                    RequireExpirationTime = true,
                };
            });

            services.AddTransient<Token>();




            //连接  数据库  字符串
            ConfigHelper.ConnString = Configuration.GetConnectionString("Default");
            //服务注入
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


            #region JWT生成码
            var jwtConfig = Configuration.GetSection("Jwt");
            //生成密钥
            var symmetricKeyAsBase64 = jwtConfig.GetValue<string>("Secret");
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);
            //认证参数
            services.AddAuthentication("Bearer")
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = false,//是否验证签名,不验证的画可以篡改数据，不安全在Configure方法添加认证方法
                    //4、生成Jwt的Token令牌
                    IssuerSigningKey = signingKey,//解密的密钥
                    ValidateIssuer = true,//是否验证发行人，就是验证载荷中的Iss是否对应ValidIssuer参数
                    ValidIssuer = jwtConfig.GetValue<string>("Iss"),//发行人
                    ValidateAudience = true,//是否验证订阅人，就是验证载荷中的Aud是否对应ValidAudience参数
                    ValidAudience = jwtConfig.GetValue<string>("Aud"),//订阅人
                    ValidateLifetime = true,//是否验证过期时间，过期了就拒绝访问
                    ClockSkew = TimeSpan.Zero,//这个是缓冲过期时间，也就是说，即使我们配置了过期时间，这里也要考虑进去，过期时间 + 缓冲，默认好像是7分钟，你可以直接设置为0
                    RequireExpirationTime = true,
                };
            });


            #endregion

            #region  全局异常过滤器注入
            services.AddControllers(options =>
            {
                options.Filters.Add(new CustomerExceptionFilter());
            });
            #endregion

            //services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "浩接口", Version = "v1" });
                // 获取xml文件名
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // 获取xml文件路径
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // 添加控制器层注释，true表示显示控制器注释
                c.IncludeXmlComments(xmlPath, true);

                #region swagger用JWT验证
                //开启权限小锁
                c.OperationFilter<AddResponseHeadersFilter>();
                c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                //在header中添加token，传递到后台
                c.OperationFilter<SecurityRequirementsOperationFilter>();
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传递)直接在下面框中输入Bearer {token}(注意两者之间是一个空格) \"",
                    Name = "Authorization",// t默认的参数名称
                    In = ParameterLocation.Header,// t默认存放Authorization信息的位置(请求头中)
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

            //日志
            loggerFactory.AddLog4Net();

            //跨域设置
            //配置Cors
            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();

                builder.AllowAnyOrigin();
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication(); //这个是添加认证的
            app.UseAuthorization(); //这个是方法里自带的授权

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        //自动注册依赖注入
        public void ConfigureContainer(ContainerBuilder build)
        {
            
            var file = System.IO.Path.Combine(AppContext.BaseDirectory, "Item.Repository.dll");
            build.RegisterAssemblyTypes(Assembly.LoadFile(file)).AsImplementedInterfaces();
            //这里修改还没有完善
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
