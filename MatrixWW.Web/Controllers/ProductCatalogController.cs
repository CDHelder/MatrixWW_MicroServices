using MatrixWW.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MatrixWW.Web.Controllers
{
    public class ProductCatalogController : Controller
    {
        private readonly IProductCatalogService productCatalogService;

        public ProductCatalogController(IProductCatalogService productCatalogService)
        {
            this.productCatalogService = productCatalogService;
        }

        //TODO: Maak de view en test em 
        public async Task<IActionResult> Index()
        {
            var getProducts = productCatalogService.GetAll();
            await Task.WhenAll(getProducts);

            return View(getProducts.Result);
        }
    }
}
