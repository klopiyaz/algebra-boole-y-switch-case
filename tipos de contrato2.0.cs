using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de datos
            Console.WriteLine("ingrese tipo de contrato: ");
            int contrato = int.Parse(Console.ReadLine()); // 1 = Independiente | 2 = Dependiente
            Console.WriteLine("ingrese su salario");
            int salario = int.Parse(Console.ReadLine());
            // Entradas adicionales...

            int ssmlv = salario / 877800;
            Console.WriteLine("ssmlv: " + ssmlv);
            int base_ = (salario * 40) / 100;

            if (base_ < 877800)
            {
                base_ = 877800;
            }

            double pension;
            double eps;
            double salarioreal;
            double arl;
            double salarioanual;

            if (contrato == 1)
            { // Independiente
                pension = (base_ * 16) / 100;
                eps = (base_ * 12.5) / 100;
                Console.WriteLine("nivel de riesgo: ");
                int nivelriesgo = int.Parse(Console.ReadLine());
                switch (nivelriesgo)
                {
                    case 1:
                        arl = (base_ * 0.522) / 100;
                        break;
                    case 2:
                        arl = (base_ * 1.044) / 100;
                        break;

                    case 3:
                        arl = (base_ * 2.436) / 100;
                        break;
                    case 4:
                        arl = (base_ * 4.350) / 100;
                        break;
                    default:
                        arl = (base_ * 6.960) / 100;
                        break;
                }
                salarioreal = salario - eps - pension - arl;
                Console.WriteLine("salario real " + salarioreal);
                salarioanual = salarioreal * 12;
                Console.WriteLine("salario anual " + salarioanual);
            }
            else
            { // Dependiente
                pension = (base_ * 4) / 100;
                eps = (base_ * 4) / 100;

                salarioreal = salario - eps - pension;
                Console.WriteLine("salario real" + salarioreal);
                salarioanual = salarioreal * 12 + salario;
                Console.WriteLine("salario anual " + salarioanual);
            }
        }
    }
}
