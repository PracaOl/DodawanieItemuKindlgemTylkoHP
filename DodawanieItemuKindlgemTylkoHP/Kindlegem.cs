using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodawanieItemuKindlegemmTylkoHP
{
    public class Kindlegem : Item
    {
        public Kindlegem()
        {
            name = "Kindlegem";
            price = 800;
            AddStat(Stat.HP, 200);
        }
    }
}