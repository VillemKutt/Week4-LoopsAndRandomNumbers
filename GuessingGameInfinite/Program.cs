using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameInfinite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;


            while (loopActive)
            {
                Console.WriteLine("Kas oled valmis mängu alustama?");
                Console.WriteLine("Arva ära, milline number jääb vahemikku 1 kuni 10?");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Sa oled võitnud.");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number, proovi uuesti!");
                    Console.WriteLine($"Oled sisestanud {i} korda vale numbri.");
                }
                Console.WriteLine("Nägemist!");
            }
        }
    }
}
