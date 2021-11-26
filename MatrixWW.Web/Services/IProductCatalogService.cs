using MatrixWW.Web.Models.Api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatrixWW.Web.Services
{
    public interface IProductCatalogService
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
