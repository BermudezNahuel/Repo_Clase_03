using Ejercicio_01;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta juan = new Cuenta("Juan", 123);
            Console.WriteLine(juan.titular);
            juan.ingresar(400);
            Console.WriteLine(juan);
            juan.retirar(1000);
            Console.WriteLine(juan.mostrar());
        }
    }
}