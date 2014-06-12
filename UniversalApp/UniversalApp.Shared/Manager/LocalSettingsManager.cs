using System.Diagnostics;
using Windows.Storage;

namespace UniversalApp.Manager
{
    public partial class LocalSettingsManager
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
#if WINDOWS_APP
            Debug.WriteLine("Parameter Set on Windows RT");
#elif WINDOWS_PHONE_APP
            Debug.WriteLine("Parameter Set on Windows Phone");
#endif
            //TODO a lot of things
        }
    }
}
