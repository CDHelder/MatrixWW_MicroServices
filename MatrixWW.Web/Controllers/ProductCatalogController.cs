using MatrixWW.Web.Models.Api;
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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var getProducts = productCatalogService.GetAll();
            await Task.WhenAll(getProducts);

            return View(getProducts.Result);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var getProduct = productCatalogService.Get(id);
            await Task.WhenAll(getProduct);

            return View(getProduct.Result);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var getProduct = productCatalogService.Get(id);
            await Task.WhenAll(getProduct);

            return View(getProduct.Result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Product product)
        {
            var deleteProduct = productCatalogService.Delete(product.Id);
            await Task.WhenAll(deleteProduct);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            return View();
        }
    }
}
