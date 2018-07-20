using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using alba.Services;
using alba.Repositories;
using alba.Models;

namespace alba
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
            services.AddMvc()
                    .AddControllersAsServices();

            services.AddSingleton<InMemoryRepository<Song>>();
            services.AddSingleton<SongService>();

            services.AddOpenApi3("/openapi.json");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            AddSampleData(app);

        }

        private void AddSampleData(IApplicationBuilder app)
        {
            var songService = app.ApplicationServices.GetService<SongService>();
            var s1 = new Song("Oxygene 4", 240);
            var s2 = new Song("Oxygene 7", 180);

            songService.Create(s1);
            songService.Create(s2);
        }
    }
}
