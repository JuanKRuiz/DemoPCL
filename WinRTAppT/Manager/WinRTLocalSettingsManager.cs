using PCL_T.Manager;
using Windows.Storage;

namespace WinRTAppT.Manager
{
    class WinRTLocalSettingsManager: LocalSettingsManager
    {
        public override void WriteSetting(string key, string value)
        {
            ApplicationData.Current.LocalSettings.Values[key] = value;
        }

        public override string Message
        { get { return "WinRT - Template Method"; } }
    }
}
