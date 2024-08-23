namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int numero1, numero2, numero3, numMayor;

            //Peticion de datos
            Console.WriteLine("Bienvenido al programa para determinar el mayor de 3 numeros");
            Console.Write("Escriba el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Escriba el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("Escriba el tercer numero: ");
            numero3 = int.Parse(Console.ReadLine());
            //Determinar que numero es mayor
            numMayor = numero1;
            if (numero2 > numMayor)
            {
                numMayor = numero2;
            }
            if (numero3 > numMayor)
            {
                numMayor = numero3;
            }
            Console.WriteLine("El numero mayor es: " + numMayor);
        }
    }
}
