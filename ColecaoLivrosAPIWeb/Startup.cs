using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColecaLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Dominio.Models.Interfaces;
using ColecaoLivrosAPI.Repositorio.Contexto;
using ColecaoLivrosAPI.Repositorio.Repositorios;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AutoMapper;
using ColecaoLivrosAPI.Application.MappingProfiles;
using ColecaoLivrosAPIWeb.StartUp.MappingProfiles;
using ColecaoLivrosAPI.Application.Commands;
using ColecaoLivrosAPI.Application.Commands.Autor;
using ColecaoLivrosAPIWeb.Middlewares;

namespace ColecaoLivrosAPI.APIWeb
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional:false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {   
            
            services.AddControllers();
            services.AddAutoMapper(typeof(MappingLivro));
            services.AddAutoMapper(typeof(MappingAutor));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddMediatR(typeof(GetLivrosCommand).Assembly, this.GetType().Assembly);
            services.AddMediatR(typeof(GetLivroByIdCommand).Assembly, this.GetType().Assembly);
            services.AddMediatR(typeof(PostLivroCommand).Assembly, this.GetType().Assembly);
            services.AddMediatR(typeof(GetAutoresCommand).Assembly, this.GetType().Assembly);
            services.AddMediatR(typeof(PostAutorCommand).Assembly, this.GetType().Assembly);
            var connectionString = Configuration.GetConnectionString("ColecaoLivroDB");
            services.AddDbContext<ColecaoLivrosAPIContext>(option =>
                                                                option.UseLazyLoadingProxies()
                                                                .UseMySql(connectionString,
                                                                                    m => m.MigrationsAssembly("ColecaoLivrosAPI.Repository")));
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware(typeof(ErrorHandlingMiddleware));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
