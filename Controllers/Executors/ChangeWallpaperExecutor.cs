using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyleChange.Model;

namespace StyleChange.Controllers.Executors
{
    public class ChangeWallpaperExecutor : Executor
    {
        public ChangeWallpaperExecutor()
        {
            Name = "Wallpaper Changer";
        }

        /// <summary>
        /// Изменяет обои рабочего стола на те, что указаны в пути до файла (path). Расширение картинки .bmp
        /// </summary>
        /// <param name="path">Путь к файлу *.bmp</param>
        /// <returns></returns>
        public bool ChangeWallpaper(string path)
        {
            try
            {
                APIShell.ChangeDesktopWallpapers(path);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
