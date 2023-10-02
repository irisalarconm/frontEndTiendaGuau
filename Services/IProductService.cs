using FrontEndTiendaGuau.ModelsDTO;

namespace FrontEndTiendaGuau.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProduct();

        Task<ProductDTO> GetProductById(int id);

        Task CreateProduct(ProductDTO productDTO);

        Task UpdateProduct(ProductDTO productDTO);

        Task DeleteProduct(int id);
    }
}
