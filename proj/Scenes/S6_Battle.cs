using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Players;
using TextRPG.Monsters;
using System.Threading;

namespace TextRPG.Scenes
{
    internal class S6_Battle : S0_Scene
    {
        // 필드 - 플레이어 상태머신, bool 전투중, string 인풋 

        public enum State { Idle, Run, Attack, Defense, Win, Dead }
        private State curState;
        string input;

        // Help)
        // 초기화를 시도하였으나, 필드에서는 선언을 못하고
        // 생성자나 함수에서 초기화하면 지역변수라서 사용을 못합니다ㅠㅠ
        // 그래서 Scene에 있는 protected Game game을 static선언해서 사용중인데 그래도 괜찮나요?
        P0_Player player;
        M0_Monster monster;


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
            
            Console.WriteLine("훈련장에 도착했습니다.");
            Thread.Sleep(1000); // 0.15초
            
                        
            //도착 안내멘트, 몬스터 출현멘트 다 지우고 새로 쓰기.
            Console.Clear();
                        

            // 전투 시작
            curState = State.Idle;
            game.Monster = new M1_Orc();

        }


        public override void Render()
        {
            Console.Clear();

            // 예외1 = 플레이어 이김
            if (curState == State.Win)
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("플레이어가 몬스터를 무찔렀다!");
                game.player.Gold += game.Monster.Gold;
                Console.WriteLine($"보상으로 {game.Monster.Gold}골드를 얻었다.");

                Console.WriteLine("마을로 돌아가자...");
                Thread.Sleep(2000);
                game.SceneChanger(SceneType.Town);

            }

            // 예외2 = 플레이어 죽음
            if (curState == State.Dead)
            {
                Console.SetCursorPosition(5, 10);
                Console.WriteLine("플레이어가 치명상을 입었다.");
                Console.SetCursorPosition(5, 10);
                Console.WriteLine("G a m e O v e r");
                Environment.Exit(0);

            }

            Console.WriteLine("야생의 몬스터가 나타났다!");

            if (curState == State.Idle)
            {
                //플레이어의 체력
                Console.SetCursorPosition(5, 3);
                Console.WriteLine($"당신의 체력: {game.Player.CurHP}");

                //몬스터의 체력
                Console.SetCursorPosition(5, 4);
                Console.WriteLine($"몬스터의 체력: {game.Monster.CurHP}");

                //어떤 행동을 할까?
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("어떤 행동을 할까?");
                //도망가기, 공격하기, 방어하기
                Console.WriteLine("> 1.도망가기 2.공격하기 3.방어하기");
                Console.Write("> 행동 선택: ");

                return;

            }
            else if (curState == State.Run)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("당신은 전투에서 도망가기를 원했지만,");
                Console.WriteLine("도주에 실패하고 말았다.");
                Thread.Sleep(1000);

                Console.SetCursorPosition(0, 6);
                Console.WriteLine($"{game.Monster.Skill}");
                Console.WriteLine("몬스터가 당신을 공격했다...");
                Thread.Sleep(1000);
                                

            }
            else if (curState == State.Attack)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine($"{game.Player.Skill}");
                Console.WriteLine("당신은 몬스터를 공격했다.");
                Thread.Sleep(1000);

                Console.SetCursorPosition(0, 6);
                Console.WriteLine($"{game.Monster.Skill}");
                Console.WriteLine("몬스터도 당신을 공격했다...");
                Thread.Sleep(1000);

                
            }
            else if (curState == State.Defense)
            {                
                Console.SetCursorPosition(0, 3);
                Console.WriteLine($"{game.Monster.Skill}");
                Console.WriteLine("몬스터가 당신을 공격했다.");
                Thread.Sleep(1000);

                Console.SetCursorPosition(5, 6);
                Console.WriteLine("텅 - - - !");
                Console.WriteLine("당신은 방패로 몬스터에게 반격했다...");
                Thread.Sleep(1000);


            }
            



            //플레이어의 체력 표시
            Console.SetCursorPosition(5, 10);
            Console.WriteLine($"당신의 체력: {game.Player.CurHP}");

            //몬스터의 체력 표시
            Console.SetCursorPosition(5, 11);
            Console.WriteLine($"몬스터의 체력: {game.Monster.CurHP}");


            //예외처리 0 - 일단 끝내고 업데이트로 넘김
            if (game.Monster.CurHP <= 0 || game.Player.CurHP <= 0)
                return;


            // 행동 선택
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("어떤 행동을 할까?");
            Console.WriteLine("> 1.도망가기 2.공격하기 3.방어하기");
            Console.Write("> 행동 선택: ");




        }

        public override void Input()
        {
            // 예외처리
            if (game.Monster.CurHP <= 0 || game.Player.CurHP <= 0)
                return;

            // 전투 상황에서의 입력받기
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    curState = State.Run;
                    break;

                case "2":
                    curState = State.Attack;
                    break;

                case "3":
                    curState = State.Defense;
                    break;

            }

        }


        // 전투상황 처리, 이후엔 마을로 돌아가는 처리
        public override void Update()
        {
            // 예외처리

            // 플레이어의 체력이 0 이하가 되면 ---> 게임이 끝남, 프로그램 종료
            if (game.Player.CurHP <= 0)
                curState = State.Dead;
            

            // 몬스터의 체력이 0 이하가 되면 -----> 전투가 끝남, 골드를 얻고 마을로 돌아감
            if (game.Monster.CurHP <= 0)
                curState = State.Win;
            


            // 전투중
            int damame = 0;

            if(input == "1")
            {
                //플레이어만 맞음
                damame += game.Monster.Power;
                damame -= game.Player.Defense;
                game.Player.CurHP -= damame;

            }
            else if (input == "2")
            {
                // 서로 맞음 (몬스터가 먼저 맞고 그다음 플레이어가 맞음)
                damame += game.Player.Power;
                damame -= game.Monster.Defense;
                game.Monster.CurHP -= damame;

                damame += game.Monster.Power;
                damame -= game.Player.Defense;
                game.Player.CurHP -= damame;

            }
            else if (input == "3")
            {
                // 몬스터만 맞음
                damame += game.Player.Power;
                damame -= game.Monster.Defense;
                game.Monster.CurHP -= damame;

            }

        }

        public override void Exit()
        {            

        }

    }
}
