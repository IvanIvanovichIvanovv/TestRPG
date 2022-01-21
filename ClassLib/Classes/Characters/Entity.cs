using ClassLib.Classes.Items;
using ClassLib.Classes.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLib.Classes
{
    public abstract class Entity
    {
        #region properties
        protected string _name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value != "")
                {
                    this._name = value;
                }
            }
        }
        protected double _healthPoints
        {
            get
            {
                return this._healthPoints;
            }
            set
            {
                if (value > 0)
                {
                    this._healthPoints = value;
                }
            }
        }
        protected int _gold
        {
            get
            {
                return this._gold;
            }
            set
            {
                if (value > 0)
                {
                    this._gold = value;
                }
            }
        }
        protected int _level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }

        #region staty
        protected int _strength
        {
            get
            {
                return this._strength;
            }
            set
            {
                if (value > 0)
                {
                    this._strength = value;
                }
            }
        }
        protected int _dexterity
        {
            get
            {
                return this._dexterity;
            }
            set
            {
                if (value > 0)
                {
                    this._dexterity = value;
                }
            }
        }
        protected int _intelligence
        {
            get
            {
                return this._intelligence;
            }
            set
            {
                if (value > 0)
                {
                    this._intelligence = value;
                }
            }
        }
        protected int _charisma
        {
            get
            {
                return this._charisma;
            }
            set
            {
                if (value > 0)
                {
                    this._charisma = value;
                }
            }
        }
        protected int _endurance
        {
            get
            {
                return this._endurance;
            }
            set
            {
                if (value > 0)
                {
                    this._endurance = value;
                }
            }
        }
        protected double _maxHealthPoints
        {
            get
            {
                return this._maxHealthPoints;

            }
            set
            {
                if (value > 0)
                {
                    this._maxHealthPoints = value;
                }
            }
        }
        #endregion

        List<Item> _equipInvetory = new List<Item>();
        protected Weapon _weapon;
        #endregion 

        public Entity(string name, int gold, int strength, int dexterity, int intelligence, int charisma, int endurance, double maxHealthPoints, int level, Weapon weapon)
        {
            if (name != "")
            {
                this._name = name;
            }
            if (maxHealthPoints > 0)
            {
                this._maxHealthPoints = maxHealthPoints;
                this._healthPoints = maxHealthPoints;
            }
            if (weapon != null)
            {
                this._weapon = weapon;
            }
            else
            {
                Weapon hands = new Weapon("bare hands", 1, 1);
                this._weapon = hands;
            }

            int[] statTable = new int[6] { strength, dexterity, intelligence, charisma, endurance, level };
            int[] _statTable = new int[6] { _strength, _dexterity, _intelligence, _charisma, _endurance, _level };

            for (int i = 0; i < statTable.Length; i++)
            {
                if (statTable[i] > 0)
                {
                    _statTable[i] = statTable[i];
                }
            }
        }
        public bool LifeCheck()
        {
            if (this._healthPoints > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetDexterity() { return _dexterity; }
        public int GetIntelligence() { return _intelligence; }
        public int GetLevel() { return _level; }
        public void SubtractHealthPoints(int Amount)
        {
            _healthPoints -= Amount;
            if (!this.LifeCheck()) { this.Death(); }     
        }
        public void Death() { }
        public double GetHealth() { return this._healthPoints; }
        public int GetStrength() { return _strength; }
        public int GetCharisma() { return _charisma; }
        public int GetEndurance() { return _endurance; }

        public Weapon GetWeapon() { return _weapon; }
    }
}
