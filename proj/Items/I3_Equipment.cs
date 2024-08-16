using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class I3_Equipment : I0_Item
    {
        // 캐릭터 생성시, 각 직업마다 기본 방어력이 다릅니다.
        // 방어구를 여러개로 나눠놓아서 이를 전부 착용해도 동일한 수치만큼 올라서
        // 각 직업의 최종 방어력이 상이하므로 보정이 필요하다고 판단했습니다.
        // 따라서 방어구 업그레이드 가격은 모두 똑같으므로 캐릭터 생성시의 소지금을 다르게 두었습니다.

        public I3_Equipment(Game game, string name) : base(game)
        {
            this.itemType = ItemType.Equipment;

            if (name == "투구")
            {
                this.name = "강철투구";
                this.value_gold = 300;
                this.value_defense = 30;
                this.caption = "매우 단단한 투구이다.";

            }
            else if(name == "갑옷")
            {
                this.name = "무쇠갑옷";
                this.value_gold = 200;
                this.value_defense = 20;
                this.caption = "기존의 것 보다 훨씬 단단한 갑옷이다.";            

            }
            else if (name == "장갑")
            {
                this.name = "사슬장갑";
                this.value_gold = 150;
                this.value_defense = 15;
                this.caption = "통풍이 잘 될것만 같은 장갑이다.";

            }
            else if (name == "신발")
            {
                this.name = "가죽신발";
                this.value_gold = 100;
                this.value_defense = 10;
                this.caption = "없는것보단 나을것 같은 신발이다.";

            }


        }


    }


}
