using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{

    public class I2_Loot : I0_Item
    {
        public I2_Loot()
        {
            
            this.name = "전리품";            
            this.value_gold = 300;
            //this.caption = "설명";
            if (this.itemType == ItemType.LootOrc)
            {
                this.caption = "오크가 휘두르던 물 먹은 나무 몽둥이이다.";
            }
            else if (this.itemType == ItemType.LootGoblin)
            {
                this.caption = "고블린이 쏘아 맞추던 활과 화살이다.";
            }
            else if (this.itemType == ItemType.LootSlime)
            {
                this.caption = "슬라임에게서 미처 소화되지 못한채 발견된 금덩어리이다.";
            }

        }


    }



}
