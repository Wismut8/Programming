using System.Data;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateEnumsListBox();
        }

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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отображение числового значения выбранного элемента перечисления
            IntTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            //Ввод слова
            string inputText = ParseTextBox.Text;

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


        private void SeasonButton_Click(object sender, EventArgs e)
        {
            //Реализация вывода сообщения или смены фона в зависимости от выбранного значения
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case 1:
                    Enums.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 2:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case 3:
                    Enums.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }

}