using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Venda : EntityBase
  {
    [Key]
    [Column("VendaId")]
    public override int Id { get; set; }
    public Cliente cliente_id { get; set; }
    public double subtotal { get; set; }
    public double frete { get; set; }
    public double total { get; set; }
    public String data_venda { get; set; }
    public double desconto { get; set; }
    public bool condicao { get; set; }
    public int entregador_id { get; set; }
    public Entregador entregador { get; set; }
    public int pagamento_id { get; set; }
    public Pagamento pagamento { get; set; }
  }
}
