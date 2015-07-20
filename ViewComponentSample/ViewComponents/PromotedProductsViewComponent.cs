using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ViewComponentSample.Services;

namespace ViewComponentSample.ViewComponents
{
    [ViewComponent(Name = "PromotedProducts")]
    public class PromotedProductsViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public PromotedProductsViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productService.GetPromotedProducts();
            return View(products);
        }
    }
}
