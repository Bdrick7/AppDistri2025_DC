using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.Services.Interfaces;
using app.projectCastroDubraska.DataAccess.Repositorio;
using app.projectCastroDubraska.common.Dto;
using app.projectCastroDubraska.common.Request;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.Services.Implementations
{
    public class CategoriaService : iCategoriaService
    {
        private readonly iCategoriaRepositorio _repository;

        public CategoriaService(iCategoriaRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<BaseResponse<CategoriaDto>> ActualizarCategoria(int id, CategoriaRequest request)
        {
            var response = new BaseResponse<CategoriaDto>();
            try
            {
                Categoria categoria = new();
                categoria.Id = id;
                categoria.Nombre = request.Nombre;
                categoria.Descripcion = request.Descripcion;
                categoria.Fecha = DateTime.Now;
                categoria.Estado = true;

                await _repository.UpdateCategoria(categoria);

                response.Result = new CategoriaDto
                {
                    Id = categoria.Id,
                    Nombre = categoria.Nombre,
                    Descripcion = categoria.Descripcion,
                };
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public async Task<BaseResponse<CategoriaDto>> CrearCategoria(CategoriaRequest request)
        {
            var response = new BaseResponse<CategoriaDto>();
            try
            {
                Categoria categoryEntity = new();
                categoryEntity.Nombre = request.Nombre;
                categoryEntity.Descripcion = request.Descripcion;
                categoryEntity.Estado = true;
                categoryEntity.Fecha = DateTime.Now;

                var categoria = await _repository.CreateCategoria(categoryEntity);

                response.Result = new CategoriaDto
                {
                    Id = categoria.Id,
                    Nombre = categoria.Nombre,
                    Descripcion = categoria.Descripcion
                };

                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public async Task<BaseResponse<string>> EliminarCategoria(int id)
        {
            var response = new BaseResponse<string>();

            try
            {
                await _repository.DeleteCategoria(id);

                response.Result = "OK";
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<BaseResponse<CategoriaDto>> GetCategoria(int id)
        {
            var response = new BaseResponse<CategoriaDto>();
            try
            {
                var categoria = await _repository.GetCategoria(id);
                if (categoria == null)
                {
                    response.Success = false;
                    response.ErrorMessage = "Registro no encontrado";
                    return response;
                }

                response.Result = new CategoriaDto
                {
                    Id = categoria.Id,
                    Nombre = categoria.Nombre,
                    Descripcion = categoria.Descripcion
                };

                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }


        public async Task<BaseResponse<List<CategoriaDto>>> GetCategoriaLista()
        {
            var response = new BaseResponse<List<CategoriaDto>>();
            try
            {
                var result = await _repository.GetCategoriaLista();

                response.Result = result.Select(p => new CategoriaDto
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion
                }).ToList();
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
