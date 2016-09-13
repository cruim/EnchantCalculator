using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EnchantCalculator
{
    public partial class Form1 : Form
    {
        private static int x;
        private static int z;
        private static int w;

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
            new Weapon("Благословенные Парные Кинжалы Реквиема", 448, 195, 7, 1.5),
            new Weapon("Благословенные Парные Мечи Апокалипсиса", 632, 226, 7, 1.5),
            new Weapon("Благословенные Парные Мечи Реквиема", 545, 195, 7, 1.5),
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
            new Weapon("Эспадон Апокалипсиса", 529, 189, 7, 1),
            new Weapon("Благословенное Возмездие Фантазмы", 586, 384, 7, 1.5),
            new Weapon("Благословенное Острие Фантазмы", 526, 262, 6, 1.5),
            new Weapon("Благословенные Парные Дубины Фантазмы", 732, 262, 7, 1.5),
            new Weapon("Благословенные Парные Кинжалы Фантазмы", 602, 262, 7, 1.5),
            new Weapon("Благословенные Парные Мечи Фантазмы", 732, 262, 7, 1.5),
            new Weapon("Благословенный Бросок Фантазмы", 1185, 262, 12, 1.5),
            new Weapon("Благословенный Буревестник Фантазмы", 602, 262, 6, 1.5),
            new Weapon("Благословенный Воитель Фантазмы", 732, 262, 7, 1.5),
            new Weapon("Благословенный Заклинатель Фантазмы", 481, 349, 6, 1.5),
            new Weapon("Благословенный Мститель Фантазмы", 602, 262, 6, 1.5),
            new Weapon("Благословенный Расчленитель Фантазмы", 481, 349, 6, 1.5),
            new Weapon("Благословенный Резак Фантазмы", 602, 262, 6, 1.5),
            new Weapon("Благословенный Страж Фантазмы", 1067, 262, 7, 1.5),
            new Weapon("Благословенный Эспадон Фантазмы", 732, 262, 7, 1.5),
            new Weapon("Бросок Фантазмы", 1151, 254, 12, 1),
            new Weapon("Буревестник Меллисы", 567, 275, 6, 1),
            new Weapon("Буревестник Фантазмы", 584, 254, 6, 1),
            new Weapon("Возмездие Фантазмы", 569, 373, 7, 1),
            new Weapon("Воитель Фантазмы", 711, 254, 7, 1),
            new Weapon("Заклинатель Фантазмы", 467, 339, 6, 1),
            new Weapon("Мститель Фантазмы", 584, 254, 6, 1),
            new Weapon("Острие Фантазмы", 511, 254, 6, 1),
            new Weapon("Парные Дубины Фантазмы", 711, 254, 7, 1),
            new Weapon("Парные Дубины Фрона", 690, 275, 7, 1),
            new Weapon("Парные Кинжалы Фантазмы", 584, 254, 7, 1),
            new Weapon("Парные Мечи Фантазмы", 711, 254, 7, 1),
            new Weapon("Расчленитель Фантазмы", 467, 339, 6, 1),
            new Weapon("Резак Фантазмы", 584, 254, 6, 1),
            new Weapon("Страж Фантазмы", 1036, 254, 7, 1),
            new Weapon("Эспадон Фантазмы", 711, 254, 7, 1),
            new Weapon("Благословенное Возмездие Хелиоса", 640, 420, 7, 1.5),
            new Weapon("Благословенное Острие Хелиоса", 575, 286, 6, 1.5),
            new Weapon("Благословенные Парные Дубины Хелиоса", 800, 286, 7, 1.5),
            new Weapon("Благословенные Парные Кинжалы Хелиоса", 658, 286, 7, 1.5),
            new Weapon("Благословенные Парные Мечи Хелиоса", 800, 286, 7, 1.5),
            new Weapon("Благословенный Бросок Хелиоса", 1295, 286, 12, 1.5),
            new Weapon("Благословенный Буревестник Хелиоса", 658, 286, 6, 1.5),
            new Weapon("Благословенный Воитель Хелиоса", 800, 286, 7, 1.5),
            new Weapon("Благословенный Заклинатель Хелиоса", 526, 382, 6, 1.5),
            new Weapon("Благословенный Мститель Хелиоса", 658, 286, 6, 1.5),
            new Weapon("Благословенный Расчленитель Хелиоса", 526, 382, 6, 1.5),
            new Weapon("Благословенный Резак Хелиоса", 658, 286, 6, 1.5),
            new Weapon("Благословенный Страж Хелиоса", 1166, 286, 7, 1.5),
            new Weapon("Благословенный Эспадон Хелиоса", 800, 286, 7, 1.5),
            new Weapon("Бросок Хелиоса", 1257, 278, 12, 1),
            new Weapon("Буревестник Хелиоса", 638, 278, 6, 1),
            new Weapon("Возмездие Хелиоса", 622, 408, 7, 1),
            new Weapon("Воитель Хелиоса", 777, 278, 7, 1),
            new Weapon("Заклинатель Хелиоса", 511, 371, 6, 1),
            new Weapon("Мститель Хелиоса", 638, 278, 6, 1),
            new Weapon("Острие Хелиоса", 558, 278, 6, 1),
            new Weapon("Парные Дубины Хелиоса", 777, 278, 7, 1),
            new Weapon("Парные Кинжалы Хелиоса", 638, 278, 7, 1),
            new Weapon("Парные Мечи Хелиоса", 777, 278, 7, 1),
            new Weapon("Расчленитель Хелиоса", 511, 371, 6, 1),
            new Weapon("Резак Хелиоса", 638, 278, 6, 1),
            new Weapon("Страж Хелиоса", 1132, 278, 7, 1),
            new Weapon("Эспадон Хелиоса", 777, 278, 7, 1),
            new Weapon("Кровавое/Темное Возмездие Хелиоса", 700, 459, 7, 1.5),
            new Weapon("Кровавое/Темное Острие Хелиоса", 629, 313, 6, 1.5),
            new Weapon("Кровавые/Темные Парные Дубины Хелиоса", 875, 313, 7, 1.5),
            new Weapon("Кровавое/Темное Парные Кинжалы Хелиоса", 719, 313, 7, 1.5),
            new Weapon("Кровавые/Темные Парные Мечи Хелиоса", 875, 313, 7, 1.5),
            new Weapon("Кровавый/Темный Бросок Хелиоса", 1415, 313, 12, 1.5),
            new Weapon("Кровавый/Темный Буревестник Хелиоса", 719, 313, 6, 1.5),
            new Weapon("Кровавый/Темный Воитель Хелиоса", 875, 313, 7, 1.5),
            new Weapon("Кровавый/Темный Заклинатель Хелиоса", 575, 417, 6, 1.5),
            new Weapon("Кровавый/Темный Мститель Хелиоса", 719, 313, 6, 1.5),
            new Weapon("Кровавый/Темный Расчленитель Хелиоса", 575, 417, 6, 1.5),
            new Weapon("Кровавый/Темный Резак Хелиоса", 719, 313, 6, 1.5),
            new Weapon("Кровавый/Темный Страж Хелиоса", 1274, 313, 7, 1.5),
            new Weapon("Кровавый/Темный Эспадон Хелиоса", 875, 313, 7, 1.5),
            #endregion

        };

        #region CoolectionOfArmor
        private List<Armor> listOfArmor = new List<Armor>
        {
            new Armor("", 0, 0),
            new Armor("Благословенная Диадема Ада", 130, 1.5),
            new Armor("Благословенная Диадема Бессмертия", 118, 1.5),
            new Armor("Благословенная Кираса Ада ", 348, 1.5),
            new Armor("Благословенная Кираса Бессмертия", 315, 1.5),
            new Armor("Благословенная Туника Ада", 191, 1.5),
            new Armor("Благословенная Туника Бессмертия", 173, 1.5),
            new Armor("Благословенные Ботинки Ада", 87, 1.5),
            new Armor("Благословенные Ботинки Бессмертия", 78, 1.5),
            new Armor("Благословенные Кожаные Брюки Ада", 173, 1.5),
            new Armor("Благословенные Кожаные Брюки Бессмертия", 157, 1.5),
            new Armor("Благословенные Кожаные Перчатки Ада", 87, 1.5),
            new Armor("Благословенные Кожаные Перчатки Бессмертия", 78, 1.5),
            new Armor("Благословенные Кожаные Сапоги Ада", 87, 1.5),
            new Armor("Благословенные Кожаные Сапоги Бессмертия", 78, 1.5),
            new Armor("Благословенные Набедренники Ада", 217, 1.5),
            new Armor("Благословенные Набедренники Бессмертия", 197, 1.5),
            new Armor("Благословенные Перчатки Ада", 87, 1.5),
            new Armor("Благословенные Перчатки Бессмертия", 78, 1.5),
            new Armor("Благословенные Рукавицы Ада", 87, 1.5),
            new Armor("Благословенные Рукавицы Бессмертия", 78, 1.5),
            new Armor("Благословенные Сапоги Ада", 87, 1.5),
            new Armor("Благословенные Сапоги Бессмертия", 78, 1.5),
            new Armor("Благословенные Штаны Ада", 119, 1.5),
            new Armor("Благословенные Штаны Бессмертия", 130, 1.5), 
            new Armor("Благословенный Кожаный Доспех Ада", 278, 1.5),
            new Armor("Благословенный Кожаный Доспех Бессмертия", 252, 1.5),
            new Armor("Благословенный Кожаный Шлем Ада", 130, 1.5),
            new Armor("Благословенный Кожаный Шлем Бессмертия", 118, 1.5),
            new Armor("Благословенный Шлем Ада", 130, 1.5),
            new Armor("Благословенный Шлем Бессмертия", 118, 1.5),
            new Armor("Благословенный Щит Ада", 476, 1.5),
            new Armor("Благословенный Щит Бессмертия", 431, 1.5),
            new Armor("Благословенная Диадема Кадейры", 144, 1.5),
            new Armor("Благословенная Кираса Кадейры", 384, 1.5),
            new Armor("Благословенная Туника Кадейры", 211, 1.5),
            new Armor("Благословенные Ботинки Кадейры", 96, 1.5),
            new Armor("Благословенные Кожаные Брюки Кадейры", 192, 1.5),
            new Armor("Благословенные Кожаные Перчатки Кадейры", 96, 1.5),
            new Armor("Благословенные Кожаные Сапоги Кадейры", 96, 1.5),
            new Armor("Благословенные Набедренники Кадейры", 240, 1.5),
            new Armor("Благословенные Перчатки Кадейры", 96, 1.5),
            new Armor("Благословенные Рукавицы Кадейры", 96, 1.5),
            new Armor("Благословенные Сапоги Кадейры", 96, 1.5),
            new Armor("Благословенные Штаны Кадейры", 132, 1.5),
            new Armor("Благословенный Кожаный Доспех Кадейры", 307, 1.5),
            new Armor("Благословенный Кожаный Шлем Кадейры", 144, 1.5),
            new Armor("Благословенный Шлем Кадейры", 144, 1.5),
            new Armor("Благословенный Щит Кадейры", 525, 1.5),
            new Armor("Ботинки Кадейры", 94, 1),
            new Armor("Диадема Кадейры", 141, 1),
            new Armor("Кираса Кадейры", 377, 1),
            new Armor("Кожаные Брюки Кадейры", 188, 1),
            new Armor("Кожаные Перчатки Кадейры", 94, 1),
            new Armor("Кожаные Сапоги Кадейры", 94, 1),
            new Armor("Кожаный Доспех Кадейры", 301, 1),
            new Armor("Кожаный Шлем Кадейры", 141, 1),
            new Armor("Набедренники Кадейры", 235, 1),
            new Armor("Перчатки Кадейры", 94, 1),
            new Armor("Рукавицы Кадейры", 94, 1),
            new Armor("Сапоги Кадейры", 94, 1),
            new Armor("Туника Кадейры", 207, 1),
            new Armor("Шлем Кадейры", 141, 1),
            new Armor("Штаны Кадейры", 129, 1),
            new Armor("Щит Кадейры", 515, 1),
            new Armor("Ботинки Айдиоса", 100, 1),
            new Armor("Диадема Айдиоса", 150, 1),
            new Armor("Кираса Айдиоса", 400, 1),
            new Armor("Кожаные Брюки Айдиоса", 200, 1),
            new Armor("Кожаные Перчатки Айдиоса", 100, 1),
            new Armor("Кожаные Сапоги Айдиоса", 100, 1),
            new Armor("Кожаный Доспех Айдиоса", 320, 1),
            new Armor("Кожаный Шлем Айдиоса", 150, 1),
            new Armor("Набедренники Айдиоса", 250, 1),
            new Armor("Перчатки Айдиоса", 100, 1),
            new Armor("Рукавицы Айдиоса", 100, 1),
            new Armor("Сапоги Айдиоса", 100, 1),
            new Armor("Туника Айдиоса", 220, 1),
            new Armor("Шлем Айдиоса", 150, 1),
            new Armor("Штаны Айдиоса", 137, 1),
            new Armor("Щит Айдиоса", 546, 1),
            new Armor("Благословенная Диадема Айдиоса", 153, 1.5),
            new Armor("Благословенная Кираса Айдиоса", 408, 1.5),
            new Armor("Благословенная Туника Айдиоса", 224, 1.5),
            new Armor("Благословенные Ботинки Айдиоса", 102, 1.5),
            new Armor("Благословенные Кожаные Брюки Айдиоса", 204, 1.5),
            new Armor("Благословенные Кожаные Перчатки Айдиоса", 102, 1.5),
            new Armor("Благословенные Кожаные Сапоги Айдиоса", 102, 1.5),
            new Armor("Благословенные Набедренники Айдиоса", 255, 1.5),
            new Armor("Благословенные Перчатки Айдиоса", 102, 1.5),
            new Armor("Благословенные Рукавицы Айдиоса", 102, 1.5),
            new Armor("Благословенные Сапоги Айдиоса", 102, 1.5),
            new Armor("Благословенные Штаны Айдиоса", 140, 1.5),
            new Armor("Благословенный Кожаный Доспех Айдиоса", 326, 1.5),
            new Armor("Благословенный Кожаный Шлем Айдиоса", 153, 1.5),
            new Armor("Благословенный Шлем Айдиоса", 153, 1.5),
            new Armor("Благословенный Щит Айдиоса", 557, 1.5),
            new Armor("Кровавая/Темная Диадема Айдиоса", 162, 1.5),
            new Armor("Кровавая/Темная Кираса Айдиоса", 433, 1.5),
            new Armor("Кровавая/Темная Туника Айдиоса", 238, 1.5),
            new Armor("Кровавые/Темные Ботинки Айдиоса", 108, 1.5),
            new Armor("Кровавые/Темные Кожаные Брюки Айдиоса", 216, 1.5),
            new Armor("Кровавые/Темные Кожаные Перчатки Айдиоса", 108, 1.5),
            new Armor("Кровавые/Темные Кожаные Сапоги Айдиоса", 108, 1.5),
            new Armor("Кровавые/Темные Набедренники Айдиоса", 270, 1.5),
            new Armor("Кровавые/Темные Перчатки Айдиоса", 108, 1.5),
            new Armor("Кровавые/Темные Рукавицы Айдиоса", 108, 1.5),
            new Armor("Кровавые/Темные Сапоги Айдиоса", 108, 1.5),
            new Armor("Кровавые/Темные Штаны Айдиоса", 148, 1.5),
            new Armor("Кровавый/Темный Кожаный Доспех Айдиоса", 346, 1.5),
            new Armor("Кровавый/Темный Кожаный Шлем Айдиоса", 162, 1.5),
            new Armor("Кровавый/Темный Шлем Айдиоса", 162, 1.5)
        };
        #endregion

        public Form1()
        {


            InitializeComponent();
            radioButtonOfWeapon.Checked = true;
            comboBoxOfArmor.Enabled = false;
            var sortListOfWeapon = listOfWeapon.OrderBy(point => point.Name).ToList();

            comboBoxOfWeapon.DataSource = sortListOfWeapon;
            comboBoxOfWeapon.DisplayMember = nameof(Weapon.Name);
            comboBoxOfWeapon.SelectedIndex = 0;

            var sortListOfArmor = listOfArmor.OrderBy(point => point.Name).ToList();

            comboBoxOfArmor.DataSource = sortListOfArmor;
            comboBoxOfArmor.DisplayMember = nameof(Armor.Name);
            comboBoxOfArmor.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItemOfWeapon = (Weapon)comboBoxOfWeapon.SelectedItem;
            var selectedItemOfArmor = (Armor)comboBoxOfArmor.SelectedItem;

            if (selectedItemOfWeapon.BasePAttack != 0 /*&& radioButtonOfWeapon.Checked*/)
            {
                EnchantFunctionOfWeapon(ref x, ref z);
            }

            if (selectedItemOfArmor.BasePDef != 0)
            {
                EnchantFunctionOfArmor(ref w);
            }

            int basePAttack = selectedItemOfWeapon.BasePAttack;
            int baseMAttack = selectedItemOfWeapon.BaseMAttack;
            int finalPAttack = basePAttack + x; //базовое значение физ.атаки + изменения от модификации
            int finalMAttack = baseMAttack + z;

            int basePDeff = selectedItemOfArmor.BasePDef;
            int finalPDeff = basePDeff + w;


            if (radioButtonOfWeapon.Checked && comboBoxOfWeapon.SelectedIndex != 0)
            {


                textBox1.Text = selectedItemOfWeapon.Name + " " + comboBoxCountOfEnchant.SelectedItem + " " +
                                "Физическая Атака равна" +
                                " "
                                + finalPAttack + " " + "Магическая Атака равна" + " " + finalMAttack;
                x = 0;
                z = 0;
            }


            if (radioButtonOfArmor.Checked && comboBoxOfArmor.SelectedIndex != 0)
            {

                textBox1.Text = selectedItemOfArmor.Name + " " + comboBoxCountOfEnchant.SelectedItem + " " +
                                "Физическая Защита равна" + " " + finalPDeff;
                w = 0;
            }




        }

        public void EnchantFunctionOfWeapon(ref int g, ref int k)
        {
            int countOfEnchant = Convert.ToInt32(comboBoxCountOfEnchant.SelectedItem); //уровень модификации

            var selectedItem = (Weapon)comboBoxOfWeapon.SelectedItem;  //переменная, с помощью которой обращаемся к полям коллекции

            var oneClickEnchantPAttack = (int)Math.Ceiling(selectedItem.SortOfPWeapon * selectedItem.BlessOrSimple); //базовая прибавка патаки

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


        public void EnchantFunctionOfArmor(ref int g)
        {
            int countOfEnchant = Convert.ToInt32(comboBoxCountOfEnchant.SelectedItem); //уровень модификации

            var selectedItem = (Armor)comboBoxOfArmor.SelectedItem;  //переменная, с помощью которой обращаемся к полям коллекции

            var oneClickEnchantPDeff = (int)Math.Ceiling(2 * selectedItem.BlessOrSimple); //базовая прибавка защиты

            int countOfIteration = 1; //счетчик, позволяющий прервать цикл при countOfIteration > countOfEnchant



            for (int i = 1; i <= countOfEnchant; i++) //i - увеличивает коэффициент каждого четвертого шага на 1
            {
                for (int j = 0; j < 3; j++)
                {
                    if (countOfIteration > countOfEnchant)
                    {
                        return;
                    }
                    if (i > 3) { i = 3;}
                    g = g + oneClickEnchantPDeff * i;
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
                comboBoxOfWeapon.SelectedIndex = 0;
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
                comboBoxOfArmor.SelectedIndex = 0;
            }
        }
    }
}
