using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int blanco;
            int anulados;
            int n;
            int p;

            Console.WriteLine("a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("blanco: ");
            blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("anulados: ");
            anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("p: ");
            p = int.Parse(Console.ReadLine());

            int mayoresEdad = (n * p) / 100;
            int votantes = a + b + blanco + anulados;
            int abstencion = mayoresEdad - votantes;

            bool A = anulados < ((a + b) * 30) / 100;
            bool B = (a + b) > blanco;
            bool C = abstencion < votantes;

            Console.WriteLine("mayores de edad: " + mayoresEdad); Console.WriteLine("total votantes: " + votantes); Console.WriteLine("abstencion: " + abstencion);
            if (A && C || B && C)
            {
                Console.WriteLine("las votaciones fueron un exito");
                if (a > b)
                {
                    Console.WriteLine("gana a");
                }
                else if (a < b)
                {
                    Console.WriteLine("gana b");
                }
            }
            else Console.WriteLine("Se repiten");
        }
    }
}
