using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Players;

namespace TextRPG.Monsters
{
    //몬스터 클래스의 부모 클래스
    public class M0_Monster //abstract클래스, 가상함수 사용
    {
        //필드 - 이름, 체력, 공격력, 방어력

        protected string name;
        public string Name { get { return name; } }

        protected int curHP;
        public int CurHP { get { return curHP; } set { curHP = value; } }

        protected int maxHP;
        public int MaxHP { get { return maxHP; } }

        protected int power;
        public int Power { get { return power; } }

        protected int defense;
        public int Defense { get { return defense; } }

        protected int gold;
        public int Gold { get { return gold; } }

        protected string skillName;
        public string SkillName { get { return skillName; }  set { skillName = value; } }



        //함수 - Skill(Player player) 스킬 선언!
        public string Skill(P0_Player player)
        {
            int damage = this.power - player.Defense;
            player.CurHP -= damage;

            return skillName;
        }

        // 팩토리 패턴으로 다양한 몬스터 구현 시도
        // 이때, 몬스터의 비슷한 특징은 인터페이스로 관리하기

        // 몬스터 출연은 랜덤으로 시도ㅠㅠ

    }


}
