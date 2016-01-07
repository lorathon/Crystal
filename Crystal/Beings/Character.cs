using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crystal
{
    public class Character
    {

        /// <summary>
        /// This will set character back to
        /// a "beginning" state.
        /// </summary>
        public void Initialize_Character()
        {
            this.health_current = this.Health_Maximum;
            this.stamina_current = this.Stamina_Maximum;
            this.speed_current = this.Speed_Maximum;
        }



        public string Name { get; set; }

        public Character_Race Race { get; set; }

        public Character_Class Class { get; set; }

        #region Experience

        public int Level { get; set; }

        public int Experience_Current { get; set; }

        public void IncreaseExperience(int points)
        {
            this.Experience_Current += points;

            check_level();
        }

        private void check_level()
        {


        }

        #endregion


        #region Health

        /// <summary>
        /// Base Character health
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// This is a temporary
        /// boost of health
        /// </summary>
        public int Health_Temp { get; set; }

        /// <summary>
        /// Maximum of all health attributes
        /// </summary>
        public int Health_Maximum 
        {
            get
            {
                return this.Health +
                    this.Race.Health_Mod +
                    this.Class.Health_Mod;
            }
        }

        /// <summary>
        /// Returns current health of character
        /// any temporary boosts are added.
        /// </summary>
        private int Health_Current
        {
            get
            {
                return this.health_current +
                    this.Health_Temp;
            }
        }

        private int health_current { get; set; }

        public bool IsAlive
        {
            get
            {
                if (this.Health_Current > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Inflict damage to character
        /// check for is alive state
        /// </summary>
        /// <param name="points">int - amount of damage done to character</param>
        /// <returns>bool - Is Alive or Not</returns>
        public bool ReduceHealth(int points)
        {
            this.health_current -= points;
            return this.IsAlive;
        }

        /// <summary>
        /// Heal damage to character
        /// check for is alive state
        /// check for maximum health
        /// </summary>
        /// <param name="points">int - amount of healing point</param>
        /// <returns>bool - Is Alive or Not</returns>
        public bool IncreaseHealth(int points)
        {
            int _x = this.health_current + points;

            if (_x > this.Health_Maximum)
                _x = this.Health_Maximum;

            this.health_current = _x;

            return this.IsAlive;
        }

        #endregion


        #region Stamina

        public int Stamina { get; set; }

        public int Stamina_Temp { get; set; }

        public int Stamina_Maximum
        {
            get
            {
                return this.Stamina +
                    this.Race.Stamina_Mod +
                    this.Class.Stamina_Mod;
            }
        }

        public int Stamina_Current
        {
            get
            {
                return this.stamina_current +
                    this.Stamina_Temp;
            }
        }

        private int stamina_current { get; set; }

        public bool IsTired
        {
            get
            {
                if (this.Stamina_Current < (this.Stamina_Maximum * .25))
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Reduce stamina of character
        /// check for is tired state
        /// </summary>
        /// <param name="points">int - amount of stamina reduction</param>
        /// <returns></returns>
        public bool ReduceStamina(int points)
        {
            this.Stamina -= points;
            return this.IsTired;
        }

        /// <summary>
        /// Increase stamina of character
        /// check for is tired state
        /// check for maximum stamina
        /// </summary>
        /// <param name="points">int - amount of stamina increase</param>
        /// <returns>bool - Is Tired or Not</returns>
        public bool IncreaseStamin(int points)
        {
            int _x = this.stamina_current += points;

            if (_x > this.Stamina_Maximum)
                _x = this.Stamina_Maximum;

            this.stamina_current = _x;
            return this.IsTired;
        }

        #endregion


        #region Speed

        public int Speed { get; set; }

        public int Speed_Temp { get; set; }

        public int Speed_Maximum { get; set; }

        public int Speed_Current 
        {
            get
            {
                return this.speed_current +
                    this.Speed_Temp;
            }
        }

        private int speed_current { get; set; }

        public bool IsFrozen 
        {
            get
            {
                if (Speed_Current <= 0)
                    return true;
                else
                    return false;
            }
        }

        public bool ReduceSpeed(int points)
        {
            this.speed_current -= points;
            return this.IsFrozen;
        }

        public bool IncreaseSpeed(int points)
        {
            int _x = this.speed_current + points;

            if (_x > this.Speed_Maximum)
                _x = this.Speed_Maximum;

            this.speed_current = _x;

            return this.IsFrozen;
        }

        #endregion




        public int Strength { get; set; }        

        public int Constitution { get; set; }        

        public int Dexterity { get; set; }        

        public int Intelligence { get; set; }        

        public int Wisdom { get; set; }        

        public int Charisma { get; set; }        


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
