using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //program kuvab mitu h ja o tähte l tähte on lauses


            string world = $"Hello world".ToLower();
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 0; i < world.Length; i++)
            {
                if (world[i] == 'h')
                {
                    counter++;
                }
                if (world[i] == 'o')
                {
                    counter1++;
                }
                if (world[i] == 'l')
                {
                    counter2++;
                }
            }

            Console.WriteLine($"Selles fraasis on {counter} h tähte, {counter1} o tähte, {counter2} l tähte");






















            
                 

            
                

           

            
            
                




            
        }   
    }
}
