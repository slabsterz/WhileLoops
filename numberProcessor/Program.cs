namespace numberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string command = "";

            while (command != "End")
            {
                 command = Console.ReadLine();             

                switch (command)
                {
                    case "Inc": number++; break;
                    case "Dec": number--; break;
                     default: break;                        
                }              
                               
            }
            Console.WriteLine(number);
        }
    }
}