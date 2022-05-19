using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodawanieItemuKindlegemmTylkoHP
{
    public class RubyCrystal : Item
    {
        public RubyCrystal()
        {
            name = "Ruby Crystal";
            price = 400;
            AddStat(Stat.HP, 150);
        }
    }
}