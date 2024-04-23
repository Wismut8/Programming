using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class AppColors
    {
        public static readonly Color ValidationTrueColor = Color.White;
        public static readonly Color ValidationFalseColor = Color.LightPink;
        public static readonly Color CollisionTrue = Color.FromArgb(127, 255, 127, 127);
        public static readonly Color CollisionFalse = Color.FromArgb(127, 127, 255, 127);
    }
}
