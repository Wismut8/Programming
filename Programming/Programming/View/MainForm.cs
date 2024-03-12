using System.Data;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        //добавление закрытого массива объектов типа Rectangle
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;

        //добавление закрытого массива объектов типа Film
        private Film[] _films;
        private Film _currentFilm;

        public MainForm()
        {
            InitializeComponent();
            Random random = new Random();

            //инициализация прямоугольников 
            _rectangles = new Rectangle[5];
            string[] colors = { "red", "yellow", "green", "blue", "purple" };

            for (int i = 0; i < _rectangles.Length; i++)
            {
                int width = random.Next(1, 100);
                int height = random.Next(1, 100);
                string color = colors[i];
                int centerX = random.Next(1, 100);
                int centerY = random.Next(1, 100);
                _rectangles[i] = new Rectangle(width, height, color, new Point2D(centerX, centerY));
            }

            _currentRectangle = new Rectangle(0, 0, "", new Point2D(0, 0));

            //инициализация фильмов 
            _films = new Film[5];
            string[] names = { "White Chicks", "Dune", "Drive", "First Blood", "The shining" };
            string[] genres = { "comedy", "drama", "thriller", "action", "horror" };

            for (int i = 0; i < _rectangles.Length; i++)
            {
                string name = names[i];
                int yearOfIssue = random.Next(20, 240);
                int duration = random.Next(1900, 2024);
                string genre = genres[i];
                double rating = Math.Round(random.NextDouble() * 10, 2);
                _films[i] = new Film(name, yearOfIssue, duration, genre, rating);
            }


            _currentFilm = new Film("", 0, 0, "", 0.0);
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

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidth = 0;
            int maxIndex = -1;

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = (int)rectangles[i].Width;
                    maxIndex = i;
                }
            }

            if (maxIndex == -1)
            {
                throw new InvalidOperationException("No rectangle with valid width found.");
            }

            return maxIndex;
        }

        private int FindFilmWithMaxRating(Film[] films)
        {
            int maxRating = 0;
            int maxIndex = -1;

            for (int i = 0; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = (int)films[i].Rating;
                    maxIndex = i;
                }
            }

            if (maxIndex == -1)
            {
                throw new InvalidOperationException("No rectangle with valid width found.");
            }

            return maxIndex;
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


        private void RectanglesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;

            _currentRectangle = _rectangles[selectedIndex];

            if (_currentRectangle != null)
            {
                LenghtTextBox.Text = _currentRectangle.Height.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorTextBox.Text = _currentRectangle.Color.ToString();
                xTextBox.Text = _currentRectangle.Center.X.ToString();
                yTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }

        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int height = int.Parse(LenghtTextBox.Text);

                    if (height <= 0 || height > 100) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Height must be between 1 and 100.");
                    }

                    _currentRectangle.Height = height;
                    LenghtTextBox.BackColor = Color.White; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                LenghtTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                LenghtTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int width = int.Parse(WidthTextBox.Text);

                    if (width <= 0 || width > 100) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Width must be between 1 and 100.");
                    }

                    _currentRectangle.Width = width;
                    WidthTextBox.BackColor = Color.White; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                WidthTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int RectangleWithMaxWidth = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = RectangleWithMaxWidth;
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = FilmsListBox.SelectedIndex;

            _currentFilm = _films[selectedIndex];

            if (_currentFilm != null)
            {
                NameTextBox.Text = _currentFilm.Name.ToString();
                DurationTextBox.Text = _currentFilm.DurationInMinutes.ToString();
                IssueTextBox.Text = _currentFilm.YearOfIssue.ToString();
                GenreTextBox.Text = _currentFilm.Genre.ToString();
                RatingTextBox.Text = _currentFilm.Rating.ToString();
            }
        }

        private void IssueTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentFilm != null)
                {
                    int yearOfIssue = int.Parse(IssueTextBox.Text);

                    if (yearOfIssue < 1900 || yearOfIssue > 2025) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Year of issue must be between 1900 and 2025.");
                    }

                    _currentFilm.YearOfIssue = yearOfIssue;
                    IssueTextBox.BackColor = Color.White; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                IssueTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                IssueTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }


        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentFilm != null)
                {
                    double rating = double.Parse(RatingTextBox.Text);

                    if (rating <= 0.0 || rating > 10.0) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Rating of issue must be between 0.0 and 10.0.");
                    }

                    _currentFilm.Rating = rating;
                    RatingTextBox.BackColor = Color.White; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                RatingTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                RatingTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = NameTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentFilm != null)
                {
                    int duration = int.Parse(DurationTextBox.Text);

                    if (duration <= 0) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Duration must be a positive number");
                    }

                    _currentFilm.DurationInMinutes = duration;
                    DurationTextBox.BackColor = Color.White; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                DurationTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                DurationTextBox.BackColor = Color.LightPink; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreTextBox.Text;
        }

        private void FindMaxRatingButton_Click(object sender, EventArgs e)
        {
            int FilmWithMaxRating = FindFilmWithMaxRating(_films);
            FilmsListBox.SelectedIndex = FilmWithMaxRating;
        }

    }

}