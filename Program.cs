using System;
namespace myApp
{
    class Program

{
    private static void Main(string[] args)
    {
        var calculator = new Total();
        calculator.Calcular();
    
Console.WriteLine($"Area total:  {calculator.TotalAreas}" +
            $"\n Perimetro Total: {calculator.TotalPerimetros}");

            Console.ReadKey();
    }
}
}
