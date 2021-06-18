using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1_SistemasdeInformacion.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        [Display(Name = "Codigo (*):")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public int EmpleadoCodigo { get; set; }
        [Display(Name = "Apellidos (*):")]
        [StringLength(50, ErrorMessage = "No debe tener mas de 50 caracteres")]
        [MinLength(3, ErrorMessage = "El apellido debe tener mas de 3 caracteres")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string EmpleadoApellidos { get; set; }
        [Display(Name = "Nombres (*):")]
        [StringLength(50, ErrorMessage = "No debe tener mas de 50 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre debe tener mas de 3 caracteres")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string EmpleadoNombres { get; set; }
        [Display(Name = "Apodo:")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres")]
        public string EmpleadoApodo { get; set; }
        [Display(Name = "Dirección:")]
        [StringLength(400, ErrorMessage = "No debe tener mas de 400 caracteres")]
        public string EmpleadoDireccion { get; set; }
        [Display(Name = "Codigo Postal:")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public String EmpleadoCodigoPostal { get; set; }
        [Display(Name = "Telefono:")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public String EmpleadoTelefono { get; set; }
        [Display(Name = "Celular:")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public String EmpleadoCelular { get; set; }
        [Display(Name = "Fax:")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public String EmpleadoFax { get; set; }
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "No debe tener mas de 50 caracteres")]
        public string EmpleadoEmail { get; set; }
        [Display(Name = "Observaciones:")]
        [StringLength(1000, ErrorMessage = "No debe tener mas de 1000 caracteres")]
        public string EmpleadoObservaciones { get; set; }
    }
}
