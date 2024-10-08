using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит данные о цветах приложения.
    /// </summary>
    public static class AppColors
        {
        /// <summary>
        /// Цвет TextBox при успешной валидации.
        /// </summary>
        public static readonly Color ValidationTrueColor = Color.White;
        /// <summary>
        /// Цвет TextBox при возникновении исключений.
        /// </summary>
        public static readonly Color ValidationFalseColor = Color.LightPink;
    }
    
}
