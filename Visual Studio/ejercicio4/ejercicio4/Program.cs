namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            double radio, resultado;

            //Peticion de datos
            Console.Write("Dime el radio del círculo: ");
            radio = double.Parse(Console.ReadLine());
            //Formula y resultado
            resultado = Math.PI * Math.Pow(2, radio);
            Console.WriteLine("El área del círculo es igual a: " + resultado);
        }
    }
}
