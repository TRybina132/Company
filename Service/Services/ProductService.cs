using Domain.Entities;
using Infrastructure.Repositories.Abstractions;
using Service.Services.Abstractions;

namespace Service.Services
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts() =>
            await repository.GetAllAsync(asNoTracking: true);

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }
        public Task AddProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
