using System;
namespace Uppgift_4._9
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int antalX = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp");
            int antalO = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O-mönster per rad?");
            int antalOmönster = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int rader = int.Parse(Console.ReadLine());
            for (int i = 0; i < rader; i++)
            {
                for (int j = 0; j < antalOmönster; j++)
                {
                    for (int k = 0; k < antalX; k++)
                    {
                        Console.Write("X");
                    }
                    Console.Write("-"";
                    for (int l = 0; l < antalO; l++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                }
                Console.WriteLine();
            }
       
                    
                
                
            
        }
            
    }
}
