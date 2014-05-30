using System.Diagnostics;
using Windows.Storage;

namespace WinRTApp_Shared_IF.Manager
{
    public class LocalSettingsManager
    {
        public void Set(string key, string value)
        {
            ValidateSecurity();
            ApplicationData.Current.LocalSettings.Values[key] = value;
            Audit();
        }

        public void ValidateSecurity()
        {
            //TODO a lot of things
        }

#if WINDOWS_APP
        public void Audit()
        {
            Debug.WriteLine("Parameter Set on WinRT");
            //TODO a lot of things
        }
#elif WINDOWS_PHONE
        public void Audit()
        {
            Debug.WriteLine("Parameter Set on Windows Phone");
            //TODO a lot of things
        }
#endif
    }
}
