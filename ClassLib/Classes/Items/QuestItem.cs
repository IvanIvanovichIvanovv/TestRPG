using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items
{
    public class QuestItem : Item
    {
        protected string _description { get { return this._description; } set { if (value != "") { this._description = value; } } }
        public QuestItem(string description, string name, int lvlRequirement) : base(name, lvlRequirement)
        {
            if (description != "")
            {
                this._description = description;
            }
        }
    }
}
