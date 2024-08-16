using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TextRPG.Players;

namespace TextRPG.Items
{
    public class I0_Item
    {
        public Game game;
        public ItemType itemType;
        


        protected string name; //아이템 이름
        public string Name { get { return name; }  set { name = value; } }


        protected int value_heal; //체력 회복 수치
        public int Value_heal { get { return value_heal; }  set { value_heal = value; } }

        protected int value_power; //공격력 증가 수치
        public int Value_power { get { return value_power; }  set { value_power = value; } }

        protected int value_defense; //방어력 증가 수치
        public int Value_defense { get { return value_defense; }  set { value_defense = value; } }

        protected int value_gold; //사고팔때의 가격 (얼마인지)
        public int Value_gold { get { return value_gold; }  set { value_gold = value; } }
        

        protected string caption; //아이템 설명
        public string Caption { get { return caption; } set { caption = value; } }


        // 게임 인스턴트 가져오기
        public I0_Item(Game _game)
        {
            game = _game;
        }


        // 몬스터 처치시, 몬스터의 유형에 맞는 아이템이 생성되게 하는 함수
        public void SetItemType(MonsterType type)
        {
            
            if(type == MonsterType.Orc)
            {
                //생성로직
            }
            else if (type == MonsterType.Goblin)
            {
                //생성로직
            }
            else if (type == MonsterType.Slime)
            {
                //생성로직
            }




        }


        // 플레이어의 인벤토리를 전부 출력하는 함수
        public void ShowInventory()
        {
            

            if (game.inventory.slots.Count == 0)
            {
                Console.WriteLine("현재 인벤토리가 비어있습니다.");
            }
            else
            {
                Console.WriteLine("------- 현재 인벤토리 -------");

                for (int i = 0; i < game.inventory.slots.Count; i++)
                {
                    Console.WriteLine($" {i + 1}. {game.inventory.slots[i].name}");
                }
            }
            Console.WriteLine("==========================");
            Console.WriteLine();
        }


        // 상점에 진열된 품목을 전부 출력하는 함수
        public void ItemsOnDisplay()
        {

        }


        // 아이템의 설명을 적을 함수
        public void ReadItemCaption()
        {
            Console.Write(this.caption);
        }



    }


}
