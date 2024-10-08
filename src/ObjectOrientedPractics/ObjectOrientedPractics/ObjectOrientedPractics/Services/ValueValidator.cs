using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Проверяет выполнение условия.
    /// </summary>
    public class ValueValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="maxLength">Ограничение строки на кол-во символов</param>
        /// <param name="propertyName">Название проверяемого свойства</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new Exception($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }
    }
}
