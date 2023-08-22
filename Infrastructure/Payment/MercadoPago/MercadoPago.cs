using Application.DTOs.External;

namespace Infrastructure.Payment.MercadoPago
{
    public class MercadoPagoUseCase : Application.Interfaces.UseCases.IPaymentUseCase
    {
        public PagamentoResponse ProcessPayment(PagamentoRequest request)
        {
            return new PagamentoResponse
            {
                CodigoTransacao = Guid.NewGuid().ToString(),
                Status = Domain.Enums.PagamentoStatus.Aprovado
            };
        }

        public Application.Enums.PagamentoStatus? GetPaymentStatus(Model.WebhookNotification notification) 
        {
            try
            {
                if (notification.type == "payment.created" || notification.type == "payment.updated")
                {
                    var payment = GetOrderPayment(Convert.ToInt32(notification.data.id));
                    if (payment.status == "approved")
                        return Application.Enums.PagamentoStatus.Aprovado;
                }
            }
            catch (Exception)
            {
               
            }

            return null;
        }

        
        Model.Payment GetOrderPayment(int pedidoId)
        {
            //Aqui seria a chamada para o endpoint do MercadoLivre
            return new Model.Payment
            {
                status = "approved"
            };
        }
    }
}
