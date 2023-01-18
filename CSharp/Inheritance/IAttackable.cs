using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Interface
    //함수, 이벤트, 인덱서, 프로퍼티를 추상화 하기 위한 문법
    //각 멤버는 접근제한자가 기본적으로 public
    //각 멤버들은 선언만 할 뿐 정의하지 않는다 (기본적으로)
    //특정 C# 버전 이상부터는 구헌도 가능 (디폴트로 구현부에서 코드를 자동환성하는 용도로만 구현부 작성)
    //다중상속 가능
    //

    internal interface IAttackable
    {
        void Attack();


    }
}
