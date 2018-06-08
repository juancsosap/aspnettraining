using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pagina.Models
{
    public class Persona
    {
        public int id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_requerido")]
        [StringLength(100, MinimumLength = 5, ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_longitud")]
        [Display(ResourceType = typeof(Recursos.Persona.Modelo), Name = "nombre")]
        public String nombre { get; set; }

        [Required(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_requerido")]
        [StringLength(100, MinimumLength = 5, ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_longitud")]
        [Display(ResourceType = typeof(Recursos.Persona.Modelo), Name = "apellido")]
        public String apellido { get; set; }

        [Required(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_requerido")]
        [Range(0, 150, ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_rango")]
        [System.Web.Mvc.Remote("Validador", "Persona", ErrorMessage = "El valor debe ser par")]
        [Display(ResourceType = typeof(Recursos.Persona.Modelo), Name = "edad")]
        public int edad { get; set; }

        [Required(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_requerido")]
        [EmailAddress(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_email")]
        [DataType(DataType.EmailAddress)]
        [Display(ResourceType = typeof(Recursos.Persona.Modelo), Name = "email")]
        public String email { get; set; }

        [NotMapped]
        [Required(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_requerido")]
        [EmailAddress(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_email")]
        [Compare("email", ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_comparar")]
        [DataType(DataType.EmailAddress)]
        [Display(ResourceType = typeof(Recursos.Persona.Modelo), Name = "emailval")]
        public String emailval { get; set; }

        [Required(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_requerido")]
        [StringLength(500, MinimumLength = 20, ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_longitud")]
        [DataType(DataType.MultilineText)]
        [Display(ResourceType = typeof(Recursos.Persona.Modelo), Name = "direccion")]
        public String direccion { get; set; }

        [Required(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_requerido")]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(Recursos.Persona.Modelo), Name = "contrasena")]
        public String contrasena { get; set; }

        [NotMapped]
        [Required(ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_requerido")]
        [Compare("contrasena", ErrorMessageResourceType = typeof(Recursos.Vista), ErrorMessageResourceName = "error_comparar")]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(Recursos.Persona.Modelo), Name = "contrasenaval")]
        public String contrasenaval { get; set; }
    }
}