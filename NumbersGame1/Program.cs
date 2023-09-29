using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int chans;
            string choice;

            do
            {
                // Be användaren att välja en svårighetsnivå
                Console.WriteLine("Tryck på 1 för lätt, tryck på 2 för medium, tryck på 3 för hårt");
                int val = Convert.ToInt32(Console.ReadLine());


                switch (val)
                {
                    case 1:

                        // Generera ett slumptal mellan 1 och 10 för användaren att gissa
                        int number = random.Next(1, 10);
                        Console.WriteLine("Gissa nummer mellan 1 - 10");

                        //Antal försök
                        chans = 6;
                        Console.WriteLine("Du har 6 försök");


                        // Anrop CheckGues-metoden för att hantera gissningslogoiken
                        CheckGuess(chans, number);
                        break;


                    case 2:
                        // Generera ett slumptal mellan 1 och 25 för användaren att gissa
                        int number2 = random.Next(1, 25);
                        Console.WriteLine("Gissa nummer mellan 1 - 25");
                        chans = 5;
                        Console.WriteLine("Du har 5 försök");



                        CheckGuess(chans, number2);
                        break;


                    case 3:
                        // Generera ett slumptal mellan 1 och 50 för användaren att gissa

                        int number3 = random.Next(1, 50);
                        Console.WriteLine("Gissa nummer mellan  1 - 50");
                        chans = 3;
                        Console.WriteLine("Du har 3 försök");


                        CheckGuess(chans, number3);
                        break;



                    default:
                        Console.WriteLine("fel val. Välja 1, 2, or 3");
                        break;
                }

                

                Console.WriteLine("****************************************************\n\n");
                Console.WriteLine("\n Vill du försöka igen? Tryck Y eller y if YES\n");
                choice = Console.ReadLine();


            } while (choice.ToLower() == "y");


        }

        public static void CheckGuess(int chans1,int number)
        {
            
            //Kollar om chansen är större än 0
            while (chans1 > 0)
            {
                //Lagras nummret som användaren gissar
                int num = Convert.ToInt32(Console.ReadLine());

                //Nummret som systemet pruduserar är lika med nummret som användaren ger
                if (number == num)
                {
                    //Om användaren gissar rätt det här meddelandet visas
                    Console.WriteLine("Wohoo! Du klarade det!");

                    break;
                }
                //Nummret som systemet pruduserar är större än nummret som användaren ger
                else if (number > num)
                {

                    Console.WriteLine("Tyvärr, du gissade för lågt!");

                }
                //Nummret som systemet pruduserar är mindre än nummret som användaren ger
                else if (number < num)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");


                }
                //Antal försök minskas varge gång användaren gissar fel
                chans1--;

                //Om användaren kan inte gissa rätt spelet är slut
                if (chans1 == 0)
                {
                    Console.WriteLine($"Tyvärr, du lyckades inte gissa rätt. Rätt svar var {number}");

                }

            }
        }


    }
}
