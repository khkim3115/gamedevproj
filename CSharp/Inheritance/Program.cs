using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("아무개", 01012341234, "hi@bye.com");
            Student student = new Student("학생1", 01043214321, "A@Wanna.com");
            Professor professor = new Professor("교수1", 01041411414, "im@clever.com");

            person.PurchaseParkingPass();
            student.PurchaseParkingPass();
            professor.PurchaseParkingPass();

            Console.WriteLine(student.TakenSeminar);


            //공변성
            //자식 타입으로 캐스팅, 참조할 수 있는 성질
            Person p_student = student;
            Person p_professor = professor;

            Person[] people = new Person[] {student, professor};
            for(int i = 0; i < people.Length; i++)
            {
                people[i].PurchaseParkingPass();
            }

            Cat cat = new Cat();
            student.Attack();
            cat.Attack();
        }
    }
}
