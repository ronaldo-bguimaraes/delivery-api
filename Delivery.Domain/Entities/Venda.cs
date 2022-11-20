using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Delivery.Domain.Enums;

namespace Delivery.Domain.Entities
{
  public class Venda : EntityBase
  {
    [Key]
    [Column("VendaId")]
    public override int Id { get; set; }

    public double Subtotal { get; set; }

    public double Frete { get; set; }

    public DateTime DataVenda { get; set; }

    public double Desconto { get; set; }

    [Column(TypeName = "int")]
    public CondicaoVenda Condicao { get; set; }

    public virtual ICollection<ItemProduto> ItensProduto { get; set; }

    [ForeignKey("ClienteId")]
    public int? ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; }

    [ForeignKey("EntregadorId")]
    public int? EntregadorId { get; set; }

    public virtual Entregador Entregador { get; set; }

    public virtual ICollection<Pagamento> Pagamentos { get; set; }

    [ForeignKey("FornecedorId")]
    public int? FornecedorId { get; set; }

    public virtual Fornecedor Fornecedor { get; set; }

    [NotMapped]
    public double Total
    {
      get
      {
        return Subtotal - Desconto + Frete;
      }
    }

    public void SetDataVendaAtual()
    {
      DataVenda = DateTime.UtcNow;
    }

    public void Processar()
    {
      Fornecedor = ItensProduto.FirstOrDefault().Fornecedor;
      Subtotal = ItensProduto.Sum(e => e.Total);
    }

    public void SetSolicitada()
    {
      Condicao = CondicaoVenda.Solicitada;
    }

    public void SetConfirmada()
    {
      Condicao = CondicaoVenda.Confirmada;
    }

    public void SetCancelada()
    {
      Condicao = CondicaoVenda.Cancelada;
    }

    public Venda()
    {
      Pagamentos = new List<Pagamento>();
      ItensProduto = new List<ItemProduto>();
    }
  }
}
