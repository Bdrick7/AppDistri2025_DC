using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio;

public interface iVentaDetalleRepositorio
{
    Task<VentaDetalle> GetVentaDetalle(int id);
    Task<VentaDetalle> CreateVentaDetalle(VentaDetalle entity);
    Task<List<VentaDetalle>> GetVentaDetalleLista();
    Task UpdateVentaDetalle(VentaDetalle entity);
    Task DeleteVentaDetalle(int id);
}