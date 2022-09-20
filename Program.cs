using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loops = false;
            while (loops == false)
            {
                string c, a= "0", b = "0";
                double d;
                int i;
                bool test = false;
                bool test2 = false;
                /// uar do...while
                while (test == false)
                {
                    Console.Write("Primer operador de la funcion: ");
                    a = Console.ReadLine();
                    test = int.TryParse(a, out i);
                };
                while (test2 == false)
                { 
                    Console.Write("Segundo opredador de la funcion: ");
                    b = Console.ReadLine();
                    test2 = int.TryParse(b, out i);
                };
                Console.WriteLine("Para sumar (s)");
                Console.WriteLine("Para restar (r)");
                Console.WriteLine("Para multiplicar (m)");
                Console.WriteLine("Para dividir (d)");
                Console.Write("Que operacion desea realizar: ");
                c = Console.ReadLine();
                if (c == "s")
                {
                    
                    d = Convert.ToDouble(a) + Convert.ToDouble(b);
                    Console.WriteLine($"El resultado de la suma es {d}");

                }
                else if (c == "r")
                {
                    d = Convert.ToDouble(a) - Convert.ToDouble(b);
                    Console.WriteLine($"El resultado de la suma es {d}");
                }
                else if (c == "m")
                {
                    d = Convert.ToDouble(a) * Convert.ToDouble(b);
                    Console.WriteLine($"El resultado de la multiplicacion es {d}");
                }
                else if (c == "d")
                {
                    d = Convert.ToDouble(a) / Convert.ToDouble(b);
                    Console.WriteLine($"El resultado de la division es {d}");
                };
                Console.WriteLine("");
                Console.Write("Desea usted continuar ?(s/n)");
                string exit = Console.ReadLine();
                if (exit == "s")
                {
                    Console.Clear();
                }
                else if (exit == "n")
                {
                    loops = true;
                };
            };
        }
    }
}
