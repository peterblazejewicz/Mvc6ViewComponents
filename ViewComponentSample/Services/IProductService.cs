using System.Threading.Tasks;
using ViewComponentSample.Models;

namespace ViewComponentSample.Services
{
    public interface IProductService
    {

        Task<Product[]> GetPromotedProducts();

    }
}
