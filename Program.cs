using System;

namespace CalculadoraVespertino
{
    enum Operaciones
    {
        SUMA, RESTA, MULTIPLICACION, DIVISION
    }

    class Program
    {
        static void PedirFactores(Operaciones op)
        {
            Console.WriteLine("Ingrese el primer factor: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo factor: ");
            double b = double.Parse(Console.ReadLine());

            double resultado = 0;
            switch (op) {
                case Operaciones.SUMA:
                    resultado = Aritmetica.Suma(a, b);
                    break;
                case Operaciones.RESTA:
                    resultado = Aritmetica.Resta(a, b);
                    break;
                case Operaciones.MULTIPLICACION:
                    resultado = Aritmetica.Multiplicar(a, b);
                    break;
                case Operaciones.DIVISION:
                    resultado = Aritmetica.Division(a, b);
                    break;
            }

            Console.WriteLine("El resultado es: "+resultado);
        }

        static void ImprimirMenu()
        {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("0. Salir");
        }

        static int ValidarInput()
        {
            try
            {
                string input = Console.ReadLine();
                return int.Parse(input);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                return -1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora! ingrese su opcion:");
            bool estado = true;
            while (estado)
            {
                ImprimirMenu();
                int opcion = ValidarInput();

                double a = 0, b = 0;
                switch (opcion)
                {
                    case 1:
                        PedirFactores(Operaciones.SUMA);
                        break;
                    case 2:
                        PedirFactores(Operaciones.RESTA);
                        break;
                    case 3:
                        PedirFactores(Operaciones.MULTIPLICACION);
                        break;
                    case 4:
                        PedirFactores(Operaciones.DIVISION);
                        break;
                    case 0:
                        estado = false;
                        break;
                    default:
                        break;
                }

            }
        }
        
    }
}
