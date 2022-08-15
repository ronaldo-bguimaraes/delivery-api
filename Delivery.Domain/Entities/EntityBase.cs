using System.ComponentModel.DataAnnotations;

namespace Delivery.Domain.Entities
{
  public abstract class EntityBase
  {
    [Key]
    public abstract int Id { get; set; }
  }
}
