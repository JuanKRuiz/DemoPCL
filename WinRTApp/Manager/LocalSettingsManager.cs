using System.Diagnostics;
using Windows.Storage;

namespace WinRTApp.Manager
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

        public void Audit()
        {
            Debug.WriteLine("Parameter Set on WinRT");
            //TODO a lot of things
        }
    }
}
