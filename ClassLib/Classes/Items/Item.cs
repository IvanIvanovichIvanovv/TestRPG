using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items
{
    public abstract class Item
    {
        protected string _name { get; set; } = "no_item";
        protected int _lvlRequirement { get; set; }
        public Item(string name, int lvlRequirement)
        {
            if (name != "")
            {
                this._name = name;  
            }
            if (lvlRequirement > 0)
            {
                _lvlRequirement = lvlRequirement;
            }
        }
    }
}
