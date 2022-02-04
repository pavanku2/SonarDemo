using static WebApplication2.Services.Models;

namespace WebApplication2.Services
{
    public interface IPaymentService
    {
        bool Charge(double total, ICard card);

    }
}
