namespace Assignment5._2._3
{
    internal class Program
    {
        static void PrintNumbers(int nextNumber)
        {
            if (nextNumber == 0)
            {
                return;
            }
            Console.Write($"{nextNumber} ");
            nextNumber -= 1;
            PrintNumbers(nextNumber);
        }
        static void Main(string[] args)
        {
            Console.Write("How many Number to print: ");
        input:
            if (!int.TryParse(Console.ReadLine(), out int numberToPrint))
            {
                Console.WriteLine("Please enter a valid integer.");
                goto input;
            }
            PrintNumbers(numberToPrint);
        }
    }
}
