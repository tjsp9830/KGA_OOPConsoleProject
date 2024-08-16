using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items;
using TextRPG.Monsters;
using TextRPG.Players;
using TextRPG.Scenes;


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


        // 인벤토리 (아이템 배열X 인벤토리의 인스턴스O)
        public I4_Inventory inventory;


        // 클래스형 몬스터(게터세터) ---> 몬스터 종류 여러개로 늘린 후에는 배열 형태로 바꾸기
        private M0_Monster[] monsters;
        private M0_Monster monster;
        public M0_Monster Monster { get { return monster; }  set { monster = value; } }


        // 상점 진열품 배열
        public I0_Item[] shopItems;
        //private I0_Item curShopItem;
        //public I0_Item CurShopItem { get { return curShopItem; } set { curShopItem = value; } }



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
            //----------------------------------------------------------
            scenes = new S0_Scene[(int)SceneType.SIZE];
            scenes[(int)SceneType.Title] = new S1_Title(this);
            scenes[(int)SceneType.Select] = new S2_Select(this);
            scenes[(int)SceneType.Town] = new S3_Town(this);
            scenes[(int)SceneType.Shop] = new S4_Shop(this);
            scenes[(int)SceneType.Storage] = new S5_storage(this);
            scenes[(int)SceneType.Battle] = new S6_Battle(this);
            scenes[(int)SceneType.GameOver] = new S7_GameOver(this);

            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();
            //----------------------------------------------------------
            monsters = new M0_Monster[3];
            monsters[(int)MonsterType.Orc] = new M1_Orc(this);
            monsters[(int)MonsterType.Goblin] = new M2_Goblin(this);
            monsters[(int)MonsterType.Slime] = new M3_Slime(this);
            //----------------------------------------------------------
            inventory = new I4_Inventory();
            //----------------------------------------------------------
            shopItems = new I0_Item[10];            
            shopItems[0] = new I1_Potion(this, "소형물약"); //소형포션, 모두 구매 가능, 구매해도 삭제X
            shopItems[1] = new I1_Potion(this, "대형물약"); //대형포션, 모두 구매 가능, 구매해도 삭제X
            shopItems[2] = new I3_Equipment(this, "투구"); //투구, 모두 구매 가능, 구매시 삭제처리
            shopItems[3] = new I3_Equipment(this, "갑옷"); //갑옷, 모두 구매 가능, 구매시 삭제처리
            shopItems[4] = new I3_Equipment(this, "장갑"); //장갑, 모두 구매 가능, 구매시 삭제처리
            shopItems[5] = new I3_Equipment(this, "신발"); //신발, 모두 구매 가능, 구매시 삭제처리
            shopItems[6] = new I3_Weapon(this, Job.Warrior); //대검, 전사만 구매 가능, 구매시 삭제처리
            shopItems[7] = new I3_Weapon(this, Job.Mage); //완드, 법사만 구매 가능, 구매시 삭제처리
            shopItems[8] = new I3_Weapon(this, Job.Rogue); //대거, 로그만 구매 가능, 구매시 삭제처리
            shopItems[9] = new I3_Weapon(this, Job.Archor); //보우, 아처만 구매 가능, 구매시 삭제처리

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
