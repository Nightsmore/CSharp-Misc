using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BogoSort
{
    class _BogoSort
    {
        static void Main(string[] args)
        {

            //int[] arr     = new int[]     { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };   //Pre sorted array
            //Random short array
            //int[] arr     = new int[]     { 5, 7, 8, 4, 3, 2, 9, 1, 10 };      //Random medium array
            //float[] arr   = new float[]   { 5.2f, 5.1f, 8.0f, 14.1f };         //Float array
            int[] arr = new int[] { 5, 3, 8, 14 };

            /*
            foreach (int i in arr)
                Console.Write("{0},", i);
            */
            

            
            BogoSort(arr);


            /*  
            Console.WriteLine("\nBefore: ");
            Console.WriteLine("\nBefore: ");
            foreach (int i in arr)
                Console.Write("{0},", i);

            Console.WriteLine("\n");
            
            */


        }

        public static void BogoSort<T>(T[] obj)
        {
            
            Random r = new Random();
            T[] li = obj;
            //T[][] stored = new T[][] { } ;
            
            //stored.
            
            while (!checkSorted<T>(obj))
            {
                //stored.AddRange(li);

                for (int i = 0; i < obj.Length; i++)
                {
                    int value = r.Next(i, li.Length);
                    var valHolder = li[i];
                    li[i] = li[value];
                    li[value] = valHolder;
                }


                foreach (T i in obj)
                {
                    Console.Write("{0},", i);
                }
                //Check if entry is unique.
                //checkUnique<T>(obj, stored.ToArray());
            }
            //Console.WriteLine("Sorted.");
        }

        static bool checkSorted<T>(T[] obj)
        {
            bool sorted = true;

          
            for(int i = 0; i < obj.Length -1; i++)
            {
               
                T t1 = obj[i];
                T t2 = obj[(i + 1)];


               
                if (Comparer<T>.Default.Compare(t1, t2) <= 0)
                {
                    //do nothing
                }
                else
                {
                    sorted = false;
                }

                
            }
            Console.WriteLine("  Sorted: {0}", sorted);
            return sorted;
        }

        static bool checkUnique<T>(T[] obj_0, T[][]obj_1)
        {
            bool match = false;
            for(int i = 0; i < obj_1.Length; i++)
            {
                if (obj_0.Equals(obj_1[i]))
                {
                    Console.WriteLine("Match.");
                    match = true;
                }

            }
            return match;
        }
    }

}

