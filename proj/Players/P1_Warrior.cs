using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters;

namespace TextRPG.Players
{
    internal class P1_Warrior : P0_Player
    {
        // 1. 전사: 생성자(인수:이름) 피통12, 공3 방3.  override함수 Skill(Monster monster)은 아직 미구현

        public P1_Warrior(string _name)
        {
            this.name = _name;
            this.job = Job.Warrior;
            this.curHP = 120;
            this.maxHP = curHP;
            this.power = 30;
            this.defense = 30;
            this.gold = 0;
        }

        public override void Skill(M0_Monster monster)
        {
            
            // 변경해주기
            Console.WriteLine("검 휘두르기");
            
            
        }


    }
}
