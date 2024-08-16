using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters;
using TextRPG.Items;

namespace TextRPG.Scenes
{
    internal class S4_Shop : S0_Scene
    {
        // 필드 - 없음 
        public Game game;
        public string input;
        public int money;

        // 생성자 - 기존
        public S4_Shop(Game _game) : base(_game)
        {
            game = _game;
            
        }


        // 메서드 - 엔터(), 인풋(), 렌더(), 업뎃() 있음

        // 엔터()에 Thread.Sleep()으로 입장 문구 출력하는 연출
        // 인풋(), 렌더(), 업뎃()은 아직 미구현, 업뎃()에 타운씬으로 돌아가는 연출 있음

        public override void Enter()
        {

            //이전 내용 지우기
            Console.Clear();
            
            Console.Write("상점에 들어왔습니다.");
            Thread.Sleep(1500); // 0.15초

            Console.Clear();

            //상점 목록, 구현한것과 미구현인것 구분해두기
            //game.shopItems[0] --> 소형포션  //모두 구매 가능, 구매해도 삭제X
            //game.shopItems[1] --> 대형포션  //모두 구매 가능, 구매해도 삭제X
            //game.shopItems[2] --> 투구  //모두 구매 가능, 구매시 삭제처리
            //game.shopItems[3] --> 갑옷  //모두 구매 가능, 구매시 삭제처리
            //game.shopItems[4] --> 장갑  //모두 구매 가능, 구매시 삭제처리
            //game.shopItems[5] --> 신발  //모두 구매 가능, 구매시 삭제처리
            //game.shopItems[6] --> 대검.  //전사만 구매 가능, 구매시 삭제처리
            //game.shopItems[7] --> 완드.  //법사만 구매 가능, 구매시 삭제처리
            //game.shopItems[8] --> 대거.  //로그만 구매 가능, 구매시 삭제처리
            //game.shopItems[9] --> 보우.  //아처만 구매 가능, 구매시 삭제처리

        }

        // 상점에서의 상황 출력
        public override void Render()
        {

            Console.Clear();

            Console.WriteLine("이곳은 시민들의 양심으로 운영되는 무인상점이다.");
            Thread.Sleep(1000);

            Console.WriteLine("\n현재 판매중인 상품은 다음과 같다.\n\n");
            Thread.Sleep(1000);

            // 판매중인 물품 진열
            for(int i=0; i<game.shopItems.Length; i++)
            {
                Console.WriteLine($"{i+1, 2}번. {game.shopItems[i].Name},  금액: {game.shopItems[i].Value_gold} 골드");
                Thread.Sleep(100);
            }

            // 선택해라
            Console.WriteLine($"\n당신의 소지 금액: {game.player.Gold}");
            Thread.Sleep(500);

            Console.WriteLine("\n\n어떤 행동을 취할까?");
            Thread.Sleep(500);

            Console.WriteLine("> 1. 가지고 있는 물건 모두 판매하기");
            // 선택1. 판매 > 전부 판매하기 > 아이템 삭제, 돈 들어옴
            Console.WriteLine("> 2. 진열되어 있는 물건 구매하기");
            // 선택2. 구매 > 원하는 번호 입력 > 아이템 추가, 돈 빠져나감
            Console.WriteLine("> 3. 진열되어 있는 물건 훔쳐가기");
            // 선택3. 페이크
            Console.WriteLine("> 4. 마을로 돌아가기");
            // 선택4. 마을로 돌아가기
            Console.WriteLine("> 5. 창고로 돌아가기");
            // 선택5. 창고로 돌아가기
            Thread.Sleep(500);

            Console.Write("\n---> 당신의 선택: ");





        }

        // 상점에서 입력받기
        public override void Input()
        {
            input = Console.ReadLine();
        }

        // 상점 업데이트() 구현 필요
        public override void Update()
        {

            //물건 판매
            if(input == "1")
            {                
                if (game.inventory.slots.Count == 0)
                {
                    Console.WriteLine("\n판매할 수 있는 물건이 아직 없다.");
                    Thread.Sleep(2000);
                    return;
                }
                else
                {
                    //보여주고
                    game.inventory.ShowInventory();
                    Thread.Sleep(1000);

                    //삭제하고
                    int totalPrise = 0;
                    Console.WriteLine("위 아이템이 모두 판매되었습니다.");
                    for (int i = game.inventory.slots.Count-1; i >= 0 ; i--)
                    {
                        totalPrise += game.inventory.slots[i].Value_gold;
                        game.inventory.RemoveItem(i);
                    }
                    Thread.Sleep(2000);

                    //돈 들어오고
                    Console.WriteLine($"당신은 판매 수익으로 {totalPrise}골드를 얻었다.");
                    game.player.Gold += totalPrise;                    
                    Thread.Sleep(2000);
                    
                    //단, 토탈값 반환에서
                    // 돈을 플레이어한테 직접 넣기보단, 돈 정보를 샵이 들고있는쪽이 나을거같다고 하심

                }
            }
            //물건 구매
            else if (input == "2")
            {
                Console.WriteLine("\n물건 구매항목 테스트문구");
                Thread.Sleep(2000);
                

                Thread.Sleep(2000);
            }
            // 페이크
            else if (input == "3")
            {
                Console.WriteLine("\n\' 양심적으로 삽시다!! \'");
                Thread.Sleep(1000);
                Console.WriteLine("마음의 소리에 놀란 당신은 물건을 훔치지 않기로 했다.");
                Thread.Sleep(2000);

            }
            //마을로 이동
            else if (input == "4")
            {
                Console.WriteLine("마을로 돌아갑니다...");
                Thread.Sleep(2000);
                game.SceneChanger(SceneType.Town);
            }
            //창고로 이동
            else if (input == "5")
            {
                Console.WriteLine("창고로 돌아갑니다...");
                Thread.Sleep(2000);
                game.SceneChanger(SceneType.Storage);
            }
            

        }

        public override void Exit()
        {

        }


    }
}
