using static WebApplication2.Services.Models;

namespace WebApplication2.Services
{
    public interface IShipmentService
    {
        void Ship(IAddressInfo info, IEnumerable<CartItem> items);

    }
}
