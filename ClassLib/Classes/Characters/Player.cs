using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    public class Player : Entity
    {
        protected double _experiencePoints
        {
            get
            {
                return this._experiencePoints;
            }
            set
            {
                if (value >= 0)
                {
                    this._experiencePoints = value;
                }
            }
        }
        public Player(string name, int gold, int strength, int dexterity, int intelligence, int charisma, int endurance, double maxHealthPoints, int level,double experiencePoints) : base(name, gold, strength, dexterity, intelligence, charisma, endurance, maxHealthPoints,level)
        {
            if (experiencePoints >= 0) 
            {
                this._experiencePoints=experiencePoints;
            }
        }
        public string[] PlayerData()
        {
            string[] playerData = new string[11];
            playerData[0] = $"Name,{_name}";
            playerData[1] = $"HealthPoints,{_healthPoints}";
            playerData[2] = $"Gold,{_gold}";
            playerData[3] = $"Strength,{_strength}";
            playerData[4] = $"Dexterity,{_dexterity}";
            playerData[5] = $"Intelligence,{_intelligence}";
            playerData[6] = $"Charisma,{_charisma}";
            playerData[7] = $"Endurance,{_endurance}";
            playerData[8] = $"MaxHealthPoints,{_maxHealthPoints}";
            playerData[9] = $"Level,{_level}";
            playerData[10] = $"ExperiencePoints,{_experiencePoints}";
            return playerData;
        }
        public void CheckLevelUp() 
        {
            int n = _level+10;
            int number = n - 1; //Need to decrement by 1 since we are starting from 0  
            double[] Fib = new double[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Math.Round(Fib[i - 2] + (100 - 2 * i) * Fib[i - 1] / 100);
            }
            if (_experiencePoints >= Fib[n + 1]) 
            {
                _experiencePoints=-Fib[n + 1];
                _level++;
            }
        }
        public void AddExp(double Exp) 
        {
            _experiencePoints += Exp;
            CheckLevelUp();
        }


    }
}
