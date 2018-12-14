using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess = 0;
            string welcome = "Ghiceste un numar intre 1 si 100";
            int num = rand.Next(1, 100);
            Console.WriteLine(welcome);


            int i = 0;

            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num)
                    {
                        Console.WriteLine("Prea mare");
                    }
                    else
                    {
                        Console.WriteLine("Prea mic");
                    }
                }

                catch
                {
                    Console.WriteLine("Trebuie sa alegi un numar");
                    i--;
                }


                i++;
            }
            Console.WriteLine("Felicitari, ti-au trebuit" + i + " incercari");
            Console.ReadLine();
        }
    }
}