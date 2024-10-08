
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.RegularExpressions;
using Programming.Model.Classes;

namespace LaoratoryWork8
{
    public partial class MainForm : Form
    {
        //добавление закрытого массива объектов типа Flight
        private List<Flight> _flights;
        private Flight _currentFlight;

        public MainForm()
        {
            InitializeComponent();
            _flights = new List<Flight>();
            _currentFlight = new Flight("", "", new DateTime(), 0, new TypeOfFlight());
        }

        /// <summary>
        /// Сохранение данных объектов типа Flight <see cref="Flight"/> в текстовый файл для сохранения данных.
        /// </summary>
        private void WriteOnFile()
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Flight>));
                using (FileStream fs = new FileStream("flights.json", FileMode.OpenOrCreate))
                {
                    serializer.WriteObject(fs, _flights);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);


            }
        }

        /// <summary>
        /// Загрузка формы и восстановление данных типа Flight <see cref="Flight"/> из файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadFile();
            foreach (Flight flight in _flights)
            {
                FlightsListBox.Items.Add(flight);
            }
        }

        /// <summary>
        /// Отображает данные полей объекта FLight <see cref="Flight"/> при смене индекса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;

            if (FlightsListBox.SelectedIndex != -1)
            {
                _currentFlight = _flights[FlightsListBox.SelectedIndex];

                if (_currentFlight != null)
                {
                    DeparturePointTextBox.Text = _currentFlight.DeparturePoint.ToString();
                    DestinationTextBox.Text = _currentFlight.Destination.ToString();
                    FlightTimePicker.Value = _currentFlight.DepartureTime.ToLocalTime();
                    FlightTimeTextBox.Text = _currentFlight.FlightTime.ToString();
                    FlightTypeComboBox.Text = _currentFlight.TypeOfFlight.ToString();

                }
            }
        }

        /// <summary>
        /// Сохраняет новое значение поля _departurePoint.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeparturePointTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentFlight != null)
                {
                    string departure = DeparturePointTextBox.Text;
                    Regex regex = new Regex(@"^[^0-9]*$");

                    if (departure.Length > 100 || departure.Length < 0 || !regex.IsMatch(departure)) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("String's lenght must be between 1 and 100 and not contains digits.");
                    }

                    _currentFlight.DeparturePoint = departure;
                    Update_FlightsListBox();
                    DeparturePointTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                DeparturePointTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                DeparturePointTextBox.BackColor = AppColors.ValidationFalseColor;   // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        /// <summary>
        /// Сохраняет новое значение поля _destination.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentFlight != null)
                {
                    string destination = DestinationTextBox.Text;
                    Regex regex = new Regex(@"^[^0-9]*$");

                    if (destination.Length > 100 || destination.Length < 0 || !regex.IsMatch(destination)) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("String's lenght must be between 1 and 100 and not contains digits.");
                    }

                    _currentFlight.Destination = destination;
                    Update_FlightsListBox();
                    DestinationTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                DestinationTextBox.BackColor = AppColors.ValidationFalseColor; // Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                DestinationTextBox.BackColor = AppColors.ValidationFalseColor;  // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        /// <summary>
        /// Сохраняет новое значение поля _flightTime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentFlight != null)
                {
                    int flightTime = int.Parse(FlightTimeTextBox.Text);

                    if (flightTime > 1000 || flightTime < 0) // Пример допустимого диапазона значений
                    {
                        throw new ArgumentOutOfRangeException("String's lenght must be between 1 and 100 and not contains digits.");
                    }

                    _currentFlight.FlightTime = flightTime;
                    Update_FlightsListBox();
                    FlightTimeTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                FlightTimeTextBox.BackColor = AppColors.ValidationFalseColor;// Подсветка красным цветом при ошибке формата числа
            }
            catch (ArgumentOutOfRangeException)
            {
                FlightTimeTextBox.BackColor = AppColors.ValidationFalseColor;  // Подсветка красным цветом при выходе значения за допустимый диапазон
            }
        }

        /// <summary>
        /// Создает новый объект типа Flight <see cref="Flight"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string[] sities = new string[10] { "Moskow", "Ufa", "St.-Peterburg", "Ekaterinburg", "Samara", "Saratov", "Perm'", "Astana", "Karaganda", "Kaliningrad" };
            int firstPoint = random.Next(0, 10);
            int secondPoint = random.Next(0, 10);
            int typeOfFlight = random.Next(0, 2);
            int timeOfFlight = random.Next(20, 1000);

            int month = random.Next(1, 12);
            int day = random.Next(1, 30);
            int hour = random.Next(1, 24);
            int minute = random.Next(1, 60);
            int second = random.Next(1, 60);
            DateTime date = new DateTime(2024, month, day, hour, minute, second);

            Flight newFlight = new Flight(sities[firstPoint], sities[secondPoint], date, timeOfFlight, (TypeOfFlight)typeOfFlight);
            _flights.Add(newFlight);
            SortFlightsByDateTime(_flights);
            Update_FlightsListBox();
        }

        /// <summary>
        /// Удаляет запись об объекте типа Flight <see cref="Flight"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                _flights.RemoveAt(selectedIndex);
                FlightsListBox.Items.RemoveAt(selectedIndex);
                Update_FlightsListBox();

                DeparturePointTextBox.Text = "";
                DestinationTextBox.Text = "";
                FlightTimePicker.Value = DateTime.Now;
                FlightTimeTextBox.Text = "";
                FlightTypeComboBox.SelectedIndex = 0;

                DeparturePointTextBox.BackColor = AppColors.ValidationTrueColor;
                DestinationTextBox.BackColor = AppColors.ValidationTrueColor;
                FlightTimeTextBox.BackColor = AppColors.ValidationTrueColor;
            }
        }

        /// <summary>
        /// Обновляет список записей.
        /// </summary>
        private void Update_FlightsListBox()
        {
            FlightsListBox.Items.Clear();
            foreach (Flight flight in _flights)
            {
                FlightsListBox.Items.Add($"{flight.DepartureTime}: {flight.DeparturePoint}-{flight.Destination}");
            }
        }

        /// <summary>
        /// Сортирует записи о полете по дате и времени вылета.
        /// </summary>
        /// <param name="flights"></param>
        public void SortFlightsByDateTime(List<Flight> flights)
        {
            flights.Sort((x, y) => DateTime.Compare(x.DepartureTime, y.DepartureTime));
        }

        /// <summary>
        /// Считывает записи из файла.
        /// </summary>
        private void ReadFile()
        {
            try
            {
                using (FileStream fs = new FileStream("flights.json", FileMode.Open))
                {
                    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Flight>));
                    // Десериализация JSON данных из файла в список
                    _flights = (List<Flight>)deserializer.ReadObject(fs);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        /// <summary>
        /// Сохраняет записи в файл при закрытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "flights.json");
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при удалении файла");
            }
            WriteOnFile();
        }
    }
}