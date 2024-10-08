using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
        }

        private void EnumerationsControl_Load(object sender, EventArgs e)
        {
            PopulateEnumsListBox();
        }

        /// <summary>
        /// Добавляет все доступные перечисления в EnumsListBox.
        /// </summary>
        private void PopulateEnumsListBox()
        {
            //Получение всех типов в сборке
            Type[] types = typeof(Program).Assembly.GetTypes();

            //Фильтруем только перечисления
            var enumTypes = Array.FindAll(types, type => type.IsEnum);

            //Добавляем имена перечислений в EnumsListBox
            foreach (var enumType in enumTypes)
            {
                EnumsListBox.Items.Add(enumType.Name);
            }

            //Выбираем по умолчанию первый элемент
            EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Отображает значения перечисления выбранного индекса в ValuesListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Очищаем листбокс и текстовое поле от прошлых значений
            ValuesListBox.Items.Clear();
            IntTextBox.Clear();

            //Обращаемся к перечислению в зависимости от индекса
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Colours)).Cast<object>().ToArray());
                    break;
                case 1:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(EducationForm)).Cast<object>().ToArray());
                    break;
                case 2:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                    break;
                case 3:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(SmartphoneManufacturers)).Cast<object>().ToArray());
                    break;
                case 4:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
                    break;
                case 5:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                    break;
            }
        }

        /// <summary>
        /// Отображает числовое значение выбранного элемента перечисления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        /// <summary>
        /// Парсирует введенное значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            //Ввод слова
            string inputText = ParseTextBox.Text;

            //защита от ввода целых чисел
            int number;
            if (int.TryParse(inputText, out number))
            {
                ParseCommentLabel.Text = "Пожалуйста, введите название дня недели, а не число";
                return;
            }

            //объявление перечисления, с которым будем работать
            Weekday weekday;

            //Парсинг, вывод комментария
            if (Enum.TryParse(inputText, out weekday))
            {
                ParseCommentLabel.Text = $"Это день недели ({weekday} = {(int)weekday})";
            }
            else
            {
                ParseCommentLabel.Text = "Нет такого дня недели";
            }
        }

        /// <summary>
        /// Выводит сообщение в зависимости от выбранного значения в SeasonComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case 1:
                    MessageBox.Show("Скоро всё расцветет!");
                    break;
                case 2:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case 3:
                    MessageBox.Show("Не забудь зонтик!");
                    break;
            }
        }

        private void EnumerationsGroupBox_Enter(object sender, EventArgs e)
        {
        }
    }
}
