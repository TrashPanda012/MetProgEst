namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion variables
            double salario, nuevoSalario;
            string cargo, nombre;
            //Peticion de datos
            Console.WriteLine("Bienvenido al sistema de cálculo de nuevo salario!");
            Console.Write("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ahora escriba su cargo: ");
            cargo = Console.ReadLine();
            Console.Write("Escriba su salario actual: ");
            salario = double.Parse(Console.ReadLine());
            //Calculo de nuevo salario
            nuevoSalario = salario * 1.10;
            //Impresion de datos de usuario
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su cargo es: " + cargo);
            Console.WriteLine("Su nuevo salario es: " + nuevoSalario);
        }
    }
}
