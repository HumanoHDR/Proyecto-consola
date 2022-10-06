using System;
using System.Threading;

namespace Proyecto_consola
{
    public class Program
    {
        const double pi = 3.1415926535897932384626433832795;
        public 
            static void Main(string[] args)
        { 
            bool loops = false;
            while (!loops)
            {
               Calculadora();
            };
        }
        static public string Cientifica()
        {
            Console.WriteLine("Uso de πi (p)");
            Console.WriteLine("Elevar un numero al cuadrado (o)");
            Console.WriteLine("Elevar 2 en un determinado numero (e)");
            Console.WriteLine("Elevar un numero un determinado exponente (l)");
            Console.WriteLine("Uso de e (e)");
            Console.WriteLine("Hacer 1/x (x)");
            Console.WriteLine("Valor absoluto |x| (abs)");
            Console.WriteLine("Calcular la raiz cuadrada (raiz)");
            Console.Write("Que operacion desea realizar: ");
            string devolucion = Console.ReadLine();
            return (devolucion);
        }
        static string Comprobante(string operador)
        {
            int rep = 0;
            double numerico = double.MinValue;
            bool comprobante;
            do
            {
                //comprobante = true;
                comprobante = double.TryParse(operador, out numerico);
                if (!comprobante)
                {
                    rep++;
                    Console.Write($"Intento {rep}: Escriba un valor numerico porfavor: ");
                    operador = Console.ReadLine();
                };
            } while (!comprobante);
            return operador;
        }
        static string Llamada()
        {
            string operador1;
            Console.Write("Escriba un operador de la operacion: ");
            operador1 = Comprobante(Console.ReadLine());
            return operador1;
        }
        public static double Operacions(string opcion, string operador1, string operador2)
        {
            
            double d = 0;
            string resultado = "El resultado de la ";
            Console.WriteLine();
            switch (opcion)
            {
                case "s":
                    d = Suma(operador1, operador2);
                    Console.WriteLine($"{resultado} suma es {d}");
                    break;
                case "r":
                    d = Resta(operador1, operador2);
                    Console.WriteLine($"{resultado} resta es {d}");
                    break;
                case "m":
                    d = Multiplicacion(operador1, operador2);
                    Console.WriteLine($"{resultado} multiplicacion es {d}");
                    break;
                case "d":
                    d = Dividir(operador1, operador2);
                    Console.WriteLine($"{resultado} division es {d}");
                    break;
                case "p":
                    Pi();
                    break;
                case "o":
                    d = Elevar2();
                    Console.WriteLine($"El resultado de la operacion es {d}");
                    break;
                case "l":
                    ElevarX();
                    break;
                case "e":
                    Numeroe();
                    break;
                case "x":
                    Xpartido();
                    break;
                case "abs":
                    Absolut();
                    break;
                case "cose":
                    d = Cosen();
                    Console.WriteLine($"El resultado es {d}");
                    break;
                case "raiz":
                    d = Raiz();
                    Console.WriteLine($"El resultado es {d}");
                    break;
                default:
                    Console.WriteLine("La operacion que desea realizar no esta en esta calculadora");
                    break;
                
            };
            return d;
            //tranquilo señor poeta, pues chupamela esta                
        }
        static bool Final(bool bucle)
        {
            char positivo = 's', negativo = 'n';
            Console.Write($"Quiere usted continuar ? ({positivo}/{negativo}) ");
            string reinicio = Console.ReadLine();
            if (reinicio == "s")
            {
                Console.Clear();
            }
            else
            {
                bucle = true;
            };
            return bucle;
        }
        static string Simple()
        {
            Console.WriteLine("Para sumar (s)");
            Console.WriteLine("Para restar (r)");
            Console.WriteLine("Para multiplicar (m)");
            Console.WriteLine("Para dividir (d)");
            Console.Write("Que operacion desea realizar: ");
            string devolucion = Console.ReadLine();
            return (devolucion);

        }
        public static void Calculadora()
        {
            string operador1 = String.Empty, operador2 = String.Empty;
            
            string devolucion;
            Console.Write("Que calculadora desea usar (simple/cientifica)");
            devolucion = Console.ReadLine();
            if (devolucion == "simple")
            {
                devolucion = Simple();
                operador1 = Llamada();
                operador2 = Llamada();
                Operacions(devolucion, operador1, operador2);
            }
            else if (devolucion == "cientifica")
            {
                devolucion = Cientifica();
                Operacions(devolucion, operador1, operador2);
            }
            else Console.WriteLine("El tipo de calculadora no existe");
        }
        public static void ElevarX()
        {
            string ope1, ope;
            double d = 1;
            Console.WriteLine("Que numero quiere elevar");
            ope1 = Llamada();
            Console.WriteLine($"A que numero lo quiere elevar");
            ope = Llamada();
            for (int i = 0; i < Convert.ToDouble(ope); i++)
            {
                d = Convert.ToDouble(ope1) * d;
            }
            Console.WriteLine($"El resultado de la operacion es {d}");
        }
        public static double Suma(string operador1, string operador2)
        {
            double d = Convert.ToDouble(operador1) + Convert.ToDouble(operador2);
            return d;
        }
        static public void Numeroe()
        {
            string ope1, ope;
            Console.WriteLine("El numero e() es 2,718281");
            ope = Simple();
            ope1 = Llamada();
            Operacions(ope, ope1, "2,718281");
        }
        static public double Elevar2()
        {
            string ope1;
            double d;
            Console.WriteLine("Que numero quiere elevar al cuadrado");
            ope1 = Llamada();
            d = Convert.ToDouble(ope1) * Convert.ToDouble(ope1);
            return d;
        }
        static public void Pi()
        {
            string ope1, ope;
            Console.WriteLine("El numero pi() es 3,14159265");
            ope = Simple();
            ope1 = Llamada();
            Operacions(ope, ope1, "3,14159265");
        }
        static public double Resta(string operador1, string operador2)
        {
            double d = Convert.ToDouble(operador1) - Convert.ToDouble(operador2);
            return d;
        }
        static public double Multiplicacion(string operador1, string operador2)
        {
            return Convert.ToDouble(operador1) * Convert.ToDouble(operador2);
        }
        static public double Dividir(string operador1, string operador2)
        {
            return Convert.ToDouble(operador1) / Convert.ToDouble(operador2);
        }
        public static void Xpartido()
        {
            string ope1;
            ope1 = Llamada();
            Console.WriteLine("El resultado de la operacion es " + 1/Convert.ToDouble(ope1));
        }
        public static void Absolut()
        {
            string ope;
            double ope2;
            ope = Llamada();
            ope2 = Convert.ToDouble(ope);
            if (Convert.ToDouble(ope) < 0)
            {
                ope2 = ope2 - ope2 - ope2;
                
            }
            Console.WriteLine($"El valor absoluto de la operacion es {ope2}");

        }
        public static double Cosen()
        {
            double ope1 = Convert.ToDouble(Llamada());
            double sen = (ope1 * pi / 180);
            return sen;
        }
        public static double valorAbsoluto(double numero)
        {
            if (numero < 0)
            {
                return numero * -1;
            }
            return numero;
        }
        public static double Raiz()
        {
            double ope1 = Convert.ToDouble(Llamada());
            double margen = 0.000001;
            double estimacion = 1.0;
            while (valorAbsoluto((estimacion * estimacion) - ope1) >= margen)
            {
                double cociente = ope1 / estimacion;
                double promedio = (cociente + estimacion) / 2.0;
                estimacion = promedio;
            }
            return estimacion;
        }
    }
}
