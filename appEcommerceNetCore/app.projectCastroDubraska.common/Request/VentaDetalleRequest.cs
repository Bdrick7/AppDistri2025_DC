﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.projectCastroDubraska.Entities.Models;

namespace app.projectCastroDubraska.common.Request;

public class VentaDetalleRequest
{
    [Required(ErrorMessage = "El campo VentaId es obligatorio")]
    public string? VentaId { get; set; }
    //[Required(ErrorMessage = "El campo Venta es obligatorio")]
    public Venta? Venta { get; set; }
    [Required(ErrorMessage = "El campo NumeroItem es obligatorio")]
    public int NumeroItem { get; set; }
    [Required(ErrorMessage = "El campo ProductoId es obligatorio")]
    public int ProductoId { get; set; }
    //[Required(ErrorMessage = "El campo Producto es obligatorio")]
    public Producto? Producto { get; set; }
    [Required(ErrorMessage = "El campo PrecioUnitario es obligatorio")]
    public decimal PrecioUnitario { get; set; }
    [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
    public decimal Cantidad { get; set; }
    [Required(ErrorMessage = "El campo Total es obligatorio")]
    public decimal Total { get; set; }
}