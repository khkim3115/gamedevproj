using System;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();

            human1.height = 200.0f;
            human2.height = 150.0f;

            human1.writeHeight();
            human2.writeHeight();
        }

        class Human
        {
            public int age;
            public float height;
            public char sex;

            public void writeHeight()
            {
                Console.WriteLine(height);
            }
        }

    }
}
