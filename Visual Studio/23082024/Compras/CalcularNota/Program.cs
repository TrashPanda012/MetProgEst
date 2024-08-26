using CalcularNota.clases;
using System.Security.Principal;

namespace CalcularNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 2");
            Nota nota = new Nota();
            double primeraClase;
            double segundaClase;
            double terceraClase;
            double promedio;

            Console.Write("Escriba la primera nota: ");
            primeraClase = double.Parse(Console.ReadLine());
            Console.Write("Escriba la segunda nota: ");
            segundaClase = double.Parse(Console.ReadLine());
            Console.Write("Escriba la tercera nota: ");
            terceraClase = double.Parse(Console.ReadLine());

            nota.primeraNota = primeraClase;
            nota.segundaNota = segundaClase;
            nota.terceraNota = terceraClase;

            promedio = nota.calcularPromedio() / 3;

            Console.WriteLine($"El promedio entre las tres notas brindadas es igual a: {promedio}");
        }
    }
}
