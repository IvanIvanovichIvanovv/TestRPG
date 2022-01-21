using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items.Weapons
{
    public class Weapon : Item
    {
        protected double modifier;
        protected string type;

        public Weapon(string name, double modifier, int lvlRequirement, string type) : base(name, lvlRequirement)
        {
            this.modifier = modifier;
        }
        public double GetModifier()
        {
            return modifier;
        }
        public string GetType()
        {
            return type;
        }
    }
}
