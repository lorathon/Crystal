using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crystal
{
    public class Character
    {
        public string Name { get; set; }

        public Character_Race Race { get; set; }

        public Character_Class Class { get; set; }


        public int Level { get; set; }

        public int Experience { get; set; }


        public int Strength { get; set; }        

        public int Constitution { get; set; }        

        public int Dexterity { get; set; }        

        public int Intelligence { get; set; }        

        public int Wisdom { get; set; }        

        public int Charisma { get; set; }


        public string Test { get; set; }

        


        public int Strength_Mod 
        {
            get
            {
                return this.Class.Strength_Mod + this.Race.Strength_Mod;
            }
        }

        public int Constitution_Mod 
        {
            get
            {
                return this.Class.Constitution_Mod + this.Race.Constitution_Mod;
            }
        }

        public int Dexterity_Mod 
        {
            get
            {
                return this.Class.Dexterity_Mod + this.Race.Dexterity_Mod;
            }
        }

        public int Intelligence_Mod 
        {
            get
            {
                return this.Class.Intelligence_Mod + this.Race.Intelligence_Mod;
            }
        }

        public int Wisdom_Mod 
        {
            get
            {
                return this.Class.Wisdom_Mod + this.Race.Wisdom_Mod;
            }
        }

        public int Charisma_Mod 
        {
            get
            {
                return this.Class.Charisma_Mod + this.Race.Charisma_Mod;
            }
        }

    }
}
