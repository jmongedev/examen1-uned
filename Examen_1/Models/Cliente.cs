using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Display(Name = "Nombre completo")]
        public string NombreCompleto { get; set; }
     
        public List<Paquete> ListaPaquetes { get; set; }
        [Display(Name = "Cantidad ")]
        public int Cantidad { get; set; }
        [Display(Name = "Monto subtotal ")]
        public decimal MontoSubtotal { get; set; }
        [Display(Name = "Monto descuento ")]
        public decimal MontoDescuento { get; set; }
        [Display(Name = "Monto impuesto ")]
        public decimal MontoImpuesto { get; set; }
        [Display(Name = "Total ")]
        public decimal MontoTotal { get; set; }
    }
}
