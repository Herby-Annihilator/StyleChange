using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Activities;
using System.Configuration;
using System.Windows.Forms;

namespace StyleChange
{
    class Program
    {
        static void Main(string[] args)
        {

           


            RegistryKey key = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop", true);
            RegistryKey registry = Registry.CurrentUser.OpenSubKey(@"Control Panel\\Desktop", true);
            string[] str = registry.GetValueNames();
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            registry.SetValue("Wallpaper", "C:\\Users\\User\\Desktop\\Учебники\\1 курс\\Officia_l_Windows_10.jpg");
            registry.SetValue("PrevWallpaper", "C:\\Users\\User\\Desktop\\Учебники\\1 курс\\Officia_l_Windows_10.jpg");
            registry.Close();
            
            Console.ReadKey(true);
        }
    }
}
