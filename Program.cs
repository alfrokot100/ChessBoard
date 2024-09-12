using System;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en siffra är du snäll!");
            
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            String Number = Console.ReadLine();

            bool ConversionSucces = int.TryParse(Number, out int Result);
            if (ConversionSucces)
            {
                for (int i = 0; i < Result; i++)
                {
                    for (int j = 0; j < Result; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            Console.Write("◼︎");
                        }
                        else
                        {
                            Console.Write("◻︎");
                        }
                    }
                    Console.WriteLine();
                }
            }          
            else { Console.WriteLine("Felaktig input! Måste vara en siffra");                         
            }
        }
    }
}
