﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items;
using TextRPG.Players;

namespace TextRPG.Monsters
{
    internal class M2_Goblin : M0_Monster
    {

        public M2_Goblin(Game game) : base(game)
        {
            this.monType = MonsterType.Goblin;
            this.name = "고블린";
            this.curHP = 200;
            this.maxHP = curHP;
            this.power = 60;
            this.defense = 20;
            this.gold = 150;
            this.skillName = "\"인중에 화살 맞추기!!\"";
        }

        public override void GiveLoot()
        {
            //예외처리
            if (this.curHP > 0)
                return;
            else
            {
                I0_Item item = new I2_Loot(game, monType);

                item.SetItemType(monType);

                //게임에 있는 인스턴스에 넘겨주기
                game.inventory.UpdateItem(item);

            }


        }

    }

}
