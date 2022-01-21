using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    public class NPC : Entity
    {
        public NPC(string name, int gold, int strength, int dexterity, int intelligence, int charisma, int endurance, double maxHealthPoints,int level) : base(name, gold, strength, dexterity, intelligence, charisma, endurance, maxHealthPoints,level)
        {
        }
    }
}
