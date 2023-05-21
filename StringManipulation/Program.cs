using System;
using System.Collections.Generic;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //HashTablesRansomNote();
            //TwoStrings();
            MakingAnagrams();
            //CountTriplets();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }


        static void MakingAnagrams()
        {

            //------------------------------------ PROBLEMA -------------------------------------


            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            string a = "fsqoiaidfaukvngpsugszsnseskicpejjvytviya";
            string b = "ksmfgsxamduovigbasjchnoskolfwjhgetnmnkmcphqmpwnrrwtymjtwxget";

            //------------------------------ PREPARACION DEL INPUT ------------------------------

            //------------------------------------ SOLUCION -------------------------------------

            var AChars = new Dictionary<char, int>();
            var BChars = new Dictionary<char, int>();
            for (int k = 0; k < a.Length; k++)
            {
                if (!AChars.ContainsKey(a[k]))
                    AChars.Add(a[k], 1);
                else
                    AChars[a[k]] += 1;
            }

            for (int k = 0; k < b.Length; k++)
            {
                if (!BChars.ContainsKey(b[k]))
                    BChars.Add(b[k], 1);
                else
                    BChars[b[k]] += 1;
            }

            int total = 0;

            for (int k = 0; k < a.Length; k++)
            {
                if (BChars.ContainsKey(a[k]))
                    total = total + Math.Abs(BChars[a[k]] - AChars[a[k]]);
                else
                    total++;
            }
            for (int k = 0; k < b.Length; k++)
            {
                if (!AChars.ContainsKey(b[k]))
                    total++;
            }

            //foreach (KeyValuePair<char, int> entry in AChars)
            //{
            //    if (BChars.ContainsKey(entry.Key))
            //        total = total + Math.Abs(BChars[entry.Key] - entry.Value);
            //    else
            //        total++;
            //}
            //foreach (KeyValuePair<char, int> entry in BChars)
            //{
            //    if (!AChars.ContainsKey(entry.Key))
            //        total++;
            //}

            Console.WriteLine(total);


            //------------------------------------ SOLUCION -------------------------------------

        }

    }

}
