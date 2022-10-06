using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double mayor = 0;
            string mas = "";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Introduzca su nombre:");
               string trabajador = Console.ReadLine();
                Console.WriteLine($"{trabajador} introduzca su sueldo base:");
                double sueldoBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduza su bonificación del 1% del sueldo base, por cada mes trabajado:");
                double bonificacion = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduza su asignación familiar del 5% del sueldo base, por cada hijo");
                double asignacion = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Su salario neto es de:");
                Console.WriteLine(SalarioNeto(sueldoBase, bonificacion, asignacion) + " Euros");
                double gana = SalarioNeto(sueldoBase, bonificacion, asignacion);
                if (gana > mayor)
                {
                    mayor = gana;
                    mas = trabajador;
                }
            };
            Console.WriteLine($"El trabajador que mas sueldo neto tiene es {mas} con {mayor}  Euros");
            Console.ReadLine();
        }
        static double SalarioNeto(double sueldoBase, double bonificacion, double asignacion)
        {
            double result = sueldoBase + bonificacion + asignacion;
            return result;
        }
    }
}
