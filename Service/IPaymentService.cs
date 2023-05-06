using Entity;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public interface IPaymentService
    {
        Task CreateAsync(Bill bill, int[] proids);
        Task AddProductBill(ProductBill pbill);
        Task ClearCart(int userid);
    }
}
