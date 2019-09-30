using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore6.Models
{
    public class FakeProductRepository //: IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Atmar Signature Model Football", Price = 25},
            new Product { Name = "Surfboard", Price = 179},
            new Product { Name = "Running shoes", Price = 95},
        }.AsQueryable<Product>();
    }
}
