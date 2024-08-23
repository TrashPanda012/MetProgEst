namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int numero1, numero2, resultado;
            
            //Suma
            Console.WriteLine("Bienvenido al programa de suma de dos numeros entero");
            Console.Write("Dime el primer numero entero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ahora dime el segundo numero entero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Excelente!");
            resultado = numero1 + numero2;
            Console.WriteLine("La suma de " + numero1 + " y " + numero2 + ", es igual a: " + resultado);
        }
    }
}
