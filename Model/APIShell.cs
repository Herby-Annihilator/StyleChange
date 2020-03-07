using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using StyleChange.Model.SPIParameters;

namespace StyleChange.Model
{

    /// <summary>
    /// Оболочка над win32api
    /// </summary>
    [Serializable]
    public static class APIShell
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        /// <summary>
        /// Изменяет обои рабочего стола на те, что указаны в пути до файла (path). Расширение картинки .bmp
        /// </summary>
        /// <param name="path">Путь к файлу *.bmp</param>
        public static void ChangeDesktopWallpapers(string path)
        {
            SystemParametersInfo(DesktopParameters.SetDeskWallpaper, 0, path, UpdatingParameters.UpdateINIFile | UpdatingParameters.UpdateINIFile);
        }


    } 

}
