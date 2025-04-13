using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio;

public interface iUsuarioRepositorio
{
    Task<Usuario> GetUsuario(int id);
    Task<Usuario> CreateUsuario(Usuario entity);
    Task<List<Usuario>> GetUsuarioLista();
    Task UpdateUsuario(Usuario entity);
    Task DeleteUsuario(int id);
}
