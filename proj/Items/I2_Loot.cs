using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{

    public class I2_Loot : I0_Item
    {
        public I2_Loot(Game game, MonsterType type) : base(game)
        {
                        
            if (type == MonsterType.Orc)
            {
                this.name = "전리품: 몽둥이";            
                this.value_gold = 100;
                this.caption = "오크가 휘두르던 물 먹은 나무 몽둥이이다.";
            }
            else if (type == MonsterType.Goblin)
            {
                this.name = "전리품: 활과 화살";
                this.value_gold = 200;
                this.caption = "고블린이 쏘아 맞추던 활과 화살이다.";
            }
            else if (type == MonsterType.Slime)
            {
                this.name = "전리품: 금덩이";
                this.value_gold = 300;
                this.caption = "슬라임에게서 미처 소화되지 못한채 발견된 금덩어리이다.";
            }

        }


    }



}
