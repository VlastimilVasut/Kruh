using System;

namespace Kruh
{
    class Program
    {
        static void Main(string[] args)
        {

            double menu1 = 1;
            double menu2 = 2;
            double obsah;
            double obvod;
            double polomer = 0;
            double moznost;



            Console.CursorVisible = false;

            Console.WriteLine("Vypocet obvodu a obsahu kruhu");

            Console.ReadLine();
            Console.WriteLine(" Napite 1 pro vypocet obvodu a 2 pro vypocet obsahu:");
            double.TryParse(Console.ReadLine(), out moznost);
            Console.ReadLine();
            if (moznost == 1)
            {




                Console.WriteLine("Zadejte polomer:");
                    double.TryParse(Console.ReadLine(), out polomer);
                    Console.ReadLine();
                    obvod = 2 * 3.14 * polomer;
                    Console.WriteLine($"Obvod je {obvod}");
               
                

            }





            if (moznost == 2)
            {




                Console.WriteLine("Zadejte polomer:");
                double.TryParse(Console.ReadLine(), out polomer);
                    Console.ReadLine();
                    obsah = 3.14 * polomer * 2;
                    Console.WriteLine($"Obvod je {obsah}");
                


            }






        }

    }
}

