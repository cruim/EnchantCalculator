using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EnchantCalculator;

namespace EnchantCalculator
{
    public partial class Form1 : Form
    {
        private static int x;

        List<Product> listOfWeapon = new List<Product>
            {
                new Product("Благословенное Возмездие Апокалипсиса", 505, 7, 1.5)
            };


        public Form1()
        {
            InitializeComponent();
            comboBoxOfWeapon.DataSource = listOfWeapon;
            comboBoxOfWeapon.DisplayMember = nameof(Product.Name);
            comboBoxOfWeapon.ValueMember = nameof(Product.SortOfWeapon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            EnchantFunction(ref x);
            var selectedItem = (Product)comboBoxOfWeapon.SelectedItem;
            int baseAttack = selectedItem.BaseAttack;
            int y = baseAttack + x; //базовое значение + изменения от модификации
            textBox1.Text = y.ToString();
            x = 0;

        }

        public void EnchantFunction(ref int g)
        {
            int countOfEnchant = Convert.ToInt32(comboBoxCountOfEnchant.SelectedItem); //уровень модификации

            var selectedItem = (Product)comboBoxOfWeapon.SelectedItem; //переменная, с помощью которой обращаемся к полям коллекции
            
            int oneClickEnchant = (int) Math.Ceiling(selectedItem.SortOfWeapon * selectedItem.BlessOrSimple); //базовая прибавка
            
            
            int countOfIteration = 1; //счетчик, позволяющий прервать цикл при countOfIteration > countOfEnchant



            for (int i = 1; i <= countOfEnchant; i++) //i - увеличивает коэффициент каждого четвертого шага на 1
            {
                for (int j = 0; j < 3; j++)
                {
                    if (countOfIteration > countOfEnchant)
                    {
                        return;
                    }

                    g = g + oneClickEnchant * i;
                    countOfIteration++;

                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }

}
