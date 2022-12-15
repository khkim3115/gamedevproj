using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 14.0f;
            float b = 2.0f;
            float c = 0.0f;

            c = a + b;
            Console.WriteLine(c);

            c = b - a;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);

            c=a % b;
            Console.WriteLine(c);

            //증감연산자

            //증가
            c++;

            //감소
            c--;




        }
    }
}
