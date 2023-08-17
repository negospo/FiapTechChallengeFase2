using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Imput
{
    public class PagamentoRequest
    {
        [Required]
        public Enums.TipoPagamento? TipoPagamentoId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string TokenCartao { get; set; }

        [Required]
        public decimal Valor { get; set; }
    }
}
