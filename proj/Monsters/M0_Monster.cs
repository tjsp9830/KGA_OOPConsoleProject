using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Monsters
{
    //몬스터 클래스의 부모 클래스
    public abstract class M0_Monster //abstract클래스, 가상함수 사용
    {
        //필드 - 이름, 체력, 공격력, 방어력
        string name;
        int HP;
        int power;
        int defense;

        // 팩토리 패턴으로 다양한 몬스터 구현 시도
        // 이때, 몬스터의 비슷한 특징은 인터페이스로 관리하기

    }


}
