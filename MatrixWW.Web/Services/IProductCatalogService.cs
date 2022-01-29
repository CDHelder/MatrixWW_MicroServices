using MatrixWW.Web.Models.Api;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MatrixWW.Web.Services
{
    public interface IProductCatalogService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> Get(int id);
        Task<HttpResponseMessage> Update(Product product);
        Task<Product> Create(Product product);
        Task<HttpResponseMessage> Delete(int id);
    }
}
