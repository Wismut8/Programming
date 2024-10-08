using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    [DataContract]
    public class Customer
    {
        /// <summary>
        /// Хранит количество созданных объектов покупателей.
        /// </summary>
        private static int _allCustomersCount = -2;
        /// <summary>
        /// Хранит id покупателя.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Хранит полное имя (Фамилия Имя Отчество).
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Хранит адрес доставки до покупателя.
        /// </summary>
        private string _adress;

        /// <summary>
        /// Возвращает ID.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает количество созданных экземпляров прямоугольников.
        /// </summary>
        /// <returns>Количество прямоугольников.</returns>
        public static int AllCustomersCount()
        {
            return _allCustomersCount;
        }

        ///<summary>
        ///Возвращает и задает полное имя покупателя. Длина строки не более 200 символов
        ///</summary>
        [DataMember]
        public string FullName
        {
            get { return _fullName; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "FullName");
                _fullName = value;
            }
        }

        ///<summary>
        ///Возвращает и задает адрес доставки. Длина строки не более 500 символов
        ///</summary>
        [DataMember]
        public string Adress
        {
            get { return _adress; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Adress");
                _adress = value;
            }
        }

        /// <summary>
        /// Создает экземпляр покупателя. <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">Полное имя. Не более 200 символов.</param>
        /// <param name="adress">Аресс доставки. Не более 500 символов.</param>
        public Customer(string fullname, string adress)
        {
            FullName = fullname;
            _adress = adress;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        public Customer() { }
    }
}
