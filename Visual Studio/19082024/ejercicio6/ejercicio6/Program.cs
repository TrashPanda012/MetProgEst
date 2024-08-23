namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int numero;
            //Peticion de datos
            Console.WriteLine("Bienvenido al programa de verificacion de pares e impares!");
            Console.Write("Dime el numero a verificar si es par o impar: ");
            numero = int.Parse(Console.ReadLine());
            //Verificacion
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero " + numero + " es par!");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " es impar!");
            }
        }
    }
}
