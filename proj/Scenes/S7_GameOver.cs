using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    internal class S7_GameOver : S0_Scene
    {

        // 필드 - 없음


        // 생성자 - 기존 
        public S7_GameOver(Game _game) : base(_game)
        {

        }


        public override void Enter()
        {


        }
        public override void Render()
        {
            Console.WriteLine("게임오버!");
        }
        public override void Input()
        {

        }
        public override void Update()
        {

        }
        public override void Exit()
        {

        }

    }


}
