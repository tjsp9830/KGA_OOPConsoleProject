using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters;

namespace TextRPG.Players
{
    internal class P3_Rogue : P0_Player
    {
        // 3. 도적: 생성자(인수:이름) 피통08, 공4 방2.

        public P3_Rogue(string _name)
        {
            this.name = _name;
            this.job = Job.Rogue;
            this.curHP = 80;
            this.maxHP = curHP;
            this.power = 40;
            this.defense = 20;
            this.gold = 300;
            this.skillName = "\"암살\"";

        }


    }
}
