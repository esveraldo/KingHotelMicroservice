using KingHotelPayments.Api.Models;
using KingHotelPayments.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KingHotelPayments.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentsInfoInputModel paymentInfoInputModel)
        {
            try
            {
                var result = await _paymentService.Process(paymentInfoInputModel);

                if(!result)
                    return BadRequest(new { Message=$"Houve um erro ao realizar o pagamento, por favor, tente mais tarde." });

                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(new { Message=$"Erro: {e}" }); ;
            }
        }
    }
}
