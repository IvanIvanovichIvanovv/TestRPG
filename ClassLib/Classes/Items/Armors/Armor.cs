using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items.Armors
{
    public class Armor : Item
    {
        protected int armor;

        public Armor(string name, int armor, int lvlRequirement) : base(name, lvlRequirement)
        {
            this.armor = armor;
         }
    }
}
