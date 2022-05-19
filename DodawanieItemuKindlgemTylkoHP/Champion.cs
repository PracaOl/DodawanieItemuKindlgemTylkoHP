using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodawanieItemuKindlegemmTylkoHP
{

    class Champion
    {
        public string name;
        public float hp;
        public Item[] items;

        public Champion()
        {
            name = "";
            hp = 0;
            items = new Item[6];
            Console.WriteLine("Konstruktor klasy Champion");
        }
        public void buyItem(Item i)
        {
            Console.WriteLine(name.ToString() + " kupuje " + i.name.ToString());
            for (int j = 0; j < items.Length; j++)
            {
                if (items[j] == null)
                {
                    items[j] = i;
                    break;
                }
            }


        }
        public void showHP()
        {
            Console.WriteLine("Postać ma " + this.getHP().ToString() + "HP");
        }
        public float getHP()
        {
            float finalHp = hp;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                    finalHp += items[i].GetStat(Stat.HP);
            }
            return finalHp;

        }
    }
}

