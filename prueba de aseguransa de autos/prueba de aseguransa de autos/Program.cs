using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_de_aseguransa_de_autos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int genero;
            // determinar la Edad del Humano 
            Console.WriteLine("ingresa tu fecha de nacimiento con el siguiente formato dd/MM/yy");
            string FNacimiento = Console.ReadLine();
            DateTime FnaciminetoDate = DateTime.Parse(FNacimiento);
            DateTime FActual = DateTime.Now;
            /*int edad = FActual.Year - FnaciminetoDate.Year;
            Console.WriteLine($"Usted tiene {edad} años");*/

            TimeSpan diferncia = FActual -FnaciminetoDate;
            double dias = diferncia.TotalDays;
            double edad = Math.Floor(dias/ 365);
            Console.WriteLine($"Usted tiene {edad} años");
            
            int edada= Convert.ToInt32(edad);

            //genero 
            Console.WriteLine("Proporciona el género del asegurado: Sieres Hombre coloca el numero 1, Sieres mujer coloca el numero 2");
             genero = int.Parse(Console.ReadLine());
            if (genero == 1)
            {
                Console.WriteLine("Eres Hombre");
            }
            else if (genero == 2)
            {
                Console.WriteLine("Eres Mujer");
            }
            
          
            int[,] Tanbla = new int[12,4]{
          /*1*/ { 0, 20, 2,5}, 
          /*2*/ { 21,30, 2,10 }, 
          /*3*/ { 31,40, 2,40}, 
          /*4*/ { 41,50, 2,50 },
          /*5*/ { 51,60, 2,65}, 
          /*6*/ { 61,100,2,85}, 
          /*7*/ { 0, 20, 1,5}, 
          /*8*/ { 21,30, 1,1},
          /*9*/ { 31,40, 1,40 }, 
         /*10*/ { 41,50, 1,55}, 
         /*11*/ { 51,60, 1,70 }, 
         /*12*/ { 61,100,1,90 },
            };
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                  // Console.WriteLine($"arreglo2D({i},{j}): {Tanbla[i, j]}");
               if((Tanbla[i,0] <= edada) && (Tanbla[i,1] >= edada) && (Tanbla[i,2] == genero)){
                        int Factor = Tanbla[i,3];
                        decimal FactorD = Convert.ToDecimal(Factor);
                        decimal FactorC = (FactorD/100);
                        Console.WriteLine(FactorC);
                        break;
                  }
           /* else 
                   {
                        //Console.WriteLine($"arreglo2D({i},{j}): {Tanbla[i, j]}");
                      Console.WriteLine("No jalo");
             
                        break;
                   }*/
              }
            }
            Console.ReadKey();
        }
    }
}
