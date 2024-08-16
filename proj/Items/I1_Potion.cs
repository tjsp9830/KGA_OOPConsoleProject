using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class I1_Potion : I0_Item
    {
        public I1_Potion(Game game, string name) : base (game)
        {
            this.itemType = ItemType.Potion;

            if (name == "소형물약")
            {
                this.name = "소형물약";
                this.value_heal = 50;
                this.value_gold = 50;
                this.caption = "사용자의 체력을 50 회복시켜주는 물약이다.";

            }
            else if(name == "대형물약")
            {
                this.name = "대형물약";
                this.value_heal = 100;
                this.value_gold = 100;
                this.caption = "사용자의 체력을 100 회복시켜주는 물약이다.";

            }

        }


    }


}
