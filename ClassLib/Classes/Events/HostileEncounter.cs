using ClassLib.Classes.Items;
using ClassLib.Classes.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes.Events
{
    public class HostileEncounter:Event
    {
        public void Fight(int action) 
        {
            if (this._player.LifeCheck() && this._NPC.LifeCheck() )
            {
                // 1. Dodge
                // 2. Block
                // 3. Charge
                // 4. Attack
                // 5. Escape
                switch (action)
                {
                    case 1: dodgeAction(); break;
                    case 2: blockAction(); break;
                    case 3: chargeAction(); break;
                    case 4: attackAction(); break;
                    case 5:
                    default: Escape(); break;
                }


            }
        }
        protected void dodgeAction()
        {
            double playerDodge = 2 * this._player.GetDexterity() + 0.5 * this._player.GetIntelligence();
            double NPCattack = 0.5 * this._NPC.GetIntelligence() + 2 * this._NPC.GetDexterity();
            double dodgeDiff = playerDodge - NPCattack;
            Random r = new Random();
            if (dodgeDiff >= 0)
            {
                if (dodgeDiff * 10 <= r.Next(0, 100))
                {
                    // dodge succesful
                    // TODO
                }
                else
                {
                    // TODO: calculate dmg
                }
            }
        }
        protected void blockAction() { }
        protected void chargeAction() { }
        protected void attackAction() { }
        protected double calculateDamage(Entity opressor)
        {
            Weapon weapon = opressor.GetWeapon();
            double attackDamage = 1;
            if (weapon != null)
            {
                if (weapon.GetType() == "dexterity")
                {
                    attackDamage = weapon.GetModifier() * (opressor.GetDexterity() * 2);
                }
                else if (weapon.GetType() == "strength")
                {
                    attackDamage = weapon.GetModifier() * (opressor.GetStrength() * 3);
                }
                else
                {
                    attackDamage = weapon.GetModifier() * (opressor.GetDexterity() + opressor.GetStrength());
                }
            }
            return attackDamage;
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
