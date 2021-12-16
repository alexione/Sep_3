using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Server.Ui.Voyager;
using hospitalGQL.Data;
using hospitalGQL.GraphQL;
using hospitalGQL.GraphQL.Doctors;
using hospitalGQL.GraphQL.Patients;
using hospitalGQL.GraphQL.Prescriptions;
using hospitalGQL.GraphQL.Rooms;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace hospitalGQL
{
    
    
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql
            //     (Configuration.GetConnectionString("CommandConStr")));

            services
                .AddGraphQLServer()
                //.ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true)
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddType<DoctorType>()
                .AddType<PatientType>()
                .AddType<RoomType>()
                .AddType<PrescriptionType>()
                .AddProjections()
                .AddFiltering()
                .AddSorting();
            
            services.AddDbContextFactory<AppDbContext>(options => 
                    options.UseNpgsql
                        (Configuration.GetConnectionString("CommandConStr")), 
                ServiceLifetime.Scoped);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });

            app.UseGraphQLVoyager(new GraphQLVoyagerOptions()
            {
                GraphQLEndPoint = "/graphql",
                Path = "/graphql-voyager"
            });
        }
    }
}
