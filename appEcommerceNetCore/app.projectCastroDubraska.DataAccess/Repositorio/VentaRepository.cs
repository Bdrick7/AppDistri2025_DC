using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.DataAccess.context;
using app.projectCastroDubraska.DataAccess.Repositorio;
using app.projectCastroDubraska.DataAccess;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio;

public class VentaRepository : crudGenericService<Venta>, IVentaRepository
{
    public VentaRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<Venta> CreateVenta(Venta entity)
    {
        return await InsertEntity(entity);
    }

    public async Task DeleteVenta(int id)
    {
        await DeleteEntity(id);
    }

    public async Task<Venta> GetVenta(int id)
    {
        return await SelectEntity(id);
    }

    public async Task<List<Venta>> GetVentaLista()
    {
        return await SelectEntitiesAll();
    }

    public async Task UpdateVenta(Venta entity)
    {
        await UpdateEntity(entity);
    }
}