﻿using Acesscorp.Applications.Contract.TipoDeDado;
using Acesscorp.Applications.Contract.TipoDeAtributo;
using Acesscorp.Applications.Implementation.TipoDeDado;
using Acesscorp.Applications.Implementation.TipoDeAtributo;
using Acesscorp.Domains.Contracts.Repositories;
using Acesscorp.Domains.Contracts.Services;
using Acesscorp.Domains.Services;
using Acesscorp.Infrastructures.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace AspNetMvc.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .AddControllersAsServices()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Configurando o serviço de documentação do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Teste Prático Acesscorp",
                    Version = "v1",
                    Description = "TESTE PRÁTICO API REST criada com o ASP.NET Core",
                    Contact = new Contact
                    {
                        Name = "Roberto Gomes da Silva",
                        Email = "r19gomes@gmail.com",
                        Url = "https://github.com/r19gomes"
                    }
                });
            });

            services.AddScoped<ITipoDeDadoRepositories, TipoDeDadoRepositories>();
            services.AddScoped<ITipoDeDadoServices, TipoDeDadoServices>();
            services.AddScoped<ITipoDeDadoAppService, TipoDeDadoAppService>();

            services.AddScoped<ITipoDeAtributoRepositories, TipoDeAtributoRepositories>();
            services.AddScoped<ITipoDeAtributoServices, TipoDeAtributoServices>();
            services.AddScoped<ITipoDeAtributoAppService, TipoDeAtributoAppService>();

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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "TESTE PRÁTICO API V1");
            });
        }

    }
}