namespace Calcular_Cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double resultado;

            Console.WriteLine("Ejemplo 3");
            Console.Write("Escriba el número que quiere elevar al cubo: ");
            numero = double.Parse(Console.ReadLine());
            resultado = Math.Pow(numero, 3);
            Console.WriteLine("El resultado de " + numero + " elevado al cubo es igual a: " +  resultado);
        }
    }
}
