using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    [DataContract]
    public class Item
    {
        /// <summary>
        /// Хранит количество созданных экземпляров товаров.
        /// </summary>
        private static int _allItemsCount = -2;
        /// <summary>
        /// Хранит id товара.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Хранит название.
        /// </summary>
        private string _name;
        /// <summary>
        /// Хранит описание.
        /// </summary>
        private string _info;
        /// <summary>
        /// Хранит данные о стоимости.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает ID.
        /// </summary>
        public int Id 
        { 
            get {  return _id; }
        }

        /// <summary>
        /// Возвращает количество созданных экземпляров прямоугольников.
        /// </summary>
        /// <returns>Количество прямоугольников.</returns>
        public static int AllItemsCount()
        {
            return _allItemsCount;
        }

        ///<summary>
        ///Возвращает и задает название. Длина строки не более 200 символов
        ///</summary>
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        ///<summary>
        ///Возвращает и задает описание. Длина строки не более 1000 символов
        ///</summary>
        [DataMember]
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость. Не может быть отрицательной.
        /// </summary>
        [DataMember]
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Стоимость не может быть отрицательной.");
                }
                else
                {
                    _cost = value;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр товара. <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название. Не более 200 символов.</param>
        /// <param name="info">Описание. Не более 1000 символов.</param>
        /// <param name="cost">Стоимость. Только положительное значение.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _allItemsCount++;
            _id = _allItemsCount;
        }

        public Item() { }
    }

}

