using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameThreeTries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab numbri ära arvama;
            //kui kasutaja suutis numbri arvata, siis ta on mängu võitnud;
            //katseid on 3, kui ei ole suutnud ära arvata, siis mängu võidab arvuti;
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;


            while (i < 3)
            {
                Console.WriteLine("Kas oled valmis mängu alustama?");
                Console.WriteLine("Arva ära, mis number jääb vahemikku 1 kuni 10?");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Sa oled võitnud.");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number!");
                    Console.WriteLine($"Oled sisestanud {i} korda vale numbri. Jäänud on {3 - i} katset.");
                }
                Console.WriteLine("Nägemist!");
            }
        }
    }
}
