using System.Text.Json.Serialization;

namespace FrontEndTiendaGuau.ModelsDTO
{
    public class ProductDTO
    {
        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        //[JsonPropertyName("nameClient")]
        //public string nameClient { get;set }

        [JsonPropertyName("nameProduct")]
        public string NameProduct { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}
