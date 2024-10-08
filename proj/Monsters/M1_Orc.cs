﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Players;
using TextRPG.Items;

namespace TextRPG.Monsters
{
    public class M1_Orc : M0_Monster
    {
        public M1_Orc(Game game) : base(game)
        {
            this.monType = MonsterType.Orc;
            this.name = "오크";
            this.curHP = 100;
            this.maxHP = curHP;
            this.power = 35;
            this.defense = 5;
            this.gold = 50;
            this.skillName = "\"아프게때리기!!\"";
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

                //Inventory inven = new Inventory();

                //게임에 있는 인스턴스에 넘겨주기
                game.inventory.UpdateItem(item);
                //game.inventory.slots[game.inventory.slots.Count] = (I0_Item)item;
            }


        }

    }

}
