using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UruIt.God.Infraestructure.Abstractions;
using UruIt.God.Infraestructure.DataImplementations;
using UruIt.God.Infraestructure.DbContexts;
using UruIt.God.Services;
using UruIt.God.Services.Abstractions;
using UruIt.God.Services.Mappings;

namespace UruIt.God
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
            //Adding the connection string to the AppDbContext
            //var connString = Configuration.GetConnectionString("UruIt.God.Database");
            var connString = Configuration.GetConnectionString("UruIt.God.Database");
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(connString));

            //Registering UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Registering Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMatchService, MatchService>();
            services.AddScoped<IRoundService, RoundService>();


            //Configuring AutoMapper
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
                cfg.AddProfile(new MatchProfile());
                cfg.AddProfile(new RoundProfile());
            });
            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton<IMapper>(mapper);


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
