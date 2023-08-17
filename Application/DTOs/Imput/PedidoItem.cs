using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Imput
{
    public class PedidoItem
    {
        [Required]
        public int? ProdutoId { get; set; }
        [Required]
        public int? Quantidade { get; set; }
    }
}
