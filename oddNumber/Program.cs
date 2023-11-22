namespace oddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }
    }
}