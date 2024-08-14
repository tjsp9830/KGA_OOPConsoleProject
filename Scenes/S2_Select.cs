using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    internal class S2_Select
    {
        // 필드 - 상태 이넘, 생성자 - 기존의 것을 계속 씀.엔터(), 인풋(), 렌더(), 업뎃() 있음

        // 메서드,
        // 엔터()에서 curState에 이넘.Name 넣어줌.
        // 인풋()에서 입력내용 받아옴
        // 업뎃()에서 curState에 들어가있는 이넘이 뭔지 검사, 예외처리 거친 후에 입력받은 string을 해당 이넘 요소에 알맞게 넣어주고, 이넘 내용을 다음 State로 넘겨줌.캐릭터 생성 완료(성공) 시 타운씬ㄱ
        // 렌더()에서 curState가 이름, 직업, 확인 중에서 뭔지에 따라 안내멘트 출력. 

    }
}
