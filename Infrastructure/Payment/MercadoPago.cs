using Application.DTOs.External;

namespace Infrastructure.Payment
{
    public class MercadoPagoUseCase : Application.Interfaces.UseCases.IPaymentUseCase
    {
        public PagamentoResponse ProcessPayment(PagamentoRequest request)
        {
            return new PagamentoResponse
            {
                CodigoTransacao = Guid.NewGuid().ToString(),
                Status = Application.Enums.StatusPagamento.Aprovado
            };
        }
    }
}
