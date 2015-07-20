using System.Threading.Tasks;
using ViewComponentSample.Models;

namespace ViewComponentSample
{
    interface IProductService
    {

        Task<Product[]> GetPromotedProducts();

    }
}
