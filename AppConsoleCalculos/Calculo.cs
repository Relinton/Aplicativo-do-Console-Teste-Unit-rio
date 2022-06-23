using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsoleCalculos
{
    public class Calculo
    {
        public static double Somar(double num1, double num2)
        {
            return (num1 + num2);
        }
        public static double Subtrair(double numero1, double numero2)
        {
            return (numero1 - numero2);
        }
        public static double Multiplicar(double numero1, double numero2)
        {
            return (numero1 * numero2);
        }
        public static double Dividir(double numero1, double numero2)
        {
            return (numero1 / numero2);
        }
        public static bool IsNumeroPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
