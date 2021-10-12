using System;

namespace Gissa_slumptal_1_till_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int random = slump.Next(1,101);

            int AntalGissningar = 0;

            Console.Write("Gissa det slumpade talet: ");
            
            while (true)
            {
            string str1 = Console.ReadLine();
            int Gissning = int.Parse(str1);
                
                AntalGissningar++;

                if (Gissning < random)
                    {
                        Console.Write("Gissningen är för låg. Försök igen: ");
                    } 
                else
                    if (Gissning > random)
                        {
                            Console.Write("Gissningen är för hög. Försök igen: ");
                        }
                    else
                        {
                            Console.WriteLine("Grattis! "+random+" är rätt tal, det tog "+AntalGissningar+" antal försök.");
                        }
                }
            }
        }
    }

