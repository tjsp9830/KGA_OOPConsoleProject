using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    internal class I1_Potion : I0_Item
    {
        public I1_Potion()
        {
            this.name = "체력 물약";
            this.value_heal = 50;
            this.value_gold = 50;
            this.caption = "물약";

        }

        public override void ItemCaption()
        {

        }

    }


}
