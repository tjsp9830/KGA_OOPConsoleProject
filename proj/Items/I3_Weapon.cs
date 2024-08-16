using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class I3_Weapon : I0_Item
    {
        // 캐릭터 생성시, 각 직업마다 기본 공격력이 다릅니다.
        // 이를 보정하기 위해 똑같은 가격을 주고 무기 업그레이드시
        // 각자가 업그레이드 할 수 있는 무기의 가짓수가 1개로 똑같으므로
        // 모두의 공격력이 똑같아지도록 보정 하였습니다.

        Job job;

        public I3_Weapon(Game game, Job job) : base(game)
        {
            this.itemType = ItemType.Weapon;

            if (job == Job.Warrior)
            {
                this.name = "대검";
                this.value_power = 45; //기존30 + 보정45 = 최종75
                this.caption = "기존의 것 보다 훨씬 묵직한 대검이다.";
                this.value_gold = 300;
            }
            else if (job == Job.Mage)
            {
                this.name = "완드";
                this.value_power = 25; //기존50 + 보정25 = 최종75
                this.caption = "기존의 것 보다 훨씬 커다란 완드이다.";
                this.value_gold = 300;
            }
            else if (job == Job.Rogue)
            {
                this.name = "대거";
                this.value_power = 35; //기존40 + 보정35 = 최종75
                this.caption = "기존의 것 보다 훨씬 날렵한 대거이다.";
                this.value_gold = 300;
            }
            else if (job == Job.Archor)
            {
                this.name = "보우";
                this.value_power = 45; //기존30 + 보정45 = 최종75
                this.caption = "기존의 것 보다 훨씬 가벼운 활과 화살이다.";
                this.value_gold = 300;
            }



        }


    }


}
