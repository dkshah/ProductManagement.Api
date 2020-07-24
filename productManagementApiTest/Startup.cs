using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using productManagementApiTest.Service;

namespace productManagementApiTest
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
            services.AddScoped<IProductService, ProductService>();
            services.AddControllers();
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

// Todo: (Not a Todo!) The time next to is only for reference purpose and with the presumption that you know all the technologies.
// Todo: If you do not know these tech, then I suggest you embark on a learning curve. You will be doing that a lot if were to join Kuber.
// Todo: Implement a CRUD operation for Product Entity using a mongo database (30 minutes)
// Todo: Seed the mongo database with 2 products at runtime (30 minutes)
// Todo: Enable docker for this project and create a docker compose file that will create MongoDb and use that for the API (1 hour)
// Todo: We have to enable price to be currency specific. So break it further into an object and keep the code clean (15 minutes)
// Todo: (Not a Todo!) We are essentially looking for a clean solution without jargons. It is imperative that you set the path that everyone will follow.
// Todo: (Not a Todo!) Please make sure the docker compose and docker builds work
