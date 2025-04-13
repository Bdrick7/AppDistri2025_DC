using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio;

public interface IVentaRepository
{
    Task<Venta> GetVenta(int id);
    Task<Venta> CreateVenta(Venta entity);
    Task<List<Venta>> GetVentaLista();
    Task UpdateVenta(Venta entity);
    Task DeleteVenta(int id);
}