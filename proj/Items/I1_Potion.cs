using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class I1_Potion : I0_Item
    {
        public I1_Potion(Game game) : base (game)
        {
            this.itemType = ItemType.Potion;
            this.name = "체력 물약";
            this.value_heal = 50;
            this.value_gold = 50;
            this.caption = "사용자의 체력을 50 회복시켜주는 물약이다.";

        }


    }


}
