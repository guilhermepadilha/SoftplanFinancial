﻿using Financial.Application;
using Financial.Application.Interface;
using Financial.Domain.Interface.Services;
using Financial.Domain.Services;
using Financial.Service;
using Financial.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepoGit.Application;
using RepoGit.Application.Interface;
using RepoGit.Domain.Interface;
using RepoGit.Domain.Interface.Services;
using RepoGit.Domain.Services;
using RepoGit.Infra.Data;

namespace Financial
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IFinancialAppService, FinancialAppService>();
            services.AddTransient<IFinancialService, FinancialService>();            
            services.AddTransient<IBacenFacade, BacenFacade>();
            services.AddTransient<IRepoGitAppService, RepoGitAppService>();
            services.AddTransient<IRepoGitService, RepoGitService>();
            services.AddTransient<IRepoGitRepository, RepoGitRepository>();
            
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
