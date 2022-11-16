using Delivery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Delivery.Tests
{
  public class SqlContextTest
  {
    private readonly IConfiguration? Configuration;
    private readonly string ConnectionString;
    private readonly DbContextOptions<SqlContext>? Options;
    public readonly SqlContext SqlContext;

    public SqlContextTest()
    {
      Configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true)
        .AddJsonFile("appsettings.Development.json", optional: true)
        .Build();

      ConnectionString = Configuration.GetSection("ConnectionStrings").GetValue<string>("DefaultConnection");

      Options = new DbContextOptionsBuilder<SqlContext>().UseSqlServer(ConnectionString).Options;

      SqlContext = new SqlContext(Options);
    }
  }
}
