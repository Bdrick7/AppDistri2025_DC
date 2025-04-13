using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.DataAccess.context;
using app.projectCastroDubraska.DataAccess;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio;

public class VentaDetalleRepository : crudGenericService<VentaDetalle>, iVentaDetalleRepositorio
{
    public VentaDetalleRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<VentaDetalle> CreateVentaDetalle(VentaDetalle entity)
    {
        return await InsertEntity(entity);
    }

    public async Task DeleteVentaDetalle(int id)
    {
        await DeleteEntity(id);
    }

    public async Task<VentaDetalle> GetVentaDetalle(int id)
    {
        return await SelectEntity(id);
    }

    public async Task<List<VentaDetalle>> GetVentaDetalleLista()
    {
        return await SelectEntitiesAll();
    }

    public async Task UpdateVentaDetalle(VentaDetalle entity)
    {
        await UpdateEntity(entity);
    }
}