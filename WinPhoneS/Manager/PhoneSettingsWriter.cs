using PCL_S.Manager;
using System.IO.IsolatedStorage;

namespace WinPhoneS.Manager
{
    class PhoneSettingsWriter : ISettingsWriter
    {
        public void Set(string key, string value)
        {
            IsolatedStorageSettings.ApplicationSettings[key]=value;
        }

        public string Message
        {
            get
            { return "Windows Phone - Strategy"; }
        }
    }
}
