namespace numberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > 0 && number <= 100 )
                {
                    Console.WriteLine(number);
                    break;
                }     
                
            }
        }
    }
}