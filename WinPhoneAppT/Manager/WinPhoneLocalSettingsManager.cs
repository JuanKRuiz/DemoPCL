using PCL_T.Manager;
using System.IO.IsolatedStorage;

namespace WinPhoneAppT.Manager
{
    class WinPhoneLocalSettingsManager : LocalSettingsManager
    {
        public override void WriteSetting(string key, string value)
        {
            IsolatedStorageSettings.ApplicationSettings[key] = value;
        }

        //public override string Message
        //{ get { return "Windows Phone - Template Method"; } }

        //public override string Message
        //{ get { return base.Message + ": Windows Phone - Template Method"; } }
    }
}
