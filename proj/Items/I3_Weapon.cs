using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class I3_Weapon : I0_Item
    {
        public I3_Weapon()
        {
            this.itemType = ItemType.Weapon;
            this.name = "무기";
            this.value_power = 25;
            this.caption = "기존의 것 보다 훨씬 날카로운 대검이다.";
            this.value_gold = 300;            

        }


    }


}
