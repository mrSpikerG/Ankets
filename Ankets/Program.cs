using System;
using System.IO;

namespace Ankets
{

    class Program
    {
        static void Main(string[] args)
        {

            bool debug = true;
            Anketa[] mas = new Anketa[10];

            mas[0] = new Anketa("name1", new DateTime(2002, 2, 3));
            mas[1] = new Anketa("name2", new DateTime(2003, 5, 4));
            mas[2] = new Anketa("name3", new DateTime(2004, 6, 7));
            mas[3] = new Anketa("name4", new DateTime(2005, 9, 8));
            mas[4] = new Anketa("name5", new DateTime(2006, 10, 11));
            mas[5] = new Anketa("name6", new DateTime(2007, 11, 12));
            mas[6] = new Anketa("name7", new DateTime(2008, 10, 9));
            mas[7] = new Anketa("name8", new DateTime(2009, 7, 8));
            mas[8] = new Anketa("name9", new DateTime(2010, 6, 5));
            mas[9] = new Anketa("name10", new DateTime(2011, 3, 4));


            int min = 0, max = 0;
            //min = mas[0].Birthday.Subtract(DateTime.Now);
            for (int i = 0; i < 10; i++)
            {
                if (mas[i].Birthday.Subtract(DateTime.Now) > mas[min].Birthday.Subtract(DateTime.Now))
                {
                    min = i;
                }

                if (mas[i].Birthday.Subtract(DateTime.Now) < mas[min].Birthday.Subtract(DateTime.Now))
                {
                    max = i;
                }
            }
            if (debug)
            {
                Console.WriteLine(String.Format("Min: {0}; Max: {1}", min, max));
            }


            //Помойму это костыль напишите пожалуйста если это можно сделать одной функцией или упростить 
            if (File.Exists("AllPeoples.txt"))
            {
                File.WriteAllText("AllPeoples.txt", "");
            }
            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText("AllPeoples.txt", String.Format("{0} \n", mas[i].ToString()));
                if (debug)
                {
                    Console.WriteLine(String.Format("{0} added to File", mas[i].Name));
                }
            }

            File.WriteAllText("Min&Max.txt", String.Format("{0} \n{1}",mas[min],mas[max]));
            if (debug)
            {
                Console.WriteLine("Min & max added to File");
            }
            //Console.WriteLine(mas[min]);
            //Console.WriteLine(mas[max]);


        }
    }
}
