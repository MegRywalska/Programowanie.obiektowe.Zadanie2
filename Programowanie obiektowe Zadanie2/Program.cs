using System;

namespace Programowanie_obiektowe_Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Protokat protokat1 = new Protokat(5.0, 10.0);

            Console.WriteLine("Protokat 1:");
            Console.WriteLine($"Bok A: {protokat1.BokA}");
            Console.WriteLine($"Bok B: {protokat1.BokB}");
            
            protokat1.BokA = 7.5;
            protokat1.BokB = 15.0;

            Console.WriteLine("\nZmiana wartości boków dla Protokat 1:");
            Console.WriteLine($"Bok A: {protokat1.BokA}");
            Console.WriteLine($"Bok B: {protokat1.BokB}");
            
            Protokat protokat2 = Protokat.ArkuszPapieru("A4");

            Console.WriteLine("\nProtokat 2 (Arkusz A4):");
            Console.WriteLine($"Bok A: {protokat2.BokA}");
            Console.WriteLine($"Bok B: {protokat2.BokB}");

           try
            {
                Protokat protokat3 = Protokat.ArkuszPapieru("D4");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nBłąd: {ex.Message}");
            }


        }
    }
}
