using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Items
{
    public class Consumable : Item
    {
        protected string _description { get; set if (value != "") { this = value }; }
        protected double _healthPointsValue { get; set if (value > 0) { this = value }; }

        public Consumable(string description, double healthPointsValue)
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
