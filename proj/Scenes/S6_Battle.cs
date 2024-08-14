using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    internal class S6_Battle : S0_Scene
    {
        // 필드 - 없음


        // 생성자 - 기존 
        public S6_Battle(Game _game) : base(_game)
        {

        }


        // 메서드 - 엔터(), 인풋(), 렌더(), 업뎃() 있음
        // 엔터()에 Thread.Sleep()으로 입장 문구 출력하는 연출
        // 인풋(), 렌더(), 업뎃()은 아직 미구현, 업뎃()에 타운씬으로 돌아가는 연출 있음
        public override void Enter()
        {

            //이전 내용 지우기
            Console.Clear();

            Console.Write("훈련장에 도착했습니다.");
            Thread.Sleep(1500); // 0.15초

        }
        public override void Render()
        {
            // 전투시의 상황 출력 

        }

        public override void Input()
        {
            // 전투 상황에서의 입력받기

        }

        public override void Update()
        {
            // 전투상황 처리, 이후엔 마을로 돌아가는 처리
            game.SceneChanger(SceneType.Town);

        }

        public override void Exit()
        {            

        }

    }
}
