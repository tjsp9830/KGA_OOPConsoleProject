using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
<<<<<<< HEAD
    internal class I2_Loot : I0_Item
    {
        public I2_Loot()
        {
            this.name = "전리품";            
            this.value_gold = 300;
            this.caption = "설명";
            //오크전용 this.caption = "오크가 휘두르던 물 먹은 나무 몽둥이이다.";
            //고블린용 this.caption = "고블린이 쏘아 맞추던 활과 화살이다.";
            //슬라임용 this.caption = "슬라임에게 미처 소화되지 못한채 발견된 금덩어리이다.";

        }

        public override void ReadItemCaption()
        {
            Console.Write(this.caption);
        }

    }


=======
    internal class I2_Loot
    {
    }
>>>>>>> dc7add0786ae07a5715f5752d39182fa07a25e4f
}
