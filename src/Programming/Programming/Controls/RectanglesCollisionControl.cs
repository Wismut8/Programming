using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class RectanglesCollisionControl : UserControl
    {
        //добавление закрытого массива объектов типа Rectangle
        private List<Rectangle> _rectangles;
        private Rectangle _currentRectangle;

        //добавление закрытого списка объектов типа Panel
        private List<Panel> _rectanglePanels = new List<Panel>();


        public RectanglesCollisionControl()
        {
            InitializeComponent();
            Random random = new Random();

            _rectangles = new List<Rectangle>();
            _currentRectangle = new Rectangle(0, 0, new Point2D(0, 0));

            _rectanglePanels = new List<Panel>();
        }
        private void RectanglesCollisionControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Генерирует прямоугольник с рандомными значениями размера и расположения. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRecButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int width = random.Next(1, 200);
            int height = random.Next(1, 200);
            int centerX = random.Next(1, 400);
            int centerY = random.Next(1, 400);
            Rectangle newRectangle = new Rectangle(width, height, new Point2D(centerX, centerY));
            _rectangles.Add(newRectangle);
            UpdateRecList();
            AddRectanglePanel(newRectangle);
            FindCollisions();
        }

        /// <summary>
        /// Обновляет записи в RecListBox
        /// </summary>
        private void UpdateRecList()
        {
            RecListBox.Items.Clear();
            foreach (Rectangle rectangle in _rectangles)
            {
                RecListBox.Items.Add($"{rectangle.Id-7}: (X= {rectangle.Center.X}, Y= {rectangle.Center.Y}, W= {rectangle.Width}, H= {rectangle.Height})");
            }
        }

        /// <summary>
        /// Добавляет панель на вкладку
        /// </summary>
        /// <param name="rectangle"></param>
        private void AddRectanglePanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point(rectangle.Center.X - rectangle.Width / 2, rectangle.Center.Y - rectangle.Height / 2);
            panel.Size = new Size(rectangle.Width, rectangle.Height);
            panel.BackColor = AppColors.CollisionFalse;

            _rectanglePanels.Add(panel);
            RectanglesPanel.Controls.Add(panel);

        }

        /// <summary>
        /// Осуществляет перебор panels для обнаружения коллизий.
        /// </summary>
        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = AppColors.CollisionFalse;
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (!CollisionManager.IsCollision(_rectangles[i], _rectangles[j])) continue;

                    _rectanglePanels[i].BackColor = AppColors.CollisionTrue;
                    _rectanglePanels[j].BackColor = AppColors.CollisionTrue;
                }
            }
        }

        /// <summary>
        /// Удаляет экземпляр прямоугольника и панели при нажатии на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteRecButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = RecListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                _rectangles.RemoveAt(selectedIndex);
                RecListBox.Items.RemoveAt(selectedIndex);
                IDRecTextBox.Text = "";
                XRecTextBox.Text = "";
                YRecTextBox.Text = "";
                HeightRecTextBox.Text = "";
                WidthRecTextBox.Text = "";

                RemoveRectanglePanel(selectedIndex);
                FindCollisions();

                YRecTextBox.BackColor = AppColors.ValidationTrueColor;
                XRecTextBox.BackColor = AppColors.ValidationTrueColor;
                HeightRecTextBox.BackColor = AppColors.ValidationTrueColor;
                WidthRecTextBox.BackColor = AppColors.ValidationTrueColor;
            }
        }

        /// <summary>
        /// Обновляет положение панели на канве. 
        /// </summary>
        /// <param name="index">Индекс соответствующего прямоугольника.</param>
        /// <param name="newX">Новое значение координаты X.</param>
        /// <param name="newY">Новое значение координаты У.</param>
        private void UpdateRectanglePanelLocation(int index, int newX, int newY)
        {
            if (index >= 0 && index < _rectanglePanels.Count)
            {
                Rectangle rectangle = _rectangles[index + 8];
                Panel panel = _rectanglePanels[index];
                panel.Location = new Point(newX - (rectangle.Width / 2), newY - (rectangle.Height / 2));
                FindCollisions(); // Если нужно проверить коллизии после изменения размеров
            }
        }

        /// <summary>
        /// Осуществляет удаление экземпляра панели.
        /// </summary>
        /// <param name="index">Индекс соответствующего прямоугольника.</param>
        private void RemoveRectanglePanel(int index)
        {
            if (index >= 0 && index < _rectanglePanels.Count)
            {
                RectanglesPanel.Controls.Remove(_rectanglePanels[index]);
                _rectanglePanels.RemoveAt(index);
            }
        }

        /// <summary>
        /// Обновляет размер панели.
        /// </summary>
        /// <param name="index">Индекс соответствующего прямоугольника</param>
        /// <param name="newWidth">Новое значение ширины.</param>
        /// <param name="newHeight">Новое значение длины.</param>
        private void UpdateRectanglePanelSize(int index, int newWidth, int newHeight)
        {
            if (index >= 0 && index < _rectanglePanels.Count)
            {
                Panel panel = _rectanglePanels[index];
                panel.Size = new Size(newWidth, newHeight);
                FindCollisions(); // Если нужно проверить коллизии после изменения размеров
            }
        }

        /// <summary>
        /// Изменение и сохранение новой координаты Х.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int newX = int.Parse(XRecTextBox.Text);
                    int newY = int.Parse(YRecTextBox.Text);

                    if (newX <= 0) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Width must be positive");
                    }

                    _currentRectangle.Center.X = newX;
                    UpdateRecList();
                    UpdateRectanglePanelLocation(_currentRectangle.Id - 8, newX, newY);

                    XRecTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                XRecTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                XRecTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        /// <summary>
        /// Изменение и сохранение новой координаты У.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int newX = int.Parse(XRecTextBox.Text);
                    int newY = int.Parse(YRecTextBox.Text);

                    if (newY <= 0) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Width must be positive");
                    }

                    _currentRectangle.Center.Y = newY;
                    UpdateRecList();
                    UpdateRectanglePanelLocation(_currentRectangle.Id - 8, newX, newY);

                    YRecTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                YRecTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                YRecTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        /// <summary>
        /// Изменение и сохранение значения ширины прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int width = int.Parse(WidthRecTextBox.Text);

                    if (width <= 0 || width > 200) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Width must be between 1 and 200.");
                    }

                    _currentRectangle.Width = width;
                    UpdateRecList();
                    UpdateRectanglePanelSize(_currentRectangle.Id - 8, width, _currentRectangle.Height); // Меняем только ширину, высота остается прежней
                    WidthRecTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                WidthRecTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                WidthRecTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        /// <summary>
        /// Изменение и сохранение значения длины прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int height = int.Parse(HeightRecTextBox.Text);
                    int width = int.Parse(WidthRecTextBox.Text);

                    if (height <= 0 || height > 200) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("Width must be between 1 and 200.");
                    }

                    _currentRectangle.Height = height;
                    UpdateRecList();
                    UpdateRectanglePanelSize(_currentRectangle.Id - 8, width, height);
                    HeightRecTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                HeightRecTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                HeightRecTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        /// <summary>
        /// Отображение значений полей объекта Rectangle в текстбоксах.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RecListBox.SelectedIndex;

            if (RecListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[RecListBox.SelectedIndex];

                if (_currentRectangle != null)
                {
                    IDRecTextBox.Text = Convert.ToString(_currentRectangle.Id - 1);
                    XRecTextBox.Text = _currentRectangle.Center.X.ToString();
                    YRecTextBox.Text = _currentRectangle.Center.Y.ToString();
                    HeightRecTextBox.Text = _currentRectangle.Height.ToString();
                    WidthRecTextBox.Text = _currentRectangle.Width.ToString();

                    YRecTextBox.BackColor = AppColors.ValidationTrueColor;
                    XRecTextBox.BackColor = AppColors.ValidationTrueColor;
                    HeightRecTextBox.BackColor = AppColors.ValidationTrueColor;
                    WidthRecTextBox.BackColor = AppColors.ValidationTrueColor;

                }
            }
        }
    }
}
