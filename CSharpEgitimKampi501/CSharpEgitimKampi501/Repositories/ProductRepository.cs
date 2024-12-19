using CSharpEgitimKampi501.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreateAsync(CreateProductDto createProductDto)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultProductDto> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(UpdateProductDto updateProductDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
