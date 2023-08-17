using API.Validation;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace API.Controllers
{
    [ApiController]
    [Route("Pedido")]
    public class PedidoController : ControllerBase
    {
        private readonly Application.Interfaces.UseCases.IPedidoUseCase _pedidoUseCase;

        public PedidoController(Application.Interfaces.UseCases.IPedidoUseCase pedidoUseCase)
        {
            this._pedidoUseCase = pedidoUseCase;
        }

        /// <summary>
        /// Lista todos os pedidos
        /// </summary>
        [HttpGet]
        [Route("list")]
        [ProducesResponseType(typeof(IEnumerable<Application.DTOs.Output.Pedido>), 200)]
        public ActionResult<IEnumerable<Application.DTOs.Output.Pedido>> List()
        {
            return Ok(_pedidoUseCase.List());
        }

        /// <summary>
        /// Lista todos os pedidos de um status
        /// </summary>
        /// <param name="status">Status do pedido</param>
        [HttpGet]
        [Route("listbystatus")]
        [ProducesResponseType(typeof(IEnumerable<Application.DTOs.Output.Pedido>), 200)]
        public ActionResult<IEnumerable<Application.DTOs.Output.Pedido>> ListByStatus(Application.Enums.PedidoStatus status)
        {
            return Ok(_pedidoUseCase.ListByStatus(status));
        }

        /// <summary>
        /// Cria um novo pedido. Deixe o ClienteId null ou 0 para fazer o pedido em modo anônimo.
        /// </summary>
        /// <param name="pedido">Dados do pedido</param>
        /// <response code="400" >Dados de cliente ou produtos inválidos</response>
        [HttpPost]
        [Route("order")]
        [CustonValidateModel]
        [ProducesResponseType(typeof(Validation.CustonValidationResultModel), 422)]
        public ActionResult<bool> CreateOrder(Application.DTOs.Imput.Pedido pedido)
        {
            try
            {
                var sucess = _pedidoUseCase.Order(pedido);
                return Ok(sucess);
            }
            catch (Application.CustomExceptions.BadRequestException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Altera o status de um pedido
        /// </summary>
        /// <param name="id">Id do pedido</param>
        /// <param name="status">Status do pedido</param>
        /// <response code="404" >Pedido não encontrado</response>
        [HttpPost]
        [Route("{id}/status/update")]
        public ActionResult<bool> UpdateOrderStatus(int id, Application.DTOs.Imput.PedidoStatusUpdate status)
        {
            try
            {
                return _pedidoUseCase.UpdateOrderStatus(id, status.Status);
            }
            catch (Application.CustomExceptions.NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
