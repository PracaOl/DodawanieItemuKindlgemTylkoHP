using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodawanieItemuKindlegemmTylkoHP
{
    class Garen : Champion
    {
        public Garen()
        {
            name = "Garen";
            hp = 620;
            Console.WriteLine("Konstruktor klasy Garen");
        }
        public void ctrl3()
        {
            Console.WriteLine("Garen tańczy!");
        }


    }
}