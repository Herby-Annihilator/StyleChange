using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Activities;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace StyleChange
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;
        static void Main(string[] args)
        {
            //RegistryKey key = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop", true);
            RegistryKey registry = Registry.CurrentUser.OpenSubKey(@"Control Panel\\Desktop", true);
            string[] str = registry.GetValueNames();
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            //registry.SetValue("Wallpaper", "C:\\Users\\Данил\\Рабочий стол темы\\Светлая\\2.bmp");
            //registry.SetValue("PrevWallpaper", "C:\\Users\\Данил\\Рабочий стол темы\\Светлая\\2.bmp");


           // registry.SetValue("ButtonFace", "255 255 255"); // prev = 212 208 200
            registry.Close();

            
            SystemParametersInfo(SPI_SETDESKWALLPAPER,
            0,
            "C:\\Users\\Данил\\Рабочий стол темы\\Светлая\\1.bmp",
            SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

            
            Console.ReadKey(true);
        }
    }
}
