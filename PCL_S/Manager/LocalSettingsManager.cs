using System.Diagnostics;

namespace PCL_S.Manager
{
    public class LocalSettingsManager
    {
        public ISettingsWriter Writer { get; set; }
        
        public LocalSettingsManager(ISettingsWriter writer)
        {
            Writer = writer;
        }

        public void Set(string key, string value)
        {
            ValidateSecurity();
            Writer.Set(key, value);
            Audit();
        }

        public void ValidateSecurity()
        {
            //TODO a lot of things
        }

        public void Audit()
        {
            Debug.WriteLine("Parameter Set on {0}", Writer.Message);
            //TODO a lot of things
        }
    }
}
