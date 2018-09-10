using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265Chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays in C#
            //int[] c;
            //c = new int[12];
            //int[] c = new int[12];
            int[] c = { 24, 68, 101, 33, 55 };

            /*Default for each value, autolooping for loop
            foreach (var item in collection)
            {

            }*/


            int[,] twoarrays = new int[3, 3];

            int[,,] threedarray = new int[10, 10, 10];

            int[][] jaggedarray = new int[4][];

            jaggedarray[0] = new int[5];
            jaggedarray[1] = new int[51];
            jaggedarray[2] = new int[54];
            jaggedarray[3] = new int[23];
            jaggedarray[32] = new int[54];

            int[] responses = { 1, 2, 4, 4, 5, 5, 5, 23 };
            int[] frequency = new int[6];
            
            for(int answer=0;answer <responses.Length; answer++)
            {
                try
                {

                ++frequency[responses[answer]];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int rating = 1; rating < frequency.Length; rating++)
            {
                Console.WriteLine($"{rating} : {frequency[rating]}");
            }
            foreach (int item in c)
            {
                Console.WriteLine(item);
            }

        }
    }
}
