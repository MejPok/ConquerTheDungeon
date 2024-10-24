using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquerTheDungeon.Class
{
    public class Player
    {
        public int Hitpoints { get; set; }
        public int Strength { get; set; }

        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Endurance { get; set; }

        public Player(
            int Hitpoints = 10,
            int Strength = 1,
            int Agility = 1,
            int Intelligence = 1,
            int Endurance = 1
            ) 
        {
            this.Hitpoints = Hitpoints;
            this.Strength = Strength;
            this.Agility = Agility;
            this.Intelligence = Intelligence;
            this.Endurance = Endurance;
        
        }

    }
}
