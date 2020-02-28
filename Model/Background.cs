using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleChange.Model
{
    [Serializable]
    public class Background
    {
        /// <summary>
        /// Путь до картинки
        /// </summary>
        private string path;

        /// <summary>
        /// Задает путь до картинки
        /// </summary>
        /// <param name="path"></param>
        public void SetPathToImage(string path)
        {
            this.path = path;

        }

        /// <summary>
        /// Возвращает текущий путь до картинки
        /// </summary>
        public string Path { get { return path; } }
        public BackgroundType BackgroundType { get; set; }

        public BackgroundStyle BackgroundStyle { get; set; }

        public Background()
        {
            path = null;
            BackgroundType = BackgroundType.Photo;
            BackgroundStyle = BackgroundStyle.FillingOut;
        }

        public Background(string path, BackgroundStyle style, BackgroundType type)
        {
            SetPathToImage(path);
            BackgroundStyle = style;
            BackgroundType = type;
        }
    }

    [Serializable]
    public enum BackgroundType
    {
        /// <summary>
        /// Фото
        /// </summary>
        Photo,

        /// <summary>
        /// Сплошной цвет
        /// </summary>
        SolidColor,

        /// <summary>
        /// Слайд-шоу
        /// </summary>
        SlideShow,
    }

    [Serializable]
    public enum BackgroundStyle
    {
        /// <summary>
        /// Заполнение
        /// </summary>
        FillingOut,

        /// <summary>
        /// По размеру
        /// </summary>
        ToSize,

        /// <summary>
        /// Растянуть
        /// </summary>
        Stretch,

        /// <summary>
        /// Замостить
        /// </summary>
        Pave,

        /// <summary>
        /// По центру
        /// </summary>
        InTheCenter,

        /// <summary>
        /// Расширение
        /// </summary>
        Expansion,
    }

}
