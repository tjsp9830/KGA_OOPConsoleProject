using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items;
using TextRPG.Players;

// 실제 RPG게임에서처럼,
// 아이템이 들어오는 순서는 맨 앞부터이나, (맨 위의 맨 왼쪽부터)
// 아이템 위치를 사용자가 원하는 순서로 뒤바꿀 수 있도록 구현해 보았습니다.
namespace TextRPG.Scenes
{

    internal class S5_storage : S0_Scene
    {
        // 필드 - 입력값, 인벤토리, 상태  (인벤구조: 배열or리스트or딕셔너리)
                
        string input;
        I0_Item inven;

        public enum MoneyState { MIdle, MGive }
        MoneyState curState;


        // 생성자 - 기존 
        public S5_storage(Game _game) : base(_game)
        {
            
        }


        // 메서드 - 엔터(), 인풋(), 렌더(), 업뎃() 있음
        // 엔터()에 Thread.Sleep()으로 입장 문구 출력하는 연출
        // 인풋(), 렌더(), 업뎃()은 아직 미구현, 업뎃()에 타운씬으로 돌아가는 연출 있음
        public override void Enter()
        {

            //이전 내용 지우기
            Console.Clear();

            Console.Write("창고에 도착했습니다.");
            Thread.Sleep(1500); // 0.15초

        }

        // 창고에서의 상황 출력 (인벤토리 내용)
        public override void Render()
        {

            P0_Player player = game.Player;
            inven = new I4_Inventory();


            //기부하기로 마음먹었다면
            if (curState == MoneyState.MGive)
            {
                if (player.Gold >= 100)
                    player.Gold -= 100;
                else
                    player.Gold = 0;
                
            }

            Console.Clear();

            // 현재 소지중인 골드
            Console.WriteLine($"현재 소지금: {player.Gold,+4} Gold\n");
            Console.WriteLine("==========================");
            
            // 인벤토리 나열
            inven.ShowInventory();
            Console.WriteLine("");

            // 선택지 제시
            Console.WriteLine("어떤 동작을 할까요?\n");

            Console.WriteLine("1. 마을로 돌아가기");
            Console.WriteLine("2. 상점으로 바로가기");
            Console.WriteLine("3. 기부하기");

            Console.Write("\n선택: ");


        }


        // 인벤토리에서 입력받기
        public override void Input()
        {
            input = Console.ReadLine();
        }


        // 소지금과 인벤토리 변경사항 처리
        public override void Update()
        {
            P0_Player player = game.Player;

            if (input == "1")
            {
                Console.WriteLine("\n마을로 돌아갑니다...");
                Thread.Sleep(1000);
                game.SceneChanger(SceneType.Town);
            }
            else if(input == "2")
            {
                Console.WriteLine("\n상점으로 향합니다...");
                Thread.Sleep(1000);
                game.SceneChanger(SceneType.Shop);
            }
            else if (input == "3")
            {
                curState = MoneyState.MGive;

                if (player.Gold >= 100)
                {                
                    Console.WriteLine("\n당신은 돈을 바닥에 버렸습니다!!");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n소지금이 100원 줄어듭니다.");
                    Thread.Sleep(1000);

                }
                else if (player.Gold > 0)
                {                    
                    Console.WriteLine("\n당신은 남은 돈을 모두 바닥에 뿌렸습니다!!");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n당신은 빈털털이가 되었습니다.");
                    Thread.Sleep(1000);

                }
                else
                {                    
                    Console.WriteLine("\n기부를 할 수 없습니다.");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n(당신의 소지금은 0원입니다..)");
                    Thread.Sleep(1000);
                    return;

                }

                
            }

        }

        public override void Exit()
        {

        }


    }


}
