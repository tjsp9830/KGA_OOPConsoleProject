using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class I4_Inventory
    {

        public List<I0_Item> slots = new();

        // 획득
        public void UpdateItem(I0_Item item)
        {
            slots.Add(item);
        }

        public void RemoveAllItem()
        {
            slots.Clear();
            //slots.RemoveAll();
        }

        // 삭제
        public void RemoveItem(int index)
        {
            slots.RemoveAt(index);
        }

        // 출력
        public void ShowInventory()
        {
            if (slots.Count == 0)
            {
                Console.WriteLine("현재 인벤토리가 비어있습니다.");
            }
            else
            {
                Console.WriteLine("------- 현재 인벤토리 -------");

                for (int i = 0; i < slots.Count; i++)
                {
                    Console.WriteLine($" {i + 1}. {slots[i].Name} ");
                    //현재는 똑같은 아이템이라도 갯수 중복이 안되는 상태, 추후 (갯수: {}개) 형태로 겹치기
                }
            }
            Console.WriteLine("==========================");
            Console.WriteLine();
        }



    }
    //public class Item
    //{
    //    List<I4_Inventory> items;

    //    public int itemCount => items.Count;

    //    public Item()
    //    {
    //        items = new List<I4_Inventory>(10);
    //    }


    //    public void ShowInventory()
    //    {

    //        if (items.Count == 0)
    //        {
    //            Console.WriteLine("현재 인벤토리가 비어있습니다.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("------- 현재 인벤토리 -------");

    //            for (int i = 0; i < items.Count; i++)
    //            {
    //                Console.WriteLine($" {i + 1}. {items[i].name}");
    //            }
    //        }
    //        Console.WriteLine("==========================");
    //        Console.WriteLine();
    //    }

    //    public bool UpdateItem(I4_Inventory _item)
    //    {
    //        if (items.Count == 10)
    //            return false;

    //        items.Add(_item);
    //        return true;
    //    }

    //    public bool RemoveItem(int _index)
    //    {
    //        if (items.Count <= _index)
    //            return false;

    //        items.RemoveAt(_index);
    //        return true;
    //    }


    //}


}


