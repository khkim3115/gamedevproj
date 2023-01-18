using System;
using System.Threading;

//진행 방식
/*
 * 말 클래스 필요
 * 말 클래스는 달린 거리, 달리기, 이동하기 라는 함수를 가짐
 * 
 * 프로그램 시작시 말 다섯마리 만들고 각 말은 초당 10~20(정수형) 범위의 거리를 랜덤하게 전진
 * 각 말은 거리 200에 도달하면 도착해서 더이상 전진하지 않고
 * 매 초 각 말들이 아직 달리고 있다면 달린 거리를, 도착했다면 도착 상태를 콘솔창에 출력
 * 
 * 모든 말이 도착했다면 경주를 끝내고 등 수 순서대로 말들의 이름을 콘솔창에 출력
 * 
 */

namespace Example1_HorseRacing
{

    internal class Program
    {

        class Horse
        {
            public string Name;
            public bool IsFinished;
            public int TotalDistance;

            
            public void Run(int distance)
            {
                TotalDistance += distance;
            }
        }
        
        static Random random;
        static int minSpeed = 10;
        static int maxSpeed = 20;
        static int goalPos = 200;
        static int second = 0;

        static string[] place = new string[5];

        static void Main(string[] args)
        {
            bool gameFinished = false;
            //말 다섯마리 만들고
            //이름설정 (경주마1~5)

            Horse[] horses = new Horse[5];
            Horse[] horsesFinished = new Horse[5];

            int grade = 0;

            for(int i = 0; i < horses.Length; i++)
            {
                horses[i] = new Horse();
                horses[i].Name = "경주마" + (i + 1);
            }
/*
            horses[0].Name = "경주마1";
            horses[1].Name = "경주마2";
            horses[2].Name = "경주마3";
            horses[3].Name = "경주마4";
            horses[4].Name = "경주마5";*/

            while (gameFinished == false)
            {
                Console.WriteLine($"{second} 초 경과");
                second++;

                for (int i = 0; i < horses.Length; i++)
                {

                    if (horses[i].IsFinished)  //경주 끝난말
                    {
                        Console.WriteLine($"{horses[i].Name} 은 도착했다");
                    }

                    else //안끝난말
                    {
                        random = new Random();
                        int tmpSpeed = random.Next(minSpeed, maxSpeed + 1);

                        Console.WriteLine($"{horses[i].Name} : 현재거리 {horses[i].TotalDistance}");

                        horses[i].Run(tmpSpeed);
                        if(horses[i].TotalDistance >= goalPos)
                        {
                            horses[i].IsFinished = true;
                            horsesFinished[grade++] = horses[i];
                        }
                    }
                }

                if(grade >= horses.Length) //모든 말 도착
                {
                    Console.WriteLine();
                    Console.WriteLine("경주 종료");
                    Console.WriteLine();
                    break;
                }

                Console.WriteLine();

                Thread.Sleep(1000);  //1초에 한번씩 수행
            }

            for (int i = 0; i < horses.Length; i++)
            {
                Console.WriteLine($"{i + 1}등: {horsesFinished[i].Name}");
            }
        }
    }
}