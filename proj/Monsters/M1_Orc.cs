using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Players;

namespace TextRPG.Monsters
{
    internal class M1_Orc : M0_Monster
    {
        public M1_Orc()
        {
            this.name = "오크";
            this.curHP = 100;
            this.maxHP = curHP;
            this.power = 35;
            this.defense = 15;
            this.gold = 50;
        }

        public override void Skill(P0_Player player)
        {
            Console.WriteLine("아프게때리기!!");
        }


    }

}
