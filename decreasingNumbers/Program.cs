namespace decreasingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}