using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.common.Dto;
using app.projectCastroDubraska.common.Request;

namespace app.projectCastroDubraska.Services.Interfaces;

public interface IVentaDetalleService
{
    Task<BaseResponse<VentaDetalleDto>> GetVentaDetalle(int id);

    Task<BaseResponse<List<VentaDetalleDto>>> GetVentaDetalleLista();

    Task<BaseResponse<VentaDetalleDto>> CrearVentaDetalle(VentaDetalleRequest request);

    Task<BaseResponse<VentaDetalleDto>> ActualizarVentaDetalle(int id, VentaDetalleRequest request);

    Task<BaseResponse<string>> EliminarVentaDetalle(int id);
}