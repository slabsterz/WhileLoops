namespace sumDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            int sum = 0;
            string numberString = number.ToString();
            int index = 0;

            while (true) 
            {
               
                int digit = int.Parse(numberString[index].ToString());
                sum += digit;
                index++;

                if (index == numberString.Length)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}