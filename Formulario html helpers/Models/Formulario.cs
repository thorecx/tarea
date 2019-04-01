using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Formulario_html_helpers.Models
{
    public class Formulario
    {
        [Required (ErrorMessage = "Este campo es requerido")]
        public string cedula { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string apellido { get; set; }

        [Range (16, 125, ErrorMessage = "Debes de ser mayor de 15 años")]
        public int edad { get; set; }

        public string telefono { get; set; }

        [EmailAddress (ErrorMessage ="El correo que ingreso no es valido")]
        public string email { get; set; }
        public string genero { get; set; }
        public string estadoCivil { get; set; }
        public string[] hobbys { get; set; }
    }
}