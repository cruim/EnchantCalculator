using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using EnchantCalculator;

namespace EnchantCalculator
{
    public partial class Form1 : Form
    {
        private static int x;
        private static int z;

        #region Collection

        List<Product> listOfWeapon = new List<Product>
        {
            new Product("Благословенное Возмездие Апокалипсиса", 505, 332, 7, 1.5),
            //new Product("Благословенное Возмездие Реквиема", 436, 7, 1.5),
            //new Product("Благословенное Острие Апокалипсиса", 454, 6, 1.5),
            //new Product("Благословенное Острие Реквиема", 392, 6, 1.5),
            //new Product("Благословенные Парные Дубины Апокалипсиса", 632, 7, 1.5),
            //new Product("Благословенные Парные Дубины Реквиема", 545, 7, 1.5),
            //new Product("Благословенные Парные Кинжалы Апокалипсиса", 519, 7, 1.5),
            //new Product("Благословенные Парные Кинжалы Реквиема", 448, 7, 1.5),
            //new Product("Благословенные Парные Мечи Апокалипсиса", 632, 7, 1.5),
            //new Product("Благословенные Парные Мечи Реквиема", 545, 7, 1.5),
            new Product("Баагословенная Бросок Апокалипсиса", 1022, 226, 12, 1.5),
            //new Product("Благословенный Бросок Реквиема", 882, 12, 1.5),
            //new Product("Благословенный Буревестник Апокалипсиса", 519, 6, 1.5),
            //new Product("Благословенный Буревестник Реквиема", 448, 6, 1.5),
            //new Product("Благословенный Воитель Апокалипсиса", 632, 7, 1.5),
            //new Product("Благословенный Воитель Реквиема", 545, 7, 1.5),
            #endregion

        };



        public Form1()
        {
            

            InitializeComponent();
            var result = listOfWeapon.OrderBy(point => point.Name).ToList();
            comboBoxOfWeapon.DataSource = result;



            comboBoxOfWeapon.DisplayMember = nameof(Product.Name);

            comboBoxOfWeapon.ValueMember = nameof(Product.SortOfPWeapon);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EnchantFunction(ref x, ref z);
            var selectedItem = (Product)comboBoxOfWeapon.SelectedItem;
            int basePAttack = selectedItem.BasePAttack;
            int baseMAttack = selectedItem.BaseMAttack;
            int finalPAttack = basePAttack + x; //базовое значение физ.атаки + изменения от модификации
            int finalMAttack = baseMAttack + z;
            textBox1.Text = selectedItem.Name + " " + comboBoxCountOfEnchant.SelectedItem + " " + "Физ.Атака равна" +
                            " "
                            + finalPAttack + " " + "Магическая Атака равна" + " " + finalMAttack;
            x = 0;
            z = 0;

        }

        public void EnchantFunction(ref int g, ref int k)
        {
            int countOfEnchant = Convert.ToInt32(comboBoxCountOfEnchant.SelectedItem); //уровень модификации

            var selectedItem = (Product)comboBoxOfWeapon.SelectedItem; //переменная, с помощью которой обращаемся к полям коллекции

            int oneClickEnchantPAttack = (int)Math.Ceiling(selectedItem.SortOfPWeapon * selectedItem.BlessOrSimple); //базовая прибавка патаки

            int oneClickEnchantMAttack = (int)Math.Ceiling(5 * selectedItem.BlessOrSimple); //базовая прибавка матаки
            
            int countOfIteration = 1; //счетчик, позволяющий прервать цикл при countOfIteration > countOfEnchant



            for (int i = 1; i <= countOfEnchant; i++) //i - увеличивает коэффициент каждого четвертого шага на 1
            {
                for (int j = 0; j < 3; j++)
                {
                    if (countOfIteration > countOfEnchant)
                    {
                        return;
                    }

                    g = g + oneClickEnchantPAttack * i;
                    k = k + oneClickEnchantMAttack * i;
                    countOfIteration++;

                }

            }
        }

    }
}
