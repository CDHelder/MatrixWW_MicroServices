using System.Collections.Generic;

namespace MatrixWW.Services.ProductCatalog.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
