using System;

namespace ACharCunter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname}{lastname}".ToLower();

            int counter = 0;
            for(int i = 0; i < fullname.Length; i++)
            {
                if(fullname[i] == 'a')
                {
                    counter++;
                }

            }
           
            if (counter == 1)
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' tähte");
            }




        }
    }
}
