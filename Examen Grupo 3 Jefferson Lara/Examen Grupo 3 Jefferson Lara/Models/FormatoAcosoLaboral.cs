using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Grupo_3_Jefferson_Lara.Models
{
    public class FormatoAcosoLaboral
    {
        [Key]
        public int Id { get; set; }

        public string Fecha { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [Display(Name ="Nombre")]
        [StringLength(40, ErrorMessage = "No debe de tener mas de 40 caracteres.")]
        [MinLength(10, ErrorMessage = "Tiene que tener mas de 10 caracteres.")]
        public string Nombre { get; set; }

        public string Identidad { get; set; }

        public string CC { get; set; }

        public string NumeroCelular { get; set; }

        public string Dependencia { get; set; }

        public string Cargo { get; set; }
        
        public string Correo { get; set; }

        public string ParrafoHechos { get; set; }

        public string Prueba { get; set; }

    }
}
