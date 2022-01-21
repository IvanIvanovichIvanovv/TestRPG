using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items.Armors
{
    public class HandArmor : Armor
    {
        protected string _description { get; set; }
        public HandArmor(string name, int armor, int lvlRequirement, string description) : base(name, armor, lvlRequirement)
        {
            if (description != "")
            {
                _description = description;
            }
        }
    }
}
