using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesAndHashmaps
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
            SherlockandAnagrams();
            //CountTriplets();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void HashTablesRansomNote()
        {
            //------------------------------------ PROBLEMA -------------------------------------
            //Me pasan 2 listas ,la primer lista es la revista de las que el secuestradaor
            //sacaria las palabras, y la segunda, la nota que quiere escribir el secuestrador.
            //Tengo que encontrar las palabras de la nota en la revista. El algoritmo debe
            //distinguir mayusculas y minusculas, y si una palabra esta 2 veces en la nota y una
            //en la revista, entonces no puedo (no se usa mas de una vez cada palabra)

            //Sample Input 0
            //6 4
            //give me one grand today night
            //give one grand today

            //Sample Output 0
            //Yes


            //Sample Input 1
            //6 5
            //two times three is not four
            //two times two is four
            
            //Sample Output 1
            //No

            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            //var magazine = new List<string> {"ive", "got",  "a", "lovely", "bunch", "of", "coconuts" };
            //var note = new List<string> { "ive", "got", "fd", "coconuts" };
            var magazine = new List<string> { "give", "me", "one", "grand", "today", "night"};
            var note = new List<string> { "give", "me", "one", "grand", "today"};

            //------------------------------ PREPARACION DEL INPUT ------------------------------

            //------------------------------------ SOLUCION -------------------------------------

            //SI BIEN PARECE QUE NO HACE FALTA USAR DIC, SI NO LO USAS ALGUNOS CASOS DE HACKERRANK
            //TE DAN FAIL POR TIEMPO DE EJECUCION
            var magdir = new Dictionary<string, int>();
            foreach (string magword in magazine)
            {
                if (magdir.ContainsKey(magword))
                    magdir[magword] = magdir[magword] + 1;
                else
                    magdir.Add(magword, 1);
            }
            foreach (string noteword in note)
            {
                if (magdir.ContainsKey(noteword))
                {
                    if (magdir[noteword] > 1)
                        magdir[noteword] = magdir[noteword] - 1;
                    else
                        magdir.Remove(noteword);
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }

            }

            Console.WriteLine("Yes");

            //------------------------------------ SOLUCION -------------------------------------
        }

        static void TwoStrings()
        {
            //------------------------------------ PROBLEMA -------------------------------------
            //Given two strings, determine if they share a common substring. A substring may be as small as one character.

            //Example

            //string s1 = "and";
            //string s2 = "art";
            //These share the common substring .

            //string s1 = "be";
            //string s2 = "cat";
            //These do not share a substring.

            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            string s1 = "ace";
            string s2 = "world";

            //------------------------------ PREPARACION DEL INPUT ------------------------------

            //------------------------------------ SOLUCION -------------------------------------

            var dic = new Dictionary<char, int>();
            string resp;

            for (int i = 0; i < s1.Length; i++)
            {
                if (!dic.ContainsKey(s1[i]))
                    dic.Add(s1[i], 1);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (dic.ContainsKey(s2[i]))
                {
                    Console.WriteLine("YES");
                    return;
                    //return "YES";
                }
            }

            //return "NO";
            Console.WriteLine("NO");

            //------------------------------------ SOLUCION -------------------------------------
        }

        static void SherlockandAnagrams()
        {
            //https://programs.programmingoneonone.com/2021/03/hackerrank-sherlock-and-anagrams-solution.html


            //------------------------------------ PROBLEMA -------------------------------------
            //Me pasan 2 listas ,la primer lista es la revista de las que el secuestradaor

            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            //var magazine = new List<string> {"ive", "got",  "a", "lovely", "bunch", "of", "coconuts" };
            //var note = new List<string> { "ive", "got", "fd", "coconuts" };
            string s = "mom";


            //------------------------------ PREPARACION DEL INPUT ------------------------------

            //------------------------------------ SOLUCION -------------------------------------


            var DicAllChars = new Dictionary<char, int>();
            for (int i = 0; i < 120; i++)
            {
                DicAllChars.Add((char)i, i);
                //Console.WriteLine((char)i);

            }

            var ListAllSubstrings = new List<string>();


            // First loop start point - SUBSTRING
            for (int i = 0; i < s.Length; i++)
            {
                string subStr="";

                // Second loop is generating sub-string
                for (int j = i; j < s.Length; j++)
                {
                    subStr += s[j];
                    ListAllSubstrings.Add(subStr);
                }

            }

            int total = 0;
            for (int i = 0; i < ListAllSubstrings.Count(); i++)
            {
                string Word1 = ListAllSubstrings.ElementAt(i);
                for (int j = i+1; j < ListAllSubstrings.Count(); j++)
                {
                    
                    string Word2 = ListAllSubstrings.ElementAt(j);
                    if (Word1 == Word2)
                        total++;
                    else
                    {
                        if (Word1.Length == Word2.Length)
                        {
                            if (Word2.Length > 1)
                            {
                                //ADD AL CHARS OF SECOND WORD TO DIC
                                long SumW1 = DicAllChars[Word1[0]];
                                long SumW2 = DicAllChars[Word2[0]];
                                for (int k = 1; k < Word1.Length; k++)
                                {
                                    SumW1 = SumW1 * DicAllChars[Word1[k]];
                                }
                                for (int k = 1; k < Word2.Length; k++)
                                {

                                    SumW2 = SumW2 * DicAllChars[Word2[k]];
                                }

                                if (SumW1 == SumW2)
                                    total++;
                            }

                        }

                        
                    }
                }

            }


            Console.WriteLine(total);
            //------------------------------------ SOLUCION -------------------------------------









    //        var ListAllSubstrings = new List<string>();


    //        // First loop start point - SUBSTRING
    //        for (int i = 0; i < s.Length; i++)
    //        {
    //            string subStr = "";
    //            var DicAllChars = new Dictionary<char, int>();

    //            // Second loop is generating sub-string
    //            for (int j = i; j < s.Length; j++)
    //            {
    //                subStr += s[j];
    //                ListAllSubstrings.Add(subStr);
    //            }

    //        }

    //        int total = 0;
    //        for (int i = 0; i < ListAllSubstrings.Count(); i++)
    //        {

    //            for (int j = i + 1; j < ListAllSubstrings.Count(); j++)
    //            {
    //                string Word2 = ListAllSubstrings.ElementAt(j);
    //                if (ListAllSubstrings.ElementAt(i) == Word2)
    //                    total++;
    //                else
    //                {
    //                    if (ListAllSubstrings.ElementAt(i).Length == Word2.Length)
    //                    {
    //                        if (Word2.Length > 1)
    //                        {
    //                            //ADD AL CHARS OF SECOND WORD TO DIC
    //                            var DicAllChars = new Dictionary<char, int>();
    //                            for (int k = 0; k < Word2.Length; k++)
    //                            {
    //                                if (!DicAllChars.ContainsKey(Word2[k]))
    //                                    DicAllChars.Add(Word2[k], 1);
    //                                else
    //                                    DicAllChars[Word2[k]] += 1;
    //                            }

    //                            //STARTING TO COMPARE ALL THE CHARS OF WORD1 VS WORD2
    //                            string Word1 = ListAllSubstrings.ElementAt(i);
    //                            int WordLen = Word1.Length;
    //                            bool control = true;
    //                            int l = 0;
    //                            do
    //                            {
    //                                if (!DicAllChars.ContainsKey(Word1[l]))
    //                                    control = false;
    //                                else
    //                                {
    //                                    if (DicAllChars[Word1[l]] == 1)
    //                                        DicAllChars.Remove(Word1[l]);
    //                                    else
    //                                        DicAllChars[Word1[l]]--;
    //                                }
    //                                l++;
    //                            } while ((l < WordLen) && (control == true));

    //                            if (control == true)
    //                                total++;
    //                        }

    //                    }


    //                }
    //            }

    //        }


    //        return total;














}


static void CountTriplets()
        {
            //------------------------------------ PROBLEMA -------------------------------------
            //Me pasan 2 listas ,la primer lista es la revista de las que el secuestradaor

            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            //var arr = new List<long> { 1, 5, 5, 25, 125 };
            var arr = new List<long> { 2, 2, 2, 2 };
            long r = 1;
            //2 2 2 2 

            //123 124 234 134
            //------------------------------ PREPARACION DEL INPUT ------------------------------

            //------------------------------------ SOLUCION -------------------------------------

            var count = 0L;
            var bWant = new Dictionary<long, long>();
            var cWant = new Dictionary<long, long>();

            foreach (var key in arr)
            {
                // Input values can repeat, therefore 0..n index 
                // triplets encode for 1 value triplet. 
                // 
                // Eg. Given [1 5 5 25 125], the values 
                // 1, 5, 25 (A, B, C) are present at 2 distinct 
                // indexes: (0, 1, 3) and (0, 2, 3).
                //
                // We can deduce the next triplet value given 
                // the ratio-relationship:
                //  A = n
                //  B = A * r
                //  C = B * r
                //
                // Therefore the approach is:
                //     
                //   1. if key is a C value
                //          * yes - increment count n times because 
                //             it was expected n times, where n is the 
                //             number of times we saw the B value 
                //             and expected this C value          
                //   2. if key is a B value
                //          * yes - signal we expect C an additional 
                //             n times, where n is the number of 
                //             times we saw the B value
                //          * no - assume A value, signal we expect
                //             B an additional 1 time

                if (cWant.ContainsKey(key))
                {
                    // key is a cValue
                    var c = key;

                    // Increase count 'n' times
                    count += cWant[c];
                }

                if (bWant.ContainsKey(key))
                {
                    // key is a 'b' value, therefore we expect a c value
                    var b = key;
                    var c = key * r;

                    if (cWant.ContainsKey(c))
                        cWant[c] += bWant[b];
                    else
                        cWant[c] = bWant[b];
                }

                // (ignore this extra block)
                {
                    // key is an 'a' value, therefore we expect a b value
                    var a = key;
                    var b = key * r;

                    if (bWant.ContainsKey(b))
                        bWant[b] += 1;
                    else
                        bWant[b] = 1;
                }
            }

            //return count;



            Console.WriteLine(count);


            //------------------------------------ SOLUCION -------------------------------------
        }


    }
}
