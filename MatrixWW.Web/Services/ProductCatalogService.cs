using MatrixWW.Web.Extensions;
using MatrixWW.Web.Models.Api;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MatrixWW.Web.Services
{
    public class ProductCatalogService : IProductCatalogService
    {
        private readonly HttpClient client;

        public ProductCatalogService(HttpClient httpClient)
        {
            this.client = httpClient;
        }

        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await client.DeleteAsync($"api/products/{id}");
        }

        public async Task<Product> Get(int id)
        {
            var response = await client.GetAsync($"api/products/{id}");
            return await response.ReadContentAs<Product>();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var response = await client.GetAsync("api/products");
            return await response.ReadContentAs<IEnumerable<Product>>();
        }

        public async Task<Product> Create(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<HttpResponseMessage> Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
