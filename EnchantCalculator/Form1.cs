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
            this.comboBoxOfWeapon.DataSource = listOfWeapon;
            this.comboBoxOfWeapon.DisplayMember = nameof(Product.Name);
            comboBoxOfWeapon.ValueMember = nameof(Product.BaseAttack);
            comboBoxOfWeapon.ValueMember = nameof(Product.SortOfWeapon);
            //comboBoxOfWeapon.ValueMember = nameof(Product.BlessOrSimple);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            EnchantFunction(ref x);
            textBox1.Text = x.ToString() + comboBoxOfWeapon;
            x = 0;

        }

        public void EnchantFunction(ref int g)
        {
            int countOfEnchant = Convert.ToInt32(comboBoxCountOfEnchant.SelectedItem);

            //int baseAttack = Convert.ToInt32(comboBoxOfWeapon.SelectedItem);

            int oneClickEnchant = Convert.ToInt32(comboBoxOfWeapon.SelectedValue); //базовая прибавка

            int countOfIteration = 1;



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
