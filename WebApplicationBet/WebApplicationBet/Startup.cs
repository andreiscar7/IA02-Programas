using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApplicationBet.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace WebApplicationBet
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
            services.AddDbContext<AplicationsDBContext>(options => 
            options.UseInMemoryDatabase("RulleteDB"));
            services.AddMvc().AddJsonOptions(ConfigureJson);


        }

        private void ConfigureJson(MvcJsonOptions obj)
        {
            obj.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AplicationsDBContext context)
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
            if (!context.Rulette.Any())
            {
                context.Rulette.AddRange(new List<RuuletteBetting>()
                {
                    new RuuletteBetting() { name = "Juan" ,money = 10000, namber = 5},
              
                    new RuuletteBetting() { name = "Lina" , money = 10000 , namber = 15  },
                 
                    });
                context.SaveChanges();
            }
        }
    }
}
