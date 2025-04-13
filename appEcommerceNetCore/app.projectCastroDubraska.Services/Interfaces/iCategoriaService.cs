using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.common.Dto;
using app.projectCastroDubraska.common.Request;

namespace app.projectCastroDubraska.Services.Interfaces
{
    public interface iCategoriaService
    {
        Task<BaseResponse<CategoriaDto>> GetCategoria(int id);

        Task<BaseResponse<List<CategoriaDto>>> GetCategoriaLista();

        Task<BaseResponse<CategoriaDto>> CrearCategoria(CategoriaRequest request);

        Task<BaseResponse<CategoriaDto>> ActualizarCategoria(int id, CategoriaRequest request);

        Task<BaseResponse<string>> EliminarCategoria(int id);
    }
}
