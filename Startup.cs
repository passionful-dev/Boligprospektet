using Boligprospektet.Models.Models_Indhold_activitet;
using Boligprospektet.Models.Models_Indhold;
using Boligprospektet.Models.Models_Bolig_type_activitet;
using Boligprospektet.Models.Models_Bolig_type;
using Boligprospektet.Models.Models_Bolig_activitet;
using Boligprospektet.Models.Models_Facilitet;
using Boligprospektet.Models.Models_Bolig;
using Boligprospektet.Models.Models_User_activitet;
using Boligprospektet.Models.Models_User;
using Boligprospektet.Models; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Boligprospektet
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private readonly IConfiguration _configuration; 
		public Startup(IConfiguration configuration) 
		{ 
			_configuration = configuration; 
		} 
		public void ConfigureServices(IServiceCollection services) 
		{ 
			services.AddDbContextPool<AppDbContext>( 
				options => options.UseSqlServer(_configuration.GetConnectionString( 
					"BoligprospektetDBConnection"))); 
 
			services.AddRazorPages(); 	
			services.AddScoped<IIndhold_activitetRepository, SQLIndhold_activitetRepository>(); 	
			services.AddScoped<IIndholdRepository, SQLIndholdRepository>(); 	
			services.AddScoped<IBolig_type_activitetRepository, SQLBolig_type_activitetRepository>(); 	
			services.AddScoped<IBolig_typeRepository, SQLBolig_typeRepository>(); 	
			services.AddScoped<IBolig_activitetRepository, SQLBolig_activitetRepository>(); 	
			services.AddScoped<IFacilitetRepository, SQLFacilitetRepository>(); 	
			services.AddScoped<IBoligRepository, SQLBoligRepository>(); 	
			services.AddScoped<IUser_activitetRepository, SQLUser_activitetRepository>(); 	
			services.AddScoped<IUserRepository, SQLUserRepository>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); 
			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute("default", "{controller=User}/{action=Details}/{id?}");
			});

        }
    }
}
