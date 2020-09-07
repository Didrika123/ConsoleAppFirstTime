using System;

namespace ConsoleAppFirstTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "";
            while (input.ToLower() != "exit")
            {
                Console.Write("\nWhat is your number? ");
                input = Console.ReadLine();
                int num;
                if (int.TryParse(input, out num))
                {
                    //num = Convert.ToInt32(input);
                    Console.WriteLine(num > 5 ? "Greater than 5." 
                                              : num == 5 ? "Equals to 5" 
                                                         : "Lesser then 5.");

                } else if(input != "exit"){
                    Console.WriteLine($"Error: Unable to convert \"{input}\" to int32.");
                }

            }
        }
    }
}
