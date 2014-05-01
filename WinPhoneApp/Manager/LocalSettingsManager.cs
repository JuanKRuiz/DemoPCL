using System.Diagnostics;
using System.IO.IsolatedStorage;

namespace WinPhoneApp.Manager
{
    public class LocalSettingsManager
    {
        public void Set(string key, string value)
        {
            ValidateSecurity();
            IsolatedStorageSettings.ApplicationSettings[key] = value;
            Audit();
        }

        public void ValidateSecurity()
        {
            //TODO a lot of things
        }

        public void Audit()
        {
            Debug.WriteLine("Parameter Set on WindowsPhone");
            //TODO a lot of things
        }
    }
}
