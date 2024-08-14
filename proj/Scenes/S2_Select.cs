using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Players;

namespace TextRPG.Scenes
{
    internal class S2_Select : S0_Scene
    {
        // 필드 - State 열거형 선언{이름,직업,확인}, State 변수 curState 선언, string 인풋, string nameInput
        public enum State { Name, Job, Confirm }
        private State curState;

        string input;
        string nameInput;


        // 생성자 - 기존의 것을 계속 씀.
        public S2_Select(Game _game) : base(_game)
        {

        }


        // 메서드 - 엔터(), 인풋(), 렌더(), 업뎃() 있음

        // 엔터()에서 curState에 이넘.Name 넣어줌.
        // 인풋()에서 입력내용 받아옴
        // 업뎃()에서 curState에 들어가있는 이넘이 뭔지 검사, 예외처리 거친 후에 입력받은 string을 해당 이넘 요소에 알맞게 넣어주고, 이넘 내용을 다음 State로 넘겨줌.캐릭터 생성 완료(성공) 시 타운씬ㄱ
        // 렌더()에서 curState가 이름, 직업, 확인 중에서 뭔지에 따라 안내멘트 출력. 

        public override void Enter()
        {
            //이름부터 입력받기
            curState = State.Name;
        }

        public override void Render()
        {            

            if (curState == State.Name)
            {
                //이전 내용 지우기
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("플레이어의 이름을 입력해주세요: ");
                Console.ResetColor();
            }
            else if (curState == State.Job)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n플레이어의 직업을 선택해주세요.");
                Console.ResetColor();
                Console.WriteLine("1. 전사");
                Console.WriteLine("2. 마법사");
                Console.WriteLine("3. 도적");
                Console.WriteLine("4. 궁수");
                Console.Write("-----> 어떤 직업을 선택할까요?: ");
            }
            else if (curState == State.Confirm)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n플레이어의 정보를 확인해주세요.");
                Console.ResetColor();
                Console.WriteLine($"> 이름: {game.Player.Name}");
                Console.WriteLine($"> 직업: {game.Player.Job}");
                Console.WriteLine($"> 체력: {game.Player.MaxHP}");
                Console.WriteLine($"> 공격력: {game.Player.Power}");
                Console.WriteLine($"> 방어력: {game.Player.Defense}");                
                Console.WriteLine($"> 소지금: {game.Player.Gold}");                

                Console.Write("-----> 이대로 게임을 시작할까요?(y/n) : ");
            }

        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {
            // 이름 입력받는 차례일때
            if (curState == State.Name)
            {

                //입력받은 값이 없다면 리턴
                if (input == string.Empty)
                    return;

                //값이 정상적으로 입력되었다면 nameinput에 담아주고 현재 상태를 Job으로 넘김
                nameInput = input;
                curState = State.Job;
                            
            }
            // 직업 입력받는 차례일때
            else if (curState == State.Job)
            {

                //입력받은 값 input을 Job형태의 select로 변환하는데 실패했다면 리턴 (이넘의 글자로 값 검사)
                if (Job.TryParse(input, out Job select) == false)
                    return;
                
                //~~~~~~~~~~면 리턴 (이넘의 숫자로 값 검사)
                if (Enum.IsDefined(typeof(Job), select) == false)
                    return;

                //값이 정상적으로 입력되었다면 select에 담긴 값 판단
                switch (select)
                {
                    case Job.Warrior:
                        game.Player = new P1_Warrior(nameInput);
                        break;

                    case Job.Mage:
                        game.Player = new P2_Mage(nameInput);
                        break;

                    case Job.Rogue:
                        game.Player = new P3_Rogue(nameInput);
                        break;

                    case Job.Archor:
                        game.Player = new P4_Archor(nameInput);
                        break;

                }

                //현재 상태를 Job으로 넘김
                curState = State.Confirm;

            }
            // 상태 확인받는 차례일때
            else if (curState == State.Confirm)
            {
                switch (input)
                {
                    // 게임 시작을 위해 마을씬으로 이동
                    case "Y":
                    case "y":
                        game.SceneChanger(SceneType.Town);
                        break;

                    // 다시 이름부터 입력받음
                    case "N":
                    case "n":
                        curState = State.Name;
                        break;

                }

            }
              
        }

        public override void Exit()
        {
            
        }

    }
}
