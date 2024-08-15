using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Players;

namespace TextRPG.Monsters
{
    internal class M2_Goblin : M0_Monster
    {

        public M2_Goblin()
        {
            this.name = "고블린";
            this.curHP = 200;
            this.maxHP = curHP;
            this.power = 50;
            this.defense = 20;
            this.gold = 150;
            this.skillName = "\"인중에 화살 맞추기!!\"";
        }


    }

}
