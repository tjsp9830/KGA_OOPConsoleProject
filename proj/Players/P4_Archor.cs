using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters;

namespace TextRPG.Players
{
    internal class P4_Archor : P0_Player
    {
        // 4. 궁수: 생성자(인수:이름) 피통08, 공3 방4.  override함수 Skill(Monster monster)은 아직 미구현

        public P4_Archor(string _name)
        {
            this.name = _name;
            this.job = Job.Archor;
            this.curHP = 80;
            this.maxHP = curHP;
            this.power = 30;
            this.defense = 40;
            this.gold = 0;

        }

        public override void Skill(M0_Monster monster)
        {

            // 변경해주기
            Console.WriteLine("폭풍의 화살");


        }

    }
}
