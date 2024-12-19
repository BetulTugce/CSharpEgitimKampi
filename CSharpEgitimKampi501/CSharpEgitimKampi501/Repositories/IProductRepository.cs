using CSharpEgitimKampi501.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllAsync();
        Task CreateAsync(CreateProductDto createProductDto);
        Task UpdateAsync(UpdateProductDto updateProductDto);
        Task DeleteAsync(int id);
        Task<ResultProductDto> GetByIdAsync(int id);
    }
}
