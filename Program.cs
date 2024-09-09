namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en siffra är du snäll!");
            String Number = Console.ReadLine();
            int Result;

            bool ConversionSucces = int.TryParse(Number, out Result);
            if (ConversionSucces) { Console.WriteLine(Result); }
            else { Console.WriteLine("Felaktig input! Måste vara en siffra");
                Console.WriteLine("Test");
            }
        }
    }
}
