using System;
namespace Calculadora_delegados;
public class Operaciones
{
    public delegate double Operacion(double num1, double num2);
    public static double Sumar(double num1, double num2)
    {
        return num1 + num2;
    }
    public static double Restar(double num1, double num2)
    {
        return num1 - num2;
    }
    public static double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }
    public static double Dividir(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("\nERROR No se puede dividir entre cero.");
            return 0;
        }
        return num1 / num2;
    }
    public static double Potencia(double num1, double num2)
    {
        return Math.Pow(num1, num2);
    }
}