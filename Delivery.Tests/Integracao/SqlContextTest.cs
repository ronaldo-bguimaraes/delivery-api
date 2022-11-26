using Delivery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Delivery.Tests
{
  public class SqlContextTest
  {
    private readonly DbContextOptions<SqlContext>? Options;
    public readonly SqlContext SqlContext;

    public SqlContextTest()
    {
      Options = new DbContextOptionsBuilder<SqlContext>().UseInMemoryDatabase("DeliveryTest").Options;
      SqlContext = new SqlContext(Options);
    }
  }
}
