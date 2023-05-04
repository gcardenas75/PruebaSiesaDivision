// See https://aka.ms/new-console-template for more information

using PruebaTecnica.Operacion;

class Program
{
    static void Main(string[] args)
    {
       Division divisionNueva = new Division(); 
        Console.WriteLine("El resultado de la division es: ");
        Console.WriteLine(divisionNueva.division(10, 2));
    }
}