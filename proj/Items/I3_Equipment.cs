using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class I3_Equipment : I0_Item
    {
        public I3_Equipment()
        {
            this.itemType = ItemType.Equipment;
            this.name = "갑옷";
            this.value_gold = 200;
            this.value_defense = 25;
            this.caption = "기존의 것 보다 훨씬 단단한 장신구이다.";            

        }


    }


}
