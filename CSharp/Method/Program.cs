using System;

//Function: 연산을 수행할 수 있는 기능
//Method: 객체/클래스 단위로 호출되는 Function (멤버함수)

//함수 형태 3가지
//한수선언, 정의, 호출
//함수선언: 아래 형태와 같은 함수를 사용하겠다 라고만 선언
//반환형 함수이름 (파라미터);

//함수정의:
//반환형 함수이름 (파라미터)
/*
{
    연산
    return;

}

함수호출:
함수이름 (인자);
*/


/*
namespace Method
{
    internal class Program
    {
        //여기서 Main 함수는 함수정의
        static void Main(string[] args)
        {
            //여기 Console.WriteLine은 함수호출
            Console.WriteLine("Hello World!");
        }
    }
}
*/
namespace Method
{
    internal class Program
    {
        static bool helloworldPrinted;
        static void Main(string[] args)
        {
            //지역변수 - 함수 내에서 선언된 변수
            //지역변수는 함수호출 스택에 같이 할당
            //데이터를 대입한 후에 접근해야함
            bool somethingPrinted = false;

            PrintHelloWorld();
            string name = "Kevin";
            PrintSometing(name);
            Console.WriteLine(somethingPrinted);
            Console.WriteLine(helloworldPrinted);
        }
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
            helloworldPrinted = true;
        }

        static void PrintSometing(string something)
        {
            Console.WriteLine(something);
        }
    }
}
