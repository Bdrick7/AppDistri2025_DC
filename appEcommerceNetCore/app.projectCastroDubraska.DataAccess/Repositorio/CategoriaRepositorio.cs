using System;
using app.projectCastroDubraska.DataAccess.context;
using app.projectCastroDubraska.DataAccess.Repositorio;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess;

public class CategoriaRepository : crudGenericService<Categoria>, iCategoriaRepositorio
{
    public CategoriaRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<Categoria> CreateCategoria(Categoria entity)
    {
        return await InsertEntity(entity);
    }

    public async Task DeleteCategoria(int id)
    {
        await DeleteEntity(id);
    }

    public async Task<Categoria> GetCategoria(int id)
    {
        return await SelectEntity(id);
    }

    public async Task<List<Categoria>> GetCategoriaLista()
    {
        return await SelectEntitiesAll();
    }

    public async Task UpdateCategoria(Categoria entity)
    {
        await UpdateEntity(entity);
    }
}