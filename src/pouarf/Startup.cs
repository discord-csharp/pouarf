using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pouarf.DataAccess;
using Pouarf.Helpers;

namespace Pouarf
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PouarfDBContext>(options => options.UseInMemoryDatabase());
            services.AddSingleton<IRepository, GenericRepository>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddTransient<SampleData>();
            
            services.AddMvc();
            
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SampleData sampleData)
        {            

            
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
                sampleData.CreateSampleData();
            }
            
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
