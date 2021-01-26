using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crudAuto.Models
{
    public class Auto
    {   [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]   
        public int Id { get; set; }

        [Display(Name = "Patente")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(7, MinimumLength =6, ErrorMessage = "El campo debe contener entre 6 y 7 caracteres alfanumericos")]
        [RegularExpression(@"^([a-zA-Z]{2,3})([0-9]{3})([a-zA-Z]{2})?$",
            ErrorMessage = "Patente invalida.")]
        public string Patente { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(120, MinimumLength =3, ErrorMessage = "Longitud entre 4 y 120 caracteres")]
        public string Marca { get; set; }

        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(120, MinimumLength = 3 ,ErrorMessage = "Longitud entre 4 y 120 caracteres")]
        public string Modelo { get; set; }

        [Display(Name = "Año")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public int Año { get; set; }

        [Display(Name = "Kilometros")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public int Kms { get; set; }

        [Display(Name = "Foto")]
        public string Imagen { get; set; }
    }
}
