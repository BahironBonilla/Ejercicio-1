using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3;
            float prom ;
            string click = "s";

            do
            {
                Console.Clear();

                Console.WriteLine("Escriba las notas: \n");
                Console.WriteLine("nota 1 = ");
                nota1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("nota 2 = ");
                nota2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("nota 3 = ");            
                nota3 = Int32.Parse(Console.ReadLine());

                prom = (nota1 + nota2 + nota3) / 3;

                if ( prom < 3)
                {
                    Console.WriteLine("el estudiante reprobo su promedio es "+ prom);
                }
                else
                {
                    Console.WriteLine("El estudiante aprobo su promedio es " + prom);
                }

                Console.WriteLine("\n\n\n\n ¿Desea continuar?[s|n]");
                click = Console.ReadLine();

            } while (click == "s" || click == "S");




        }
    }
}
