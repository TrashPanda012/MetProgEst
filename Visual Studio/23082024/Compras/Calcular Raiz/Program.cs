namespace Calcular_Raiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double resultado;

            Console.WriteLine("Ejemplo 4");
            Console.Write("Escriba el número del que quiere calcular la raiz cuadrada: ");
            numero = double.Parse(Console.ReadLine());
            resultado = Math.Sqrt(numero);
            Console.WriteLine("El resultado de la raiz cuadrada de " + numero + " es igual a: " + resultado);
        }
    }
}
