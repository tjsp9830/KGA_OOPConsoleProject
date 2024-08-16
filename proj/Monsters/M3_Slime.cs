using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items;
using TextRPG.Players;

namespace TextRPG.Monsters
{
    internal class M3_Slime : M0_Monster
    {

        public M3_Slime(Game game) : base(game)
        {
            this.monType = MonsterType.Slime;
            this.name = "슬라임";
            this.curHP = 150;
            this.maxHP = curHP;
            this.power = 85;
            this.defense = 35;
            this.gold = 300;
            this.skillName = "\"녹여버리기!!\"";
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
