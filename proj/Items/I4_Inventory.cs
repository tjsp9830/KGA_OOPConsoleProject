using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class I4_Inventory
    {
        public string name;
        public I4_Inventory(string _name)
        {
            name = _name;
        }


    }


    public class Inventory
    {
        List<I4_Inventory> items;

        public int itemCount => items.Count;

        public Inventory()
        {
            items = new List<I4_Inventory>(10);
        }


        public void ShowInventory()
        {

            if (items.Count == 0)
            {
                Console.WriteLine("현재 인벤토리가 비어있습니다.");
            }
            else
            {
                Console.WriteLine("------- 현재 인벤토리 -------");

                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($" {i + 1}. {items[i].name}");
                }
            }
            Console.WriteLine("==========================");
            Console.WriteLine();
        }

        public bool UpdateItem(I4_Inventory _item)
        {
            if (items.Count == 10)
                return false;

            items.Add(_item);
            return true;
        }

        public bool RemoveItem(int _index)
        {
            if (items.Count <= _index)
                return false;

            items.RemoveAt(_index);
            return true;
        }


    }


}


