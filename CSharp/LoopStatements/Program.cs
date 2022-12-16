using System;

namespace LoopStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while문
            int count = 0;
            while (true) //무한루프
            {
                count++;
                Console.WriteLine(count);
                if (count == 10) break;
            }

            Console.WriteLine();

           /* for (; ;)
            {

            }*/ //무한루프

            for(int i = 0; i < 10; i++)
            { 
                Console.WriteLine(i+1);
            }

            int[][] arr_arr_int = new int[3][];
            arr_arr_int[0] = new int[2];
            arr_arr_int[1] = new int[3];
            arr_arr_int[2] = new int[4];
            
            for(int i = 0; i < arr_arr_int.Length; i++)
            {
                for(int j = 0; j < arr_arr_int[i].Length; j++)
                {
                    arr_arr_int[i][j] = 1;
                }
            }



        }
    }
}
