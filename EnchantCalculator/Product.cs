namespace EnchantCalculator
{
    class Product
    {
        public Product(string name, int basePAttack, int baseMAttack, int sortOfPWeapon, double blessOrSimple)
        {
            Name = name;
            BasePAttack = basePAttack;
            BaseMAttack = baseMAttack;
            SortOfPWeapon = sortOfPWeapon;
            
            BlessOrSimple = blessOrSimple;
        }

        public string Name { get; set; } //имя предмета, отображается в выпадающем комбобоксе
        public int BaseMAttack { get; set; }
        public int BasePAttack { get; set; } //базовая патака оружия
        public int SortOfPWeapon { get; set; } //имеет 3 вида, используется для определения базовой прибавки при модификации
        //public int SortOfMWeapon { get; set; }
        public double BlessOrSimple { get; set; } //имеет величину 1 или 1.5, является коэффициентом базовой прибавки

    }
}
