using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    // 텍스트 알피지의 열거형만을 담아두는 cs파일.
    
    // 사용될 씬 클래스의 유형
    public enum SceneType { Title, Select, Town, Shop, Storage, Battle, GameOver, SIZE };

    // 사용될 플레이어 클래스의 유형
    public enum Job { Warrior=1, Mage, Rogue, Archor, SIZE };

    // 사용될 몬스터 클래스의 유형
    public enum MonsterType { Orc, Goblin, Slime, SIZE };

    // 아이템의 타입
    public enum ItemType { Potion, LootOrc, LootGoblin, LootSlime, Equipment, Weapon, SIZE }


}
