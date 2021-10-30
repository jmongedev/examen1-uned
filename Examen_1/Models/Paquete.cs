using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_1.Models
{
    public class Paquete
    {
        public int Id { get; set; }
        [Display(Name = "Nombre combo")]
        public string Nombre { get; set; }
        [Display(Name = "Código")]
        public string Codigo { get; set; }
        [Display(Name = "Precio por visita")]
        public decimal PrecioVisita { get; set; }
        public List<CaracteristicasPaquete> ListaCaracteristicas { get; set; }
        public byte Imagen { get; set; }
        public List<ExtraPaquete> ListaPaqueteExtras { get; set; }
    }
}
