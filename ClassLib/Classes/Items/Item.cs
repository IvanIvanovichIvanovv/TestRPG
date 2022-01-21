using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items
{
    public abstract class Item
    {
        protected string _name { get; set; }  = "no_item"

        public Item(string name)
        {
            if (name != "")
            {
                this._name = name;  
            }
        }
    }
}
