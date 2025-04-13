using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio
{
    public interface iCategoriaRepositorio
    {
        Task<Categoria> GetCategoria(int id);

        Task<Categoria> CreateCategoria(Categoria entity);

        Task<List<Categoria>> GetCategoriaLista();

        Task UpdateCategoria(Categoria entity);

        Task DeleteCategoria(int id);
    }
}
