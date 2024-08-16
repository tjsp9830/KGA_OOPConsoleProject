using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters;

namespace TextRPG.Players
{
    internal class P2_Mage : P0_Player
    {
        // 2. 법사: 생성자(인수:이름) 피통06, 공5 방1.

        public P2_Mage(string _name)
        {
            this.name = _name;
            this.job = Job.Mage;
            this.curHP = 60;
            this.maxHP = curHP;
            this.power = 50;
            this.defense = 10;
            this.gold = 400;
            this.skillName = "\"파이어볼\"";

        }

    }
}
