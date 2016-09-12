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

        #region CollectionOfWeapon

        List<Weapon> listOfWeapon = new List<Weapon>
        {
            new Weapon("", 0, 0, 0, 0),
            new Weapon("Благословенное Возмездие Апокалипсиса", 505, 332, 7, 1.5),
            new Weapon("Благословенное Возмездие Реквиема", 436, 286, 7, 1.5),
            new Weapon("Благословенное Острие Апокалипсиса", 454, 226, 6, 1.5),
            new Weapon("Благословенное Острие Реквиема", 392, 195, 6, 1.5),
            new Weapon("Благословенные Парные Дубины Апокалипсиса", 632, 226, 7, 1.5),
            new Weapon("Благословенные Парные Дубины Реквиема", 545, 195, 7, 1.5),
            new Weapon("Благословенные Парные Кинжалы Апокалипсиса", 519, 226, 7, 1.5),
            new Weapon("Благословенные Парные Кинжалы Реквиема", 448, 7, 195, 1.5),
            new Weapon("Благословенные Парные Мечи Апокалипсиса", 632, 226, 7, 1.5),
            new Weapon("Благословенные Парные Мечи Реквиема", 545, 7, 195, 1.5),
            new Weapon("Благословенный Бросок Апокалипсиса", 1022, 226, 12, 1.5),
            new Weapon("Благословенный Бросок Реквиема", 882, 195, 12, 1.5),
            new Weapon("Благословенный Буревестник Апокалипсиса", 519, 226, 6, 1.5),
            new Weapon("Благословенный Буревестник Реквиема", 448, 195, 6, 1.5),
            new Weapon("Благословенный Воитель Апокалипсиса", 632, 226, 7, 1.5),
            new Weapon("Благословенный Воитель Реквиема", 545, 195, 7, 1.5),
            new Weapon("Благословенный Заклинатель Апокалипсиса", 415, 301, 6, 1.5),
            new Weapon("Благословенный Заклинатель Реквиема", 358, 260, 6, 1.5),
            new Weapon("Благословенный Мститель Апокалипсиса", 519, 226, 6, 1.5),
            new Weapon("Благословенный Мститель Реквиема", 448, 195, 6, 1.5),
            new Weapon("Благословенный Расчленитель Апокалипсиса", 415, 301, 6, 1.5),
            new Weapon("Благословенный Расчленитель Реквиема", 358, 260, 6, 1.5),
            new Weapon("Благословенный Резак Апокалипсиса", 519, 226, 6, 1.5),
            new Weapon("Благословенный Резак Реквиема", 448, 195, 6, 1.5),
            new Weapon("Благословенный Страж Апокалипсиса", 920, 226, 7, 1.5),
            new Weapon("Благословенный Страж Реквиема", 794, 195, 7, 1.5),
            new Weapon("Благословенный Эспадон Апокалипсиса", 632, 226, 7, 1.5),
            new Weapon("Благословенный Эспадон Реквиема", 545, 195, 7, 1.5),
            new Weapon("Бросок Апокалипсиса", 992, 219, 12, 1),
            new Weapon("Бросок Реквиема", 856, 189, 12, 1),
            new Weapon("Буревестник Апокалипсиса", 504, 219, 6, 1),
            new Weapon("Буревестник Реквиема", 435, 189, 6, 1),
            new Weapon("Бросок Апокалипсиса", 992, 219, 12, 1),
            new Weapon("Бросок Реквиема", 856, 189, 12, 1),
            new Weapon("Буревестник Апокалипсиса", 504, 219, 6, 1),
            new Weapon("Буревестник Реквиема", 435, 189, 6, 1),
            new Weapon("Возмездие Апокалипсиса", 491, 322, 7, 1),
            new Weapon("Возмездие Реквиема", 423, 278, 7, 1),
            new Weapon("Воитель Апокалипсиса", 613, 219, 7, 1),
            new Weapon("Воитель Реквиема", 529, 189, 7, 1),
            new Weapon("Заклинатель Апокалипсиса", 403, 293, 6, 1),
            new Weapon("Заклинатель Реквиема", 348, 252, 6, 1),
            new Weapon("Коготь Спасии", 595, 226, 7, 1),
            new Weapon("Мститель Апокалипсиса", 504, 219, 6, 1),
            new Weapon("Мститель Реквиема", 435, 189, 6, 1),
            new Weapon("Острие Апокалипсиса", 441, 219, 6, 1),
            new Weapon("Острие Реквиема", 380, 189, 6, 1),
            new Weapon("Парные Дубины Апокалипсиса", 613, 219, 7, 1),
            new Weapon("Парные Дубины Реквиема", 529, 189, 7, 1),
            new Weapon("Парные Кинжалы Апокалипсиса", 504, 219, 7, 1),
            new Weapon("Парные Кинжалы Реквиема", 435, 189, 7, 1),
            new Weapon("Парные Мечи Апокалипсиса", 613, 219, 7, 1),
            new Weapon("Парные Мечи Реквиема", 529, 189, 7, 1),
            new Weapon("Расчленитель Апокалипсиса", 403, 293, 6, 1),
            new Weapon("Расчленитель Реквиема", 348, 252, 6, 1),
            new Weapon("Резак Апокалипсиса", 504, 219, 6, 1),
            new Weapon("Резак Реквиема", 435, 189, 6, 1),
            new Weapon("Страж Апокалипсиса", 894, 219, 7, 1),
            new Weapon("Страж Реквиема", 771, 189, 7, 1),
            new Weapon("Эспадон Апокалипсиса", 613, 219, 7, 1),
            new Weapon("Эспадон Апокалипсиса", 529, 189, 7, 1)
            #endregion

        };

        private List<Armor> listOfArmor = new List<Armor>
        {
            new Armor("", 0, 0),
            new Armor("Благословенная Диадема Ада", 130, 1.5)
        };

        public Form1()
        {
            

            InitializeComponent();
            radioButtonOfWeapon.Checked = true;
            comboBoxOfArmor.Enabled = false;

            var sortListOfWeapon = listOfWeapon.OrderBy(point => point.Name).ToList();
            
            comboBoxOfWeapon.DataSource = sortListOfWeapon;
            comboBoxOfWeapon.DisplayMember = nameof(Weapon.Name);
            comboBoxOfWeapon.SelectedIndex = 0;
            //comboBoxOfWeapon.ValueMember = nameof(Weapon.SortOfPWeapon);

            var sortListOfArmor = listOfArmor.OrderBy(point => point.Name).ToList();

            comboBoxOfArmor.DataSource = sortListOfArmor;
            comboBoxOfArmor.DisplayMember = nameof(Armor.Name);
            comboBoxOfArmor.SelectedIndex = 0;
            //comboBoxOfArmor.ValueMember = nameof(Armor.BasePDef);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItem = (Weapon)comboBoxOfWeapon.SelectedItem;
            if (selectedItem.BasePAttack != 0)
            {
                EnchantFunction(ref x, ref z);
            }

            if (selectedItem.BasePAttack == 0)
            {
                return;
            }
            
            int basePAttack = selectedItem.BasePAttack;
            int baseMAttack = selectedItem.BaseMAttack;
            int finalPAttack = basePAttack + x; //базовое значение физ.атаки + изменения от модификации
            int finalMAttack = baseMAttack + z;
            
                

                textBox1.Text = selectedItem.Name + " " + comboBoxCountOfEnchant.SelectedItem + " " +
                                "Физическая Атака равна" +
                                " "
                                + finalPAttack + " " + "Магическая Атака равна" + " " + finalMAttack;
                x = 0;
                z = 0;
            
            
            
        }

        public void EnchantFunction(ref int g, ref int k)
        {
            int countOfEnchant = Convert.ToInt32(comboBoxCountOfEnchant.SelectedItem); //уровень модификации

            var selectedItem = (Weapon) comboBoxOfWeapon.SelectedItem;  //переменная, с помощью которой обращаемся к полям коллекции

            var oneClickEnchantPAttack = (int) Math.Ceiling(selectedItem.SortOfPWeapon*selectedItem.BlessOrSimple); //базовая прибавка патаки

            int oneClickEnchantMAttack = (int) Math.Ceiling(5*selectedItem.BlessOrSimple); //базовая прибавка матаки

            int countOfIteration = 1; //счетчик, позволяющий прервать цикл при countOfIteration > countOfEnchant


            
                for (int i = 1; i <= countOfEnchant; i++) //i - увеличивает коэффициент каждого четвертого шага на 1
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (countOfIteration > countOfEnchant)
                        {
                            return;
                        }

                        g = g + oneClickEnchantPAttack*i;
                        k = k + oneClickEnchantMAttack*i;
                        countOfIteration++;

                    }
                }
            }
        
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonOfWeapon.Checked)
            {
                comboBoxOfWeapon.Enabled = true;
            }
            if (!radioButtonOfWeapon.Checked)
            {
                comboBoxOfWeapon.Enabled = false;
            }
        }

        private void radioButtonOfArmor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOfArmor.Checked)
            {
                comboBoxOfArmor.Enabled = true;
            }
            if (!radioButtonOfArmor.Checked)
            {
                comboBoxOfArmor.Enabled = false;
            }
        }
    }
}
