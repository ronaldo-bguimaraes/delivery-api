namespace Delivery.Application.Dtos
{
  public class FornecedorDto : EntityDto
  {
    public string Cnpj { get; set; }

    public string RazaoSocial { get; set; }

    public int? UsuarioId { get; set; }
  }
}
