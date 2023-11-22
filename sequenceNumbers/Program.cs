namespace sequenceNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int maxNumber = int.Parse(Console.ReadLine());

            while (number <= maxNumber)
            {
                Console.WriteLine(number);
                number = number * 2 + 1;                
            }
        }
    }
}