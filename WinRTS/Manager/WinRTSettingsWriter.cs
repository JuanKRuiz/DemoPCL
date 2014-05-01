using PCL_S.Manager;
using Windows.Storage;

namespace WinRTS.Manager
{
    class WinRTSettingsWriter : ISettingsWriter
    {
        public void Set(string key, string value)
        {
            ApplicationData.Current.LocalSettings.Values[key] = value;
        }

        public string Message
        {
            get { return "WinRT - Strategy"; }
        }
    }
}
