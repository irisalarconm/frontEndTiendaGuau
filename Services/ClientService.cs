using System.Net.Http.Json;
using System.Text.Json;
using FrontEndTiendaGuau.ModelsDTO;

namespace FrontEndTiendaGuau.Services
{
    public class ClientService: IClientService
    {
        private readonly HttpClient _httpClient;
        //private JsonSerializerOptions? id;

        public ClientService(HttpClient http) 
        {
            _httpClient = http;
        }

        public async Task CreateClient(ClientDTO client)
        {
            var result = await _httpClient.PostAsync("/client", JsonContent.Create(client));
            //ReadFromJsonAsync 
        }

        public async Task DeleteClient(int id)
        {
             await _httpClient.DeleteAsync($"/client/{id}");
            
        }

        public async Task<IEnumerable<ClientDTO>> GetClient()
        {
            var response = await _httpClient.GetFromJsonAsync<ClientDTO[]>("/client");
            return response;
            
        }

        public async Task <ClientDTO> GetClientById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<ClientDTO>($"/client/{id}");
            return response;
        }

        public async Task UpdateClient(ClientDTO client)
        {
            await _httpClient.PutAsync($"/client/{client.ClientId}", JsonContent.Create(client));
        }
    }
}
