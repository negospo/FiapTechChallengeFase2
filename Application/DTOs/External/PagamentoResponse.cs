namespace Application.DTOs.External
{
    public class PagamentoResponse
    {
        public string CodigoTransacao { get; set; }
        public Enums.StatusPagamento Status { get; set; }
    }
}
