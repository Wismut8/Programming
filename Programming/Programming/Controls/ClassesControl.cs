using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Controls
{
    public partial class ClassesControl : UserControl
    {
        //добавление закрытого массива объектов типа Rectangle
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;

        //добавление закрытого массива объектов типа Film
        private Film[] _films;
        private Film _currentFilm;

        public ClassesControl()
        {
            InitializeComponent();
            Random random = new Random();

            //инициализация фильмов 
            _films = new Film[5];
            string[] names = { "White Chicks", "Dune", "Drive", "First Blood", "The shining" };
            string[] genres = { "comedy", "drama", "thriller", "action", "horror" };

            for (int i = 0; i < _films.Length; i++)
            {
                string name = names[i];
                int yearOfIssue = random.Next(20, 240);
                int duration = random.Next(1900, 2024);
                string genre = genres[i];
                double rating = Math.Round(random.NextDouble() * 10, 2);
                _films[i] = new Film(name, yearOfIssue, duration, genre, rating);
            }
            _currentFilm = new Film("", 0, 0, "", 0.0);

            //инициализация прямоугольников
            _rectangles = new Rectangle[5];
            for (int i = 0; i < _rectangles.Length; ++i)
            {
                int width = random.Next(100);
                int height = random.Next(100);
                int x = random.Next(100);
                int y = random.Next(100);
                _rectangles[i] = new Rectangle(width, height, new Point2D(x, y));
            }
            _currentRectangle = new Rectangle(0, 0, new Point2D(0, 0));


        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;

            _currentRectangle = _rectangles[selectedIndex];

            if (_currentRectangle != null)
            {
                LenghtTextBox.Text = _currentRectangle.Height.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                xTextBox.Text = _currentRectangle.Center.X.ToString();
                yTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
                LenghtTextBox.BackColor = AppColors.ValidationTrueColor;
            }
        }

        private void ClassesControl_Load(object sender, EventArgs e)
        {

        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (_currentRectangle != null)
                {
                    int height = int.Parse(LenghtTextBox.Text);
                    int width = int.Parse(WidthTextBox.Text);

                    if (height <= 0 || height > 200) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Height must be between 1 and 200.");
                    }

                    _currentRectangle.Height = height;
                    LenghtTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                LenghtTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                LenghtTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int width = int.Parse(WidthTextBox.Text);
                    int height = int.Parse(LenghtTextBox.Text);

                    if (width <= 0 || width > 200) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Width must be between 1 and 200.");
                    }

                    _currentRectangle.Width = width;
                    WidthTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                WidthTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
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
                    DurationTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                DurationTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                DurationTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
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
                    IssueTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                IssueTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                IssueTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreTextBox.Text;
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
                    RatingTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                RatingTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                RatingTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
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

        private void FindButton_Click(object sender, EventArgs e)
        {
            int RectangleWithMaxWidth = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = RectangleWithMaxWidth;
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

        private void FindMaxRatingButton_Click(object sender, EventArgs e)
        {
            int FilmWithMaxRating = FindFilmWithMaxRating(_films);
            FilmsListBox.SelectedIndex = FilmWithMaxRating;
        }
    }
}
