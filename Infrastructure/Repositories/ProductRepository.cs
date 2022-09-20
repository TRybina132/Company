using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstractions;

namespace Infrastructure.Repositories
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext productContext) 
            : base(productContext)
        {
        }
    }
}
