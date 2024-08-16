namespace TextRPG
{
    internal class Program
    {
        // 아이템 구매에서 소지금액에 따른 예외처리 필요
        // 아이템 구매에서 직업 분류에 따른 예외처리 필요
        // 아이템 구매에서 구매 여부에 따른 예외처리 필요
        // 플레이어 <-> 몬스터간 전투에서 공격력&방어력 계산식에서 마이너스값 예외처리 필요

        static void Main(string[] args)
        {
            // 게임 가동하기
            Game game = new Game();
            game.Run();


        }
    }
}
