namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables;
            string nombre;
            //Leer el nombre y saludar
            Console.WriteLine("Bienvenido!");
            Console.Write("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", mucho gusto!");
        }
    }
}
