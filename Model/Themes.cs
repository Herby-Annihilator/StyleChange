using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleChange.Model
{
    /// <summary>
    /// Целиком отвечает за стилизацию темы
    /// </summary>
    [Serializable]
    public class Themes
    {
        public VisualEffects VisualEffects { get; private set; }

        public void AddEffect(VisualEffects visualEffects)
        {
            VisualEffects |= visualEffects;
        }

        public void DeleteVisualEffect(VisualEffects visualEffects)
        {
            VisualEffects &= visualEffects;
        }

        public Colors Colors { get; set; }

        public Background Background { get; set; }
    }

    /// <summary>
    /// Определяет список визуальных эффектов
    /// </summary>
    [Serializable]
    [Flags]
    public enum VisualEffects: uint
    {
        None = 0x0,
        ComboBoxAnimation = 0x1,

        All = 0xffffffff,
    }
}
