using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    internal class I3_Equipment : I0_Item
    {
        public I3_Equipment()
        {
            //this.name = "무기";
            //공수치 this.value_power = 25;
            //무기전용 this.caption = "기존의 것 보다 훨씬 날카로운 대검이다.";
            //무기 this.value_gold = 300;
            this.name = "갑옷";
            this.value_gold = 200;
            this.value_defense = 25;
            this.caption = "기존의 것 보다 훨씬 단단한 장신구이다.";            

        }

        public override void ReadItemCaption()
        {
            Console.Write(this.caption);
        }

    }


}
