using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.common.Dto;
using app.projectCastroDubraska.common.Request;

namespace app.projectCastroDubraska.Services.Interfaces
{
    public interface iClienteService
    {
        Task<BaseResponse<ClienteDto>> GetCliente(int id);

        Task<BaseResponse<List<ClienteDto>>> GetClienteLista();

        Task<BaseResponse<ClienteDto>> CrearCliente(ClienteRequest request);

        Task<BaseResponse<ClienteDto>> ActualizarCliente(int id, ClienteRequest request);

        Task<BaseResponse<string>> EliminarCliente(int id);
    }
}
