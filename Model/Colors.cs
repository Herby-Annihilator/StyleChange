using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleChange.Model
{
    [Serializable]
    public class Colors
    {
        /// <summary>
        /// Прозрачность
        /// </summary>
        private int transparency;

        /// <summary>
        /// Возвращает или задает прозрачность
        /// </summary>
        public int Transparency
        {
            get
            {
                return transparency;
            }

            set
            {
                if (value > 255)
                {
                    transparency = 255;
                }
                else if (value < 0)
                {
                    transparency = 0;
                }
                else
                {
                    transparency = value;
                }
            }
        }

        /// <summary>
        /// Задает цвет поверхностей Windows
        /// </summary>
        public ColorStyle ColorStyle { get; set; }

        private string hexColor;

        public void SetHexColor(string hexColor)
        {
            if (hexColor.Length > 7 || hexColor.Length < 7)
            {
                this.hexColor = "#ffffff";
                return;
            }
            if (hexColor[0] != '#')
            {
                this.hexColor = string.Concat("#", hexColor.Remove(0, 1));
            }
        }

        public Colors()
        {
            ColorStyle = ColorStyle.Light;
            SetHexColor("#ffffff");
            Transparency = 255;
        }

        public Colors(ColorStyle colorStyle, string hexColor, int transparency)
        {

        }
    }

    /// <summary>
    /// Содержит возможные цвета поверхностей Windows
    /// </summary>
    [Serializable]
    public enum ColorStyle
    {
        /// <summary>
        /// Темный
        /// </summary>
        Dark,

        /// <summary>
        /// Светлый
        /// </summary>
        Light,

        /// <summary>
        /// Пользовательский
        /// </summary>
        UserStyle,
    }
}
