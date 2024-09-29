using System;
/*Alfred Oching Osewe Okoth
 NET24*/

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

            
            bool ConversionSucces = int.TryParse(Number, out int Result);//Using tryParse to read user input

            if (ConversionSucces)
            {
                for (int i = 0; i < Result; i++)//Creating two for-loops for rows and columns
                {
                    for (int j = 0; j < Result; j++)
                    {
                        if ((i + j) % 2 == 0) //Printing black and white squares based on if even or not
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
