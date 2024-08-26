using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNota.clases
{
    internal class Nota
    {
        public double primeraNota { get; set; }
        public double segundaNota { get; set; }
        public double terceraNota { get; set; }
        public double calcularPromedio()
        {
            return this.primeraNota + this.segundaNota + this.terceraNota;
        }
        public Nota()
        {
        }
    }
}
