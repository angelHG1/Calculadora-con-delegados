using static Calculadora_delegados.Operaciones;

namespace Calculadora_delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int opcion;
          
            Console.Write("Ingrese el primer número:");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Operacion op = null;
        Menu:
            Console.WriteLine("Ingrese la operación a realizar");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.Write("---> ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    op = Operaciones.Sumar;
                    break;
                case 2:
                    op = Operaciones.Restar;
                    break;
                case 3:
                    op = Operaciones.Multiplicar;
                    break;
                case 4:
                    op = Operaciones.Dividir;
                    break;
                case 5:
                    op = Operaciones.Potencia;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    Console.Clear();
                    goto Menu;
            }
            double resultado = op(num1, num2);
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}

