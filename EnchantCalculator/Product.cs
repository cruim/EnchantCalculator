

using System.Collections.Generic;

namespace EnchantCalculator
{
    class Product
    {
        public Product(string name, int baseAttack, int sortOfWeapon, double blessOrSimple)
        {
            Name = name;
            BaseAttack = baseAttack;
            SortOfWeapon = sortOfWeapon;
            BlessOrSimple = blessOrSimple;
        }

        public string Name { get; set; } //имя предмета, отображается в выпадающем комбобоксе
        public int BaseAttack { get; set; } //базовая патака оружия
        public int SortOfWeapon { get; set; } //имеет 3 вида, используется для определения базовой прибавки при модификации
        public double BlessOrSimple { get; set; } //имеет величину 1 или 1.5, является коэффициентом базовой прибавки


        //List<Product> listOfWeapon = new List<Product>
        //{
        //    new Product("Благословенное Возмездие Апокалипсиса", 505, 7, 1.5)
        //};
    }
}
