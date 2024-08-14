using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    // 텍스트 알피지의 열거형만을 담아두는 클래스.
    internal class Enum
    {
        // 사용될 씬 클래스의 유형
        public enum SceneType { Title, Select, Town, Shop, Inventory, Battle, GameOver, SIZE };

        // 사용될 플레이어 클래스의 유형
        public enum Job { Warrior, Mage, Rogue, Archor, SIZE };


    }
}
