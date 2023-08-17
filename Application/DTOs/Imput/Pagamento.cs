namespace Application.DTOs.Imput
{
    public class Pagamento
    {
        public Enums.TipoPagamento TipoPagamento { get; set; }

        public string Nome { get; set; }

        public string TokenCartao { get; set; }
    }
}
