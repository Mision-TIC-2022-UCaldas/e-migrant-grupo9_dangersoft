using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrants.App.Dominio.Entidades
{
    public class Migrante
    {

        public int Id { get; set; }
        [Required, StringLength(30)] 
        public string nombre { get; set; }
        [Required, StringLength(30)] 
        public string apellidos { get; set; }
        [Required, StringLength(30)] 
        public string TipoDocumento { get; set; }
        [Required, StringLength(30)] 
        public string NumeroDocumento { get; set; }
        
        [Required, StringLength(30)]
        public string PaisdeOrigen { get; set; }
        
        public DateTime FechaDeNacimiento { get; set; }
       [Required, StringLength(40)] 
        public string Email { get; set; }
        [Required, StringLength(20)] 
        public string Telefono { get; set; }
        [Required, StringLength(30)] 
        public string DireccionActual { get; set; }
        [Required, StringLength(30)]
        public string Ciudad { get; set; }
        [Required, StringLength(20)]
        public string SituacionLaboral { get; set; }
    }
}