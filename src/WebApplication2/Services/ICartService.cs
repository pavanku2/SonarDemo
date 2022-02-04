using static WebApplication2.Services.Models;

namespace WebApplication2.Services
{
    public interface ICartService
    {
        double Total();
        IEnumerable<CartItem> Items();

        //comment 
    }
}
