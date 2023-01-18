using System;

namespace EnumAndSwitchCase
{
    internal class Program
    {
        //enum 열거형 (사용자 정의 자료형)
        //32 bit 정수형, 특정 요소에 값이 할당되어 있지 않으면 바로 이전 요소의 값에 + 1 한다
        //첫 요소는 값이 할당되어 있지 않으면 0 이다.
        
        enum State
        {
            Idle = 0,
            Walk = 1,
            Run,  
            Jump,
            Attack
        }

        static State s_state;
        
        static void Main(string[] args)
        {

            /*
                0 idle
                1 walk
                2 run
                3 jump
                4 attack
             */

            while (true)
            {
                s_state = (State)Int32.Parse(Console.ReadLine());
                //s_state = (State)Enum.Parse(typeof(State), Console.ReadLine());   //둘이 같음

                switch (s_state)
                {
                    case State.Idle:
                        Console.WriteLine("idle");
                        break;
                    case State.Walk:
                        Console.WriteLine("walk");
                        break;
                    case State.Run:
                        Console.WriteLine("run");
                        break;
                    case State.Jump:
                        Console.WriteLine("jump");
                        break;
                    case State.Attack:
                        Console.WriteLine("attack");
                        break;
                    default:
                        Console.WriteLine("잘못된 명령");
                        break;
                }
            }

            int state;
            while (true)
            {
                state = Int32.Parse(Console.ReadLine());
                switch (state)
                {
                    case 0:
                        Console.WriteLine("idle");
                        break;
                    case 1:
                        Console.WriteLine("walk");
                        break;
                    case 2:
                        Console.WriteLine("run");
                        break;
                    case 3:
                        Console.WriteLine("jump");
                        break;
                    case 4:
                        Console.WriteLine("attack");
                        break;
                    default:
                        Console.WriteLine("잘못된 명령");
                        break;
                }


            }





            string fruit;

            while (true)
            { 
                fruit = Console.ReadLine();
                switch (fruit)
                {
                    case "사과":
                        Console.WriteLine("이거 사관데여");
                        break;
                    case "바나나":
                        Console.WriteLine("이건 바나나네여");
                        break ;
                    case "수박":
                        Console.WriteLine("수박이용");
                        break;
                    
                    default:
                        Console.WriteLine("몰?루");
                        break;
                }
            }
        }
    }
}
