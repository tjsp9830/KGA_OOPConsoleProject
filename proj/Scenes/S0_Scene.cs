using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    public abstract class S0_Scene
    {

        // 필드 - protected 클래스형 게임
        protected Game game;


        // 생성자 - game에 입력받은 Game클래스형 game을 대입해주기
        public S0_Scene(Game _game)
        {
            this.game = _game;
        }


        // 메서드 - 추상함수 Enter(), Render(), Input(), Update(), Exit();
        public abstract void Enter();
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Exit();


    }
}
