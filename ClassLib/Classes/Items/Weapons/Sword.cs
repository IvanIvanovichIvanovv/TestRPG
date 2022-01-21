using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items.Weapons
{
    public class Sword : Weapon
    {
        protected string _description { get; set; }
        protected string _type { get; set; }
        public Sword(string name, double modifier, int lvlRequirement, string description, string type) : base(name, modifier, lvlRequirement, type="dexterity")
        {
            if (description != "")
            {
                _description = description;
            }
            if (type != "")
            {
                _type = type;
            }
        }
    }
}
