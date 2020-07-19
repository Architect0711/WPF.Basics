using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF.Basics.Extensions.Color
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Converts a <see cref="System.Drawing.Color"/> and converts it to ARGB to create a new <see cref="SolidColorBrush"/>
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static SolidColorBrush ToSolidColorBrush(this System.Drawing.Color color)
        {
            return new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
        }

        /// <summary>
        /// Converts a <see cref="System.Drawing.Color"/> and converts it to ARGB to create a new <see cref="System.Windows.Media.Color"/>
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static System.Windows.Media.Color ToMediaColor(this System.Drawing.Color color)
        {
            return System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
}
