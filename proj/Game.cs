using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters;
using TextRPG.Players;
using TextRPG.Scenes;
// 플레이어 클래스 using
// 씬 클래스 using

namespace TextRPG
{
    // 가동될 게임의 내용들 초기화, 게임 루프패턴 이용
    public class Game
    {
        // ********** 필드 **********
        // bool게임 작동중인지 여부,
        private bool isRunning;

        // 씬 배열,
        private S0_Scene[] scenes;
        // 클래스형 현재 씬(게터세터),
        private S0_Scene curScene;
        public S0_Scene CurScene { get { return curScene; } }


        // 클래스형 플레이어(게터세터)
        public P0_Player player;
        public P0_Player Player { get { return player; }  set { player = value; } }


        // 클래스형 몬스터(게터세터) ---> 몬스터 종류 여러개로 늘린 후에는 배열 형태로 바꾸기
        private M0_Monster monster;
        public M0_Monster Monster { get { return monster; }  set { monster = value; } }



        // ********** 메서드 **********
        public void Run() //게임 루프패턴
        {
            //스타트();
            Start();

            //while(bool게임 작동중==true){렌더();, 인풋();, 업뎃();}
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }

            //엔드();
            End();
        }



        // 씬변경(){현재씬에 초기화된 씬 넣기};
        public void SceneChanger(SceneType _type)
        {
            curScene.Exit();
            curScene = scenes[(int)_type];
            curScene.Enter();

        }

        // 게임오버(){조건false로바꿈};
        public void GameOver()
        {
            isRunning = false;
        }



        // ************** 게임 루프패턴 **************


        // Start(){조건 트루, 씬 1차원배열 다 초기화, 배열의 인덱스에(int)이넘 넣어두고 인스턴스 생성, 씬에 타이틀 넣어서 준비};
        public void Start()
        {
            isRunning = true;

            scenes = new S0_Scene[(int)SceneType.SIZE];
            scenes[(int)SceneType.Title] = new S1_Title(this);
            scenes[(int)SceneType.Select] = new S2_Select(this);
            scenes[(int)SceneType.Town] = new S3_Town(this);
            scenes[(int)SceneType.Shop] = new S4_Shop(this);
            scenes[(int)SceneType.Inventory] = new S5_Inventory(this);
            scenes[(int)SceneType.Battle] = new S6_Battle(this);
            scenes[(int)SceneType.GameOver] = new S7_GameOver(this);

            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();

        }


        // Render(){씬 클래스의 렌더함수};
        public void Render()
        {
            curScene.Render();
        }

        // Input(){씬 클래스의 인풋함수};
        public void Input()
        {
            curScene.Input();
        }

        // Update(){씬 클래스의 업뎃함수};
        public void Update()
        {
            curScene.Update();
        }


        // End(){씬 클래스의 엔드함수};
        public void End()
        {
            curScene.Exit();
        }



    }


}
