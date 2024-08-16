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
        // 4. 궁수: 생성자(인수:이름) 피통08, 공3 방4.

        public P4_Archor(string _name)
        {
            this.name = _name;
            this.job = Job.Archor;
            this.curHP = 80;
            this.maxHP = curHP;
            this.power = 30;
            this.defense = 40;
            this.gold = 100;
            this.skillName = "\"폭풍의 화살\"";

        }


    }
}
