using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_de_aseguransa_de_autos
{

    public struct PolizaResultado
    {
        public PolizaResultado(DateTime FechaTermino, decimal Prima)
        {
            FecT = FechaTermino;
            Pri = Prima;
        }
        public DateTime FecT { get; set; }
        public decimal Pri { get; set; }
    }
}
