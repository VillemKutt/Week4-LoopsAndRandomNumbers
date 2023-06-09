﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //programm küsib kasutajal sisestada PIN koodi;
                //programm võrdleb sisestatud PIN koodi arvuga 1234;
                //kui sisestatud PIN kood on 1234, siis konsool kuvab "Tere tulemast!";
                //kui sisestatud PIN kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
                //kasutajal on 3 katset.

                int i = 0; //i - iteration

                while (i < 3) //While-loop >> i = 1; 1 < 3 --> true; 2 < 3 --> true; 3 < 3 --> false
                {
                    Console.WriteLine("Sisesta PIN:");
                    int userPIN = Convert.ToInt32(Console.ReadLine());

                    if (userPIN == 1234)
                    {
                        Console.WriteLine("Tere tulemast!");
                        break; // võib ka i = 3
                    }
                    else
                    {
                        //i = i + 1 == i++
                        i++;
                        Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                    }


                }
                Console.WriteLine("Kena päeva!");
            }
        }
    }
}
