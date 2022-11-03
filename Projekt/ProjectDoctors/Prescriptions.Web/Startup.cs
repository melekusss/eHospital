using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Prescriptions.Domain.PrescriptionsAggregate;
using Prescriptions.Infrastructure.Repositories;
using Prescriptions.Web.Application.Commands;
using Prescriptions.Web.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prescriptions.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Prescriptions.Web", Version = "v1" });
            });
            services.AddSingleton<IPrescriptionsRepository, PrescriptionRepository>();
            services.AddTransient<IPrescriptionsQuriesHandler, PrescriptionsQuriesHandler>();
            services.AddTransient<ICommandHandler<AddPrescriptionCommand>, PrescriptionsCommandsHandler>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prescriptions.Web v1");
                    c.RoutePrefix = string.Empty;

                });

            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
