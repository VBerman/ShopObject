using Microsoft.EntityFrameworkCore;
using ShopObject.Model;

namespace ShopObject.Services
{
    public class ClientService
    {
        private readonly ShopObjectContext appDBContext;
        public ClientService(ShopObjectContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public async Task<List<Client>> GetClients()
        {
            var result = await appDBContext.Clients.ToListAsync();
            return result;
        }
    }
}
