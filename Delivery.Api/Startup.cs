using Autofac;
using Delivery.Application;
using Delivery.Infrastructure.CrossCutting.Ioc;
using Delivery.Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

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
      var connectionString = Configuration.GetConnectionString("DeliveryDatabase");
      services.AddCors();
      services.AddDbContext<SqlContext>(options => options.UseSqlServer(connectionString));
      services.AddControllers();

      services.AddMvc(config =>
      {
        var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
        config.Filters.Add(new AuthorizeFilter(policy));
      })
      .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

      services.AddAuthorization(options =>
      {
        options.AddPolicy("user", policy => policy.RequireClaim("Store", "user"));
        options.AddPolicy("admin", policy => policy.RequireClaim("Store", "admin"));
      });

      var key = Encoding.ASCII.GetBytes(Settings.Secret);

      services.AddAuthentication(x =>
      {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
      })
      .AddJwtBearer(x =>
      {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = new SymmetricSecurityKey(key),
          ValidateIssuer = false,
          ValidateAudience = false
        };
      });
      services.AddSwaggerGen(options =>
      {
        options.SwaggerDoc("v1", new OpenApiInfo { Title = "Delivery Api", Version = "v1" });
      });

    }

    public void ConfigureContainer(ContainerBuilder builder)
    {
      builder.RegisterModule(new ModuleIoc());
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
        options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
      });

      app.UseAuthentication();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
