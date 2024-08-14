using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    internal class S1_Title : S0_Scene
    {
        // 생성자 - 기존의 것을 계속 씀.
        public S1_Title(Game _game) : base(_game)
        {

        }


        // 메서드 - 인풋(), 렌더(), 업뎃()에 내용 넣음.  업뎃()에서 셀렉신 연결해둠
        public override void Enter()
        {


        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("=                                  =");
            Console.WriteLine("=            레전드 RPG            =");
            Console.WriteLine("=                                  =");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("    계속하려면 아무키나 누르세요    ");

        }

        public override void Input()
        {
            //아무 키나 입력받기
            Console.ReadKey(); 

        }

        public override void Update()
        {
            // 게임쪽에 있는 씬체인져 함수에게 다음 씬을 인자로 줌
            game.SceneChanger(SceneType.Select);
        }

        public override void Exit() 
        {


        }



    }
}
