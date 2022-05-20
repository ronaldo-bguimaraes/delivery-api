using Autofac;
using Delivery.Infrastructure.CrossCutting.IOC;
using Delivery.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Delivery.Api
{
  //Swagger (OpenAPI) is a language-agnostic specification for describing REST APIs
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
      var connection = Configuration["SqlConnection:SqlConnectionString"];
      services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
      services.AddControllers();
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
      services.AddSwaggerGen(options =>
      {
        options.SwaggerDoc("v1", new OpenApiInfo { Title = "Delivery Api", Version = "v1" });
      });
    }

    public void ConfigureContainer(ContainerBuilder builder)
    {
      builder.RegisterModule(new ModuleIOC());
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.UseSwagger();
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Delivery Api");
      });
      app.UseHttpsRedirection();
      app.UseRouting();
      app.UseCors(options =>
      {
        options.AllowAnyOrigin();
      });
      app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
