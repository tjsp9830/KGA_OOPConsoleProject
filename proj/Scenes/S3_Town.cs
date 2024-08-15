using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    internal class S3_Town : S0_Scene
    {
        // 필드 - 스트링 인풋,
        string input;
        string[] inputs;

        // 생성자 - 기존의 것을 계속 씀.
        public S3_Town(Game _game) : base(_game)
        {

        }


        // 메서드 - 엔터(), 인풋(), 렌더(), 업뎃() 있음
        // 엔터() 에 Thread.Sleep(2000)라는 함수가 처음 등장!! 유니티에서 Invoke() 했던거랑 똑같은애인듯.
        // 인풋() 에서 입력내용 받아옴
        // 렌더() 에서 다음 이동할 공간 선택하라는 내용 출력
        // 업뎃() 에서 인풋 내용에 따른 스위치로 각각 배틀씬, 인벤씬, 상점씬으로 연결

        public override void Enter()
        {
            //이전 내용 지우기
            Console.Clear();

            inputs = "마을로 진입중입니다...".Split("");

            for (int i = 0; i < inputs.Length; i++)
            {
                Console.Write($"{inputs[i]}");
                Thread.Sleep(2000); // 0.2초
            }
            //Console.Write("마을로 진입중입니다.");
            //Thread.Sleep(2000);

        }

        public override void Render()
        {
            Console.Clear();

            // 입력이 시작될 커서의 위치와 끝난 뒤의 커서 위치를 지정해놓았기 때문에
            // 그 점을 고려해서 스크립트 입력이 필요함
            game.Player.PrintAll();

            Console.WriteLine("마을에 도착했습니다.");
            Console.WriteLine("어디로 이동할까요?\n");
            Console.WriteLine("1. 소지품 확인하러 가기");
            Console.WriteLine("2. 상점으로 이동하기");
            Console.WriteLine("3. 훈련장으로 이동하기");

            Console.Write("\n선택 : ");

        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {

            switch (input)
            {

                case "1":
                case "d":
                    game.SceneChanger(SceneType.Inventory);
                    break;

                case "2":
                case "t":
                    game.SceneChanger(SceneType.Shop);
                    break;

                case "3":
                case "g":
                    game.SceneChanger(SceneType.Battle);
                    break;

            }

        }

        public override void Exit()
        {

        }

    }
}
