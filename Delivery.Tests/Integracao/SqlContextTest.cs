using Delivery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Delivery.Tests
{
  public class SqlContextTest
  {
    private IConfiguration? configuration;
    private string connectionString;
    private DbContextOptions<SqlContext>? options;
    private SqlContext sqlContext;

    public SqlContextTest()
    {
      configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true)
        .AddJsonFile("appsettings.Production.json", optional: true)
        .AddJsonFile("appsettings.Development.json", optional: true)
        .Build();

      connectionString = configuration
        .GetSection("ConnectionStrings")
        .GetValue<string>("DefaultConnection");

      options = new DbContextOptionsBuilder<SqlContext>()
        .UseSqlServer(connectionString)
        .Options;

      sqlContext = new SqlContext(options);
    }

    public SqlContext SqlContext
    {
      get
      {
        return sqlContext;
      }
    }
  }
}