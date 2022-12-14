using System;

namespace ClassObjectInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.SayHeight();
            human.SayAge();
        }
    }

    class Human
    {
        private int age = 26;
        private float height = 180;
        private double weight = 70;
        private bool isResting = true;


        public void SayAge()
        {
            Console.WriteLine(age);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
    }
}

//Class: 객체타입
//Object: 객체: class타입으로 메모리공간을 확보한것
//Instance: 객체(데이터가 할당된 경우)
