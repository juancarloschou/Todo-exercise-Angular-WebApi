using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using TodoApi.Models;

namespace TodoApi
{
    public class Startup
    {
        //variable para el nuevo web.config
        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            //accede al nuevo web.config
            var builder = new ConfigurationBuilder().SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITodoContext, TodoContext>(); //injeccion dependencias

            //services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));

            //accede al nuevo web.config, appsettings.json
            string conexion = ConfigurationExtensions.GetConnectionString(Configuration, "DefaultConnection");

            services.AddDbContext<TodoContext>(opt => opt.UseSqlServer(conexion));

            services.AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            //para que las propiedades se devuelvan con mayusculas y minusculas utilizadas y no se conviertan a camel
            //https://github.com/aspnet/Announcements/issues/194

            services.AddCors(); //permite que el cliente angular haga llamadas ajax al api rest estando en dominios distintos (CORS)
        }

        public void Configure(IApplicationBuilder app)
        {
            //permite que el cliente angular haga llamadas ajax al api rest estando en dominios distintos (CORS)
            app.UseCors(
                options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader()
            );

            app.UseMvc();
        }
    }
}