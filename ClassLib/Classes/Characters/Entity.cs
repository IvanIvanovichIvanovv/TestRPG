namespace ClassLib.Classes
{
    public abstract class Entity
    {
        protected string _name { get; set if (value != "") { this = value }; } = "no_name";
        protected double _healthPoints { get; set if (value > 0) { this = value }; } = 0;
        protected int _gold { get; set; } = 0;

        #region staty
        protected int _strength { get; set if (value > 0) { this = value }; } = 1;
        protected int _dexterity { get; set if (value > 0) { this = value }; } = 1;
        protected int _intelligence { get; set if (value > 0) { this = value }; } = 1;
        protected int _charisma { get; set if (value > 0) { this = value }; } = 1;
        protected int _endurance { get; set if (value > 0) { this = value }; } = 1;
        protected double _maxHealthPoints { get; set if (value > 0) { this = value }; } = 1;
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
