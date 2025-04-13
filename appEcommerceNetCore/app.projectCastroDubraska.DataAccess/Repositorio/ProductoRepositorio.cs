using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.DataAccess.context;
using app.projectCastroDubraska.DataAccess;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio;

public class ProductoRepository : crudGenericService<Producto>, iProductoRepositorio
{
    public ProductoRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<Producto> CreateProducto(Producto entity)
    {
        return await InsertEntity(entity);
    }

    public async Task DeleteProducto(int id)
    {
        await DeleteEntity(id);
    }

    public async Task<Producto> GetProducto(int id)
    {
        return await SelectEntity(id);
    }

    public async Task<List<Producto>> GetProductoLista()
    {
        return await SelectEntitiesAll();
    }

    public async Task UpdateProducto(Producto entity)
    {
        await UpdateEntity(entity);
    }
}