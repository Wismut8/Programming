using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ObjectOrientedPractics.Services.AppColors;

namespace ObjectOrientedPractics.View.Tabs.CustomersTab
{
    public partial class CustomersTab : UserControl
    {
        //добавление закрытого массива объектов типа Customer
        private List<Customer> _customers;
        private Customer _currentCustomer;
        public CustomersTab()
        {
            InitializeComponent();
            _customers = new List<Customer>();
            _currentCustomer = new Customer("", "");
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Отображает данные полей объекта Customer <see cref="Customer"/> при смене индекса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;

            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];

                if (_currentCustomer != null)
                {
                    CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
                    CustomerNameTextBox.Text = _currentCustomer.FullName.ToString();
                    CustomerAdressTextBox.Text = _currentCustomer.Adress.ToString();

                }
            }
        }

        /// <summary>
        /// Обновляет список записей.
        /// </summary>
        private void Update_CustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.FullName}");
            }
        }

        /// <summary>
        /// Сортирует записи о товарах по названию.
        /// </summary>
        public void SortCustomersByName(List<Customer> customers)
        {
            customers.Sort((x, y) => string.Compare(x.FullName, y.FullName));
        }

        /// <summary>
        /// Сохраняет новое значение поля FullName.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentCustomer != null)
                {
                    string name = CustomerNameTextBox.Text;

                    _currentCustomer.FullName = name;
                    Update_CustomersListBox();
                    CustomerNameTextBox.BackColor = AppColors.ValidationTrueColor;
                }
            }
            catch (FormatException)
            {
                CustomerNameTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        private void CustomerAdressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentCustomer != null)
                {
                    string adress = CustomerAdressTextBox.Text;

                    _currentCustomer.Adress = adress;
                    Update_CustomersListBox();
                    CustomerAdressTextBox.BackColor = AppColors.ValidationTrueColor;
                }
            }
            catch (FormatException)
            {
                CustomerAdressTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// Создает новый объект типа Customer <see cref="Customer">
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string[] names = new string[5] { "Alex", "Bob", "Oliver", "Oscar", "Jacob" };
            string[] secondNames = new string[5] { "Smith", "Johnson", "Williams", "Brown", "Miller" };
            int randomNameIndex = random.Next(0, 5);
            int randomSecondNameIndex = random.Next(0, 5);


            Customer newCustomer = new Customer(names[randomNameIndex] + " " + secondNames[randomSecondNameIndex], "");
            _customers.Add(newCustomer);
            SortCustomersByName(_customers);
            Update_CustomersListBox();
        }

        /// <summary>
        /// Удаляет запись об объекте типа Customer <see cref="Customer"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);
                Update_CustomersListBox();

                CustomerIDTextBox.Text = "";
                CustomerNameTextBox.Text = "";
                CustomerAdressTextBox.Text = "";

                CustomerNameTextBox.BackColor = AppColors.ValidationTrueColor;
                CustomerAdressTextBox.BackColor = AppColors.ValidationTrueColor;
            }
        }
    }
}
