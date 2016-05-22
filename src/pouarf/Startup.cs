using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pouarf.DataAccess;
using Pouarf.Helpers;
using System.Threading.Tasks;

namespace Pouarf
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<PouarfDbContext>(options => options.UseInMemoryDatabase());
            services.AddScoped<IContactProvider, ContactProvider>();
            services.AddSingleton<MockPeople>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MockPeople mockData)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                Task.Run(async () => await mockData.CreateSampleData());
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
