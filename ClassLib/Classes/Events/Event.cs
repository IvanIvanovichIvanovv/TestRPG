using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Events
{
    public abstract class Event
    {
        protected Player _player { get; set; } //Player
        protected Entity _NPC { get; set; }

        public Event(Player player, Entity NPC) 
        {
            this._player= player;
            this._NPC = NPC;    
        }
    }
}
