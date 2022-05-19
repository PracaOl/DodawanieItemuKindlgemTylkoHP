using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodawanieItemuKindlegemmTylkoHP
{
    public enum Stat
    {
        HP,
        AP,
        AD
    }
    public class Item
    {
        public string name;
        public int price;
        Dictionary<Stat, float> stats;
        public Item()
        {
            name = "";
            price = 0;
            stats = new Dictionary<Stat, float>();

        }
        public void AddStat(Stat name, float value)
        {
            stats.Add(name, value);
        }
        public float GetStat(Stat name)
        {
            if (stats.ContainsKey(name))
            {
                return stats[name];
            }
            else
            {
                return 0;
            }
        }
    }
}
