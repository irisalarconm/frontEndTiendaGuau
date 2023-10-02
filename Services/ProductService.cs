using FrontEndTiendaGuau.ModelsDTO;
using System.Net.Http.Json;

namespace FrontEndTiendaGuau.Services
{
    public class ProductService : IProductService
    {

        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateProduct(ProductDTO productDTO)
        {
            var result = await _httpClient.PostAsync("/product", JsonContent.Create(productDTO));
        }

        public async Task DeleteProduct(int id)
        {
            await _httpClient.DeleteAsync($"/product/{id}");
        }

        public async Task<IEnumerable<ProductDTO>> GetProduct()
        {
            var response = await _httpClient.GetFromJsonAsync<ProductDTO[]>("/product");
            return response;
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<ProductDTO>($"/product/{id}");
            return response;
        }

        public async Task UpdateProduct(ProductDTO productDTO)
        {
            await _httpClient.PutAsync($"/product/{productDTO.ProductId}", JsonContent.Create(productDTO));
        }
    }
}
