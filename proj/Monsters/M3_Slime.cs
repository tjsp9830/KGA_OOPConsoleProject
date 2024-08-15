using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Players;

namespace TextRPG.Monsters
{
    internal class M3_Slime : M0_Monster
    {

        public M3_Slime()
        {
            this.name = "슬라임";
            this.curHP = 150;
            this.maxHP = curHP;
            this.power = 70;
            this.defense = 0;
            this.gold = 300;
            this.skillName = "\"녹여버리기!!\"";
        }

    }

}
