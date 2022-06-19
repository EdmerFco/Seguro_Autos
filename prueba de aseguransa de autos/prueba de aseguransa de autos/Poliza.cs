using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_de_aseguransa_de_autos
{
    public class Poliza
    {
        public static void Calcular()
        {

            DateTime FechaInicio;
            decimal Periodo;
            decimal SumaAsegurada;
            decimal Cantidad;
            DateTime FechaNcimiento;
            int Genero;

            Console.WriteLine("Coloca tu Fecha de inicio de seguro");
            FechaInicio = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(FechaInicio.ToString());
            Console.WriteLine("El tipo de periodo por el que se desea la póliza (años, meses, días),");
            Periodo = int.Parse(Console.ReadLine());
            Console.WriteLine(Periodo.ToString());
            Console.WriteLine(" La cantidad de periodos que se desean que tenga duración la póliza");
            Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(Cantidad);
            Console.WriteLine(" Suma Asegurada");
            SumaAsegurada = int.Parse(Console.ReadLine());
            Console.WriteLine(SumaAsegurada);

            Console.WriteLine("Fecha de Nacimiento");
            FechaNcimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(FechaNcimiento);
            Console.WriteLine("Género del asegurado si eres hombre coloca el numero 1 siu eres mujer colca el numero 2");
            Genero = int.Parse(Console.ReadLine());

        }
    }
}
