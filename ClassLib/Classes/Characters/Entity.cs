namespace ClassLib.Classes
{
    public class Entity
    {
        private string _name { get; set; } = "no_name";
        private double _healthPoints { get; set; } = 0;
        private int _gold { get; set; } = 0;

        #region staty
        private int _strength { get; set; } = 1;
        private int _dexterity { get; set; } = 1;
        private int _intelligence { get; set; } = 1;
        private int _charisma { get; set; } = 1;
        private int _endurance { get; set; } = 1;
        private double _maxHealthPoints { get; set; } = 1;

        #endregion
        
        public Entity(string name, int gold, int strength, int dexterity, int intelligence, int charisma, int endurance, double maxHealthPoints)
        {
            if (name != null)
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
