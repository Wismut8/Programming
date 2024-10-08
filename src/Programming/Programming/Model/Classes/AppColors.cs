using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
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
        /// <summary>
        /// Цвет непересекающейся panel.
        /// </summary>
        public static readonly Color CollisionTrue = Color.FromArgb(127, 255, 127, 127);
        /// <summary>
        /// Цвет Panel, имеющей общие точки с другими Panels.
        /// </summary>
        public static readonly Color CollisionFalse = Color.FromArgb(127, 127, 255, 127);
    }
}
