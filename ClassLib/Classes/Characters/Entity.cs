namespace ClassLib.Classes
{
    public abstract class Entity
    {
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
        protected int _gold { get; set; }

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

        public Entity(string name, int gold, int strength, int dexterity, int intelligence, int charisma, int endurance, double maxHealthPoints)
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

            int[] statTable = new int[5] { strength, dexterity, intelligence, charisma, endurance };
            int[] _statTable = new int[5] { _strength, _dexterity, _intelligence, _charisma, _endurance };

            for (int i = 0; i < statTable.Length; i++)
            {
                if (statTable[i] > 0)
                {
                    _statTable[i] = statTable[i];
                    //cimcirymci
                }
            }
        }
    }
}
