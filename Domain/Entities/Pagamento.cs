namespace Domain.Entities
{
    public class Pagamento
    {
        public Pagamento(Enums.TipoPagamento tipoPagamentoId, string nome, string tokenCartao, decimal valor)
        {
            TipoPagamentoId = tipoPagamentoId;
            Nome = nome;
            TokenCartao = tokenCartao;
            Valor = valor;
        }

        public Enums.TipoPagamento TipoPagamentoId { get; set; }

        public string Nome { get; set; }

        public string TokenCartao { get; set; }

        public decimal Valor { get; set; }

        public Enums.PagamentoStatus? PagamentoStatus { get; set; }

        public string CodigoTransacao { get; set; }

        public void AtualizaCodigoTransacao(string codigo)
        { 
            this.CodigoTransacao = codigo;
        }
        public void AtualizaStatusPagamento(Enums.PagamentoStatus status)
        {
            this.PagamentoStatus = status;
        }

    }
}
