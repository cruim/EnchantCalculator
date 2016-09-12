
namespace EnchantCalculator
{
    class Armor
    {
        public Armor(string name, int basePDeff, double blessOrSimple)
        {
            Name = name;
            BasePDef = basePDeff;
            BlessOrSimple = blessOrSimple;
        }

        public string Name { get; set; } //имя предмета, отображается в выпадающем комбобоксе
        public int BasePDef { get; set; } //базовая защита доспеха
        public double BlessOrSimple { get; set; } //имеет величину 1 или 1.5, является коэффициентом базовой прибавки

    }
}

