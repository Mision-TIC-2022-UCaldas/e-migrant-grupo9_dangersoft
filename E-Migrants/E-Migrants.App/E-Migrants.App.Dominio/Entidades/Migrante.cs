using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrants.App.Dominio.Entidades
{
    public class Migrante
    {

        public int Id { get; set; }
        // // [Required, StringLength(30)] 
        public string nombre { get; set; }
        // [Required, StringLength(30)] 
        public string apellidos { get; set; }
        // [Required, StringLength(30)] 
        public string TipoDocumento { get; set; }
        // [Required, StringLength(30)] 
        public string NumeroDocumento { get; set; }
        // 
        
        public string PaisdeOrigen { get; set; }
        // [Required, StringLength(30)] 
        public DateTime FechaDeNacimiento { get; set; }
        // [Required] 
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string DireccionActual { get; set; }
        public string Ciudad { get; set; }
        public string SituacionLaboral { get; set; }
    }
}