using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    public class Player : Entity
    {
        public Player(string name, int gold, int strength, int dexterity, int intelligence, int charisma, int endurance, double maxHealthPoints) : base(name, gold, strength, dexterity, intelligence, charisma, endurance, maxHealthPoints)
        {
        }
    }
}
