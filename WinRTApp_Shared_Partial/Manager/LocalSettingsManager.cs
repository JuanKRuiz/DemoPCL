using Windows.Storage;

namespace WinRTApp_Shared_Partial.Manager
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

        partial void Audit();
    }
}
