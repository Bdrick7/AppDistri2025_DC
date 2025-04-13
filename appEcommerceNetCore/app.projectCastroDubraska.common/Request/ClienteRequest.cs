using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.projectCastroDubraska.common.Request
{
    public class ClienteRequest
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio y/o no es válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio y/o no es válido")]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(10, ErrorMessage = "El ancho del campo debe tener máximo 10 dígitos")]
        public string CedulaIdentidad { get; set; }
    }
}
