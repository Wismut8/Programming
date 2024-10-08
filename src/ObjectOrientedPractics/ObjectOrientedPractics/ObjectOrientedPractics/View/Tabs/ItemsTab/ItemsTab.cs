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
using System.Xml.Linq;
using static ObjectOrientedPractics.Services.AppColors;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        //добавление закрытого массива объектов типа Item
        private List<Item> _items;
        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
            _items = new List<Item>();
            _currentItem = new Item("", "", 0);
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Отображает данные полей объекта Item <see cref="Item"/> при смене индекса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;

            if (ItemsListBox.SelectedIndex != -1)
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];

                if (_currentItem != null)
                {
                    ItemIDTextBox.Text = _currentItem.Id.ToString();
                    ItemNameTextBox.Text = _currentItem.Name.ToString();
                    ItemCostTextBox.Text = _currentItem.Cost.ToString();
                    ItemDescriptionTextBox.Text = _currentItem.Info.ToString();

                }
            }
        }

        /// <summary>
        /// Сохраняет новое значение поля _cost.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentItem != null)
                {
                    double cost = double.Parse(ItemCostTextBox.Text);

                    _currentItem.Cost = cost;
                    Update_ItemsListBox();
                    ItemCostTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                ItemCostTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// Сохраняет новое значение поля _name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentItem != null)
                {
                    string name = ItemNameTextBox.Text;

                    _currentItem.Name = name;
                    Update_ItemsListBox();
                    ItemNameTextBox.BackColor = AppColors.ValidationTrueColor;
                }
            }
            catch (FormatException)
            {
                ItemCostTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        private void ItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentItem != null)
                {
                    string description = ItemDescriptionTextBox.Text;

                    _currentItem.Info = description;
                    Update_ItemsListBox();
                    ItemDescriptionTextBox.BackColor = AppColors.ValidationTrueColor; // Установка обычного белого цвета фона
                }
            }
            catch (FormatException)
            {
                ItemCostTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        /// <summary>
        /// Обновляет список записей.
        /// </summary>
        private void Update_ItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }
        }

        /// <summary>
        /// Сортирует записи о товарах по названию.
        /// </summary>
        public void SortItemsByName(List<Item> items)
        {
            items.Sort((x, y) => string.Compare(x.Name, y.Name));
        }

        /// <summary>
        /// Создает новый объект типа Item <see cref="Item"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string[] names = new string[10] { "fan", "mixer", "toaster", "meat grinder", "skillet", "dishwasher", "microwave oven", "frige", "vacuum cleaner", "sewing-machine" };
            int cost = random.Next(1000, 100000);
            int randomNameIndex = random.Next(0, 10);


            Item newItem = new Item(names[randomNameIndex], "", cost);
            _items.Add(newItem);
            SortItemsByName(_items);
            Update_ItemsListBox();
        }

        /// <summary>
        /// Удаляет запись об объекте типа Item <see cref="Item"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                _items.RemoveAt(selectedIndex);
                ItemsListBox.Items.RemoveAt(selectedIndex);
                Update_ItemsListBox();

                ItemIDTextBox.Text = "";
                ItemNameTextBox.Text = "";
                ItemDescriptionTextBox.Text = "";
                ItemCostTextBox.Text = "0.0";


                ItemNameTextBox.BackColor = AppColors.ValidationTrueColor;
                ItemDescriptionTextBox.BackColor = AppColors.ValidationTrueColor;
                ItemCostTextBox.BackColor = AppColors.ValidationTrueColor;
            }
        }

    }
}
