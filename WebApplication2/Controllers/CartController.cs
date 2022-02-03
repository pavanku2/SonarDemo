using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;
using static WebApplication2.Services.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
//    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IPaymentService _paymentService;
        private readonly IShipmentService _shipmentService;

        public CartController(
          ICartService cartService,
          IPaymentService paymentService,
          IShipmentService shipmentService
        )
        {
            _cartService = cartService;
            _paymentService = paymentService;
            _shipmentService = shipmentService;
        }

        [HttpPost]
        public string CheckOut(ICard card, IAddressInfo addressInfo)
        {
            var result = _paymentService.Charge(_cartService.Total(), card);
            if (result)
            {
                _shipmentService.Ship(addressInfo, _cartService.Items());
                return "charged";
            }
            else
            {
                return "not charged";
            }
        }
    }

}
