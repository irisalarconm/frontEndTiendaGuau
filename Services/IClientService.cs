using FrontEndTiendaGuau.ModelsDTO;

namespace FrontEndTiendaGuau.Services
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetClient();

        Task <ClientDTO> GetClientById(int id);

        Task CreateClient(ClientDTO client);

        Task UpdateClient(ClientDTO clientDTO);

        Task DeleteClient(int id);
    }
}
