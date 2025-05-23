﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.DataAccess.Repositorio;

public interface iProductoRepositorio
{
    Task<Producto> GetProducto(int id);
    Task<Producto> CreateProducto(Producto entity);
    Task<List<Producto>> GetProductoLista();
    Task UpdateProducto(Producto entity);
    Task DeleteProducto(int id);
}
