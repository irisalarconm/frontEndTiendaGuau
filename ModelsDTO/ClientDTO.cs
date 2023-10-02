using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontEndTiendaGuau.ModelsDTO
{
    public class ClientDTO
    {
        
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [JsonPropertyName("nameClient")]
        public string NameClient { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [JsonPropertyName("lastnameClient")]
        public string LastnameClient { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "La Cantidad debe ser mayor que 0.")]
        [JsonPropertyName("dniClient")]
        public long DNIClient { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [JsonPropertyName("adressClient")]
        public string AdressClient { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "La Cantidad debe ser mayor que 0.")]
        [JsonPropertyName("phone")]
        public long Phone { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(0, 2, ErrorMessage = "La Cantidad debe ser mayor que 0.")]
        [JsonPropertyName("status")]
        public int status { get; set; }
    }
}
