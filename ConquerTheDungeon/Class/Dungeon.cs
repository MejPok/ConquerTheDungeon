using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquerTheDungeon.Class
{
    public class Dungeon
    {
        public int floor { get; set; }
        public Dungeon(int floor = 0)
        {
            this.floor = floor;
        }
    }
}
