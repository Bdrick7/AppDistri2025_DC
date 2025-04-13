using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.common.Dto;
using app.projectCastroDubraska.common.Request;

namespace app.projectCastroDubraska.Services.Interfaces;

public interface IProductoService
{
    Task<BaseResponse<ProductoDto>> GetProducto(int id);

    Task<BaseResponse<List<ProductoDto>>> GetProductoLista();

    Task<BaseResponse<ProductoDto>> CrearProducto(ProductoRequest request);

    Task<BaseResponse<ProductoDto>> ActualizarProducto(int id, ProductoRequest request);

    Task<BaseResponse<string>> EliminarProducto(int id);
}