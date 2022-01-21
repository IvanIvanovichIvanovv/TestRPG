using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Events
{
    public class HostileEncounter:Event
    {
        public void Fight() 
        {

        }
        public bool Escape() 
        {
            int playerEscapeStats = 2 * this._player.GetIntelligence() + 3 * this._player.GetDexterity();
            int NPCCatchStats=2*this._NPC.GetIntelligence()+2*this._NPC.GetDexterity()+this._NPC.GetLevel();
            if (playerEscapeStats - NPCCatchStats >= 0) 
            {
                int StatDiff=playerEscapeStats - NPCCatchStats;
                int EscapeChance = StatDiff * 15;
                Random r = new Random();
                if (r.Next(0, 100) <= EscapeChance) 
                {
                    return true;
                }
                this._player.SubtractHealthPoints(5);
                return false;
            }
            else
            {
                this._player.SubtractHealthPoints(5);
                return false;
            }
        }
        public HostileEncounter(Player player, Entity NPC) : base(player, NPC) 
        {

        }
    }
}
