using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyleChange.Controllers.Executors;

namespace StyleChange.Model.Commands
{
    public class ChangeWallpaperCommand : Command
    {
        /// <summary>
        /// Исполнитель, меняющий заставку рабочего стола
        /// </summary>
        private ChangeWallpaperExecutor changeWallpaper;
        public override string CommandText
        {
            get
            {
                return "change wallpaper <path *.bmp>";
            }
        }

        public override bool Execute()
        {
            CreateSnapshot();
            return changeWallpaper.ChangeWallpaper(PathToImage);
        }

        public ChangeWallpaperCommand(string path)
        {
            Executors = new Executor[] { changeWallpaper };
            PathToImage = path;
            // можно добавить установку дефолтного пути до файла в конструкторе без параметров
        }

        /// <summary>
        /// Возвращает или задает путь до картинки, которая будет поставлена на обои рабочего стола
        /// </summary>
        public string PathToImage { get; private set; }

        protected override void CreateSnapshot()
        {
            // читаем данны из реестра через объект, отвечающий за реестр
            throw new NotImplementedException();
        }
    }
}
