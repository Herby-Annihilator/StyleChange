using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleChange.Model.SPIParameters
{
    /// <summary>
    /// Параметры доступа для SystemParametersInfo
    /// </summary>
    [Serializable]
    internal static class AccessibilityParameters
    {
        public const int GetAccessTimeout = 0x003C;

        public const int GetAudioDescription = 0x0074;

        public const int GetClientAreaAnimation = 0x1042;

        public const int GetDisableOverLappedContent = 0x1040;

        public const int GetFiltersKey = 0x0032;

        public const int GetFocusBorderHeight = 0x2010;

        public const int GetFocusBorderWidth = 0x200E;

        public const int GetHightContrast = 0x0042;

        public const int GetLogicalDPIOverride = 0x009E;

        public const int GetMessageDuration = 0x2016;

        public const int GetMouseClickLock = 0x101E;

        public const int GetMouseClickLockTime = 0x2008;

        public const int GetMouseKeys = 0x0036;

        public const int GetMouseSonar = 0x101C;

        public const int GetMouseVanish = 0x1020;

        public const int GetScreenReader = 0x0046;

        public const int GetSerialKeys = 0x003E;

        public const int GetShowSounds = 0x0038;

        public const int GetSoundSentry = 0x0040;

        public const int GetStickyKeys = 0x003A;

        public const int GetToggleKeys = 0x0034;

        public const int SetAccessTimeout = 0x003D;

        public const int SetAudioDescription = 0x0075;

        public const int SetClientAreaAnimation = 0x1043;

        public const int SetDisableOverLappedContent = 0x1041;

        public const int SetFilterKeys = 0x0033;

        public const int SetFocusBorderHeight = 0x2011;

        public const int SetFocusBorderWeight = 0x200F;

        public const int SetHightContrast = 0x0043;

        public const int SetLogicalDPIOverride = 0x009F;

        public const int SetMessageDuration = 0x2017;

        public const int SetMouseClickLock = 0x101F;

        public const int SetMouseClickLockTime = 0x2009;

        public const int SetMouseKeys = 0x0037;

        public const int SetMouseSonar = 0x101D;

        public const int SetMouseVanish = 0x1021;

        public const int SetScreenReader = 0x0047;

        public const int SetSerialKeys = 0x003F;

        public const int SetShowSounds = 0x0039;

        public const int SetSoundSentry = 0x0041;

        public const int SetStickyKeys = 0x003B;

        public const int SetToggleKeys = 0x0035;

    }
}
