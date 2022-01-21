using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items
{
    public class Consumable : Item
    {
        protected string _description { get { return this._description; } set { if (value != "") { this._description = value; } } }
        protected double _healthPointsValue { get { return this._healthPointsValue; } set { if (value > 0) { this._healthPointsValue = value; }; } }

        public Consumable(string description, double healthPointsValue, string name, int lvlRequirement) : base(name, lvlRequirement)
        {
            if (description != "")
            {
                this._description = description;
            }
            if (_healthPointsValue > 0)
            {
                _healthPointsValue = healthPointsValue;
            }
        }
    }
}
