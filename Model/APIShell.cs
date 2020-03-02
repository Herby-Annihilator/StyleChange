using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace StyleChange.Model
{


    /// <summary>
    /// Оболочка над win32api
    /// </summary>
    [Serializable]
    internal static class APIShell
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;

        /// <summary>
        /// Изменяет обои рабочего стола на те, что указаны в пути до файла (path). Расширение картинки .bmp
        /// </summary>
        /// <param name="path">Путь к файлу *.bmp</param>
        public static void ChangeDesktopWallpapers(string path)
        {
            SystemParametersInfo((int)DesktopParameters.SetDeskWallpaper, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }

    /// <summary>
    /// Параметры доступа для SystemParametersInfo
    /// </summary>
    [Serializable]
    [Flags]
    public enum AccessibilityParameter /*: uint*/
    {
        GetAccessTimeout = 0x003C,

        GetAudioDescription = 0x0074,

        GetClientAreaAnimation = 0x1042,

        GetDisableOverLappedContent = 0x1040,

        GetFiltersKey = 0x0032,

        GetFocusBorderHeight = 0x2010,

        GetFocusBorderWidth = 0x200E,

        GetHightContrast = 0x0042,

        GetLogicalDPIOverride = 0x009E,

        GetMessageDuration = 0x2016,

        GetMouseClickLock = 0x101E,

        GetMouseClickLockTime = 0x2008,

        GetMouseKeys = 0x0036,

        GetMouseSonar = 0x101C,

        GetMouseVanish = 0x1020,

        GetScreenReader = 0x0046,

        GetSerialKeys = 0x003E,

        GetShowSounds = 0x0038,

        GetSoundSentry = 0x0040,

        GetStickyKeys = 0x003A,

        GetToggleKeys = 0x0034,

        SetAccessTimeout = 0x003D,

        SetAudioDescription = 0x0075,

        SetClientAreaAnimation = 0x1043,

        SetDisableOverLappedContent = 0x1041,

        SetFilterKeys = 0x0033,

        SetFocusBorderHeight = 0x2011,

        SetFocusBorderWeight = 0x200F,

        SetHightContrast = 0x0043,

        SetLogicalDPIOverride = 0x009F,

        SetMessageDuration = 0x2017,

        SetMouseClickLock = 0x101F,

        SetMouseClickLockTime = 0x2009,

        SetMouseKeys = 0x0037,

        SetMouseSonar = 0x101D,

        SetMouseVanish = 0x1021,

        SetScreenReader = 0x0047,

        SetSerialKeys = 0x003F,

        SetShowSounds = 0x0039,

        SetSoundSentry = 0x0041,

        SetStickyKeys = 0x003B,

        SetToggleKeys = 0x0035,
    }

    /// <summary>
    /// Параметры рабочего стола
    /// </summary>
    [Serializable]
    [Flags]
    public enum DesktopParameters 
    {
        /// <summary>
        /// Определяет, включен ли ClearType. Параметр pvParam должен указывать на переменную BOOL, которая получает TRUE, если ClearType включен, или FALSE в противном случае.
        /// ClearType - это программная технология, которая улучшает читаемость текста на жидкокристаллических дисплеях (ЖК-мониторах).
        /// Windows Server 2003 и Windows XP / 2000: этот параметр не поддерживается.
        /// </summary>
        GetClearType = 0x1048,

        /// <summary>
        /// Получает полный путь к растровому файлу для обоев рабочего стола.
        /// Параметр pvParam должен указывать на буфер для получения строки пути с нулевым символом в конце.
        /// Задайте для параметра uiParam размер в символах буфера pvParam.
        /// Возвращаемая строка не будет превышать MAX_PATH символов. Если обои для рабочего стола отсутствуют, возвращаемая строка пуста.
        /// </summary>
        GetDeskWallpaper = 0x0073,

        /// <summary>
        /// Определяет, включен ли эффект тени. Параметр pvParam должен указывать на переменную BOOL, которая возвращает TRUE, если включено, или FALSE, если отключено.
        /// Windows 2000: этот параметр не поддерживается.
        /// </summary>
        GetDropShadow = 0x1024,

        /// <summary>
        /// Определяет, имеют ли собственные меню пользователя плоский вид меню.
        /// Параметр pvParam должен указывать на переменную BOOL, которая возвращает TRUE, если задан внешний вид плоского меню, или FALSE в противном случае.
        /// Windows 2000: этот параметр не поддерживается.
        /// </summary>
        GetFlatMenu = 0x1022,

        /// <summary>
        /// Определяет, включена ли функция сглаживания шрифтов.
        /// Эта функция использует сглаживание шрифта, чтобы сделать кривые шрифта более плавными, рисуя пиксели на разных уровнях серого.
        /// Параметр pvParam должен указывать на переменную BOOL, которая получает значение ИСТИНА, если функция включена, или значение ЛОЖЬ, если это не так.
        /// </summary>
        GetFontSmoothing = 0x004A,

        /// <summary>
        /// Получает значение контрастности, которое используется в сглаживании ClearType. 
        /// Параметр pvParam должен указывать на UINT, который получает информацию. Допустимые значения контрастности: от 1000 до 2200. Значение по умолчанию - 1400.
        /// Windows 2000: этот параметр не поддерживается.
        /// </summary>
        GetFontSmoothingContrast = 0x200C,

        /// <summary>
        /// Получает ориентацию сглаживания шрифта. Параметр pvParam должен указывать на UINT, который получает информацию.
        /// Возможные значения: FE_FONTSMOOTHINGORIENTATIONBGR (синий-зеленый-красный) и FE_FONTSMOOTHINGORIENTATIONRGB (красный-зеленый-синий).
        /// Windows XP / 2000: этот параметр не поддерживается до Windows XP с пакетом обновления 2 (SP2).
        /// </summary>
        GetFontSmoothingOrientation = 0x2012,

        /// <summary>
        /// Получает тип сглаживания шрифта. Параметр pvParam должен указывать на UINT, который получает информацию. 
        /// Возможные значения: FE_FONTSMOOTHINGSTANDARD и FE_FONTSMOOTHINGCLEARTYPE.
        /// Windows 2000: этот параметр не поддерживается.
        /// </summary>
        GetFontSmoothingType = 0x200A,

        /// <summary>
        /// Получает размер рабочей области на основном мониторе.
        /// Рабочая область - это часть экрана, не скрытая системной панелью задач или панелями инструментов рабочего стола приложения.
        /// Параметр pvParam должен указывать на структуру RECT, которая получает координаты рабочей области, выраженные в физическом размере пикселя.
        /// Любой режим виртуализации DPI вызывающей стороны не влияет на этот вывод.
        /// Чтобы получить рабочую область монитора, отличного от основного монитора, вызовите функцию GetMonitorInfo.
        /// </summary>
        GetWorkArea = 0x0030,

        /// <summary>
        /// Включает или выключает ClearType. Параметр pvParam является переменной BOOL. 
        /// Установите для pvParam значение TRUE, чтобы включить ClearType, или FALSE, чтобы отключить его.
        /// ClearType - это программная технология, которая улучшает читаемость текста на ЖК-мониторах.
        /// Windows Server 2003 и Windows XP / 2000: этот параметр не поддерживается.
        /// </summary>
        SetClearType = 0x1049,

        /// <summary>
        /// Перезагрузка системы курсоров. Установите для параметра uiParam значение 0, а для параметра pvParam значение NULL.
        /// </summary>
        SetCursors = 0x0057,

        /// <summary>
        /// Устанавливает текущий шаблон рабочего стола, заставляя Windows читать параметр Pattern = из файла WIN.INI.
        /// </summary>
        SetDeskPattern = 0x0015,

        /// <summary>
        /// Примечание. Если используется флаг SPI_SETDESKWALLPAPER, 
        /// SystemParametersInfo возвращает значение ИСТИНА, если не возникает ошибка (например, когда указанный файл не существует).
        /// </summary>
        SetDeskWallpaper = 0x0014,

        /// <summary>
        /// Включает или отключает эффект тени. 
        /// Установите для pvParam значение TRUE, чтобы включить эффект тени, или FALSE, чтобы отключить его. Вы также должны иметь CS_DROPSHADOW в стиле класса окна.
        /// Windows 2000: этот параметр не поддерживается.
        /// </summary>
        SetDropShadow = 0x1025,

        /// <summary>
        /// Включает или отключает отображение плоского меню для собственных меню пользователя. 
        /// Установите для pvParam значение TRUE, чтобы включить отображение плоского меню, или FALSE, чтобы отключить его.
        /// Когда эта опция включена, строка меню использует COLOR_MENUBAR для фона меню, COLOR_MENU для фона всплывающего меню, 
        /// COLOR_MENUHILIGHT для заливки текущего выбора меню и COLOR_HILIGHT для контура текущего выбора меню. 
        /// Если этот параметр отключен, меню отображаются с использованием тех же показателей и цветов, что и в Windows 2000.
        /// Windows 2000: этот параметр не поддерживается.
        /// </summary>
        SetFlatMenu = 0x1023,

        /// <summary>
        /// Включает или отключает функцию сглаживания шрифтов, которая использует сглаживание шрифтов,
        /// чтобы кривые шрифты выглядели более сглаженными, рисуя пиксели на разных уровнях серого.
        /// Чтобы включить эту функцию, установите для параметра uiParam значение TRUE. 
        /// Чтобы отключить эту функцию, установите для параметра uiParam значение FALSE.
        /// </summary>
        SetFontSmoothing = 0x004B,

        /// <summary>
        /// Устанавливает значение контрастности, используемое в сглаживании ClearType.
        /// Параметр pvParam является значением контрастности. Допустимые значения контрастности: от 1000 до 2200. Значение по умолчанию - 1400.
        /// SPI_SETFONTSMOOTHINGTYPE также должен быть установлен в FE_FONTSMOOTHINGCLEARTYPE.
        /// Windows 2000: этот параметр не поддерживается.
        /// </summary>
        SetFontSmoothingContrast = 0x200D,

        /// <summary>
        /// Устанавливает ориентацию сглаживания шрифта. 
        /// Параметр pvParam имеет значение FE_FONTSMOOTHINGORIENTATIONBGR (сине-зелено-красный) или FE_FONTSMOOTHINGORIENTATIONRGB (красно-зелено-синий).
        /// Windows XP / 2000: этот параметр не поддерживается до Windows XP с пакетом обновления 2 (SP2).
        /// </summary>
        SetFontSmoothingOrientation = 0x2013,

        /// <summary>
        /// Устанавливает тип сглаживания шрифта. 
        /// Параметр pvParam имеет значение FE_FONTSMOOTHINGSTANDARD, если используется стандартное сглаживание,
        /// или FE_FONTSMOOTHINGCLEARTYPE, если используется ClearType. Значением по умолчанию является FE_FONTSMOOTHINGSTANDARD.
        /// SPI_SETFONTSMOOTHING также должен быть установлен.
        /// Windows 2000: этот параметр не поддерживается.
        /// </summary>
        SetFontSmoothingType = 0x200B,

        /// <summary>
        /// Устанавливает размер рабочей области.
        /// Рабочая область - это часть экрана, не скрытая системной панелью задач или панелями инструментов рабочего стола приложения.
        /// Параметр pvParam является указателем на структуру RECT, которая задает новый прямоугольник рабочей области,
        /// выраженный в координатах виртуального экрана. В системе с несколькими мониторами дисплея функция устанавливает рабочую область монитора,
        /// которая содержит указанный прямоугольник.
        /// </summary>
        SetWorkArea = 0x002F,
    }


    [Serializable]
    [Flags]
    public enum IconParameters
    {

    }
}
