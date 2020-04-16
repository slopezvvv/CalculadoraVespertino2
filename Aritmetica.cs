using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraVespertino
{
    abstract class Aritmetica
    {
        public static double Suma(double a, double b)
        {
            return a + b;
        }

        public static double Resta(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Division(double dividendo, double divisor)
        {
            if (dividendo == 0) return 0;
            if(divisor == 0)
            {
                Console.WriteLine("No se puede realizar la division por cero");
                return 0;
            }
            if (dividendo == 0 && divisor == 0)
            {
                Console.WriteLine("Resultado indefinido");
                return 0;
            }
            return dividendo / divisor;
        }

    }
}
