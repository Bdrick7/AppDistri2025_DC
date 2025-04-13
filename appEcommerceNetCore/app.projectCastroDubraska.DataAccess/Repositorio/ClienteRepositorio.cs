using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.DataAccess.context;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio
{
    public class ClienteRepositorio : crudGenericService<Cliente>, iClienteRepositorio
    {
        public ClienteRepositorio(AppDbContext context) : base(context)
        {

        }

        public async Task<Cliente> CreateCliente(Cliente entity)
        {
            return await InsertEntity(entity);
        }

        public async Task DeleteCliente(int id)
        {
            await DeleteEntity(id);
        }

        public async Task<Cliente> GetCliente(int id)
        {
            return await SelectEntity(id);
        }

        public async Task<List<Cliente>> GetClienteLista()
        {
            return await SelectEntitiesAll();
        }

        public async Task UpdateCliente(Cliente entity)
        {
            await UpdateEntity(entity);
        }
    }
}
