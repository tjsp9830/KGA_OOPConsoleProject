using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters; // 몬스터 클래스 using

namespace TextRPG.Players{

    public abstract class P0_Player
    {

        // 각 클래스별로 타고난 공격력과 방어력 수치가 다른데,
        // 이를 보정하기 위해서 다음과 같이 조정했습니다.
        // --> 무기 구매시, 공격력 업글 수치를 직업별로 다르게 적용해서  최종 공격력을 똑같게 보정
        // --> 갑옷 구매시, 방어력 업글 수치는 모두 똑같기에  최종 방어력에 차이가 생기므로  최초 소지금을 다르게하여 보정 시도

        // 단, 몬스터의 공격력/방어력 수치도 생각해야 하기 때문에
        // 수월한 전투를 위해서는 플레이어가 골드를 모으기만 하기 힘들도록 하였습니다.
        // (상점의 아이템을 구매할수록 1000골드 모으는 최종 목표가 수월해지도록)


        //필드 - 이름, 직업, 현재체력, 최대체력, 공격력, 방어력, 소지금액(모두 게터세터 이용해 초기화)
        
        protected string name;
        public string Name { get { return name; }  }


        protected Job job;
        public Job Job { get { return job; }  }


        protected int curHP;
        public int CurHP { get { return curHP; }  set { curHP = value; } }

        protected int maxHP;
        public int MaxHP { get { return maxHP; }  }
        
        
        protected int power;
        public int Power { get { return power; }  }

        protected int defense;
        public int Defense { get { return defense; }  }


        protected int gold;
        public int Gold { get { return gold; }  set { gold = value; }  }


        protected string skillName;
        public string SkillName { get { return skillName; } set { skillName = value; } }



        //함수1 - Skill(Monster monster) 스킬 선언!
        public string Skill(M0_Monster monster)
        {
            int damage = this.power - monster.Defense;
            monster.CurHP -= damage;

            return skillName;
        }



        //함수2 - 현재 내용 보여주는 코드 작성, 이때 SetCursorPosition이라는 함수를 이용.
        public void PrintAll()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("==========================================");
            Console.WriteLine("                현재 정보");
            Console.WriteLine($" 이름: {name,-7} 직업 : {job,-6}");
            Console.WriteLine($" 체력: {curHP,+3} / {maxHP}  공격: {power,-3} / 방어: {defense,-3}");
            Console.WriteLine($" 골드: {gold,+4} G");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.SetCursorPosition(0, 7);

        }


    }


}
