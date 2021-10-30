using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public List<Paquete> ListaPaquetes { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoSubtotal { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoImpuesto { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
