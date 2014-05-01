using System.Diagnostics;

namespace PCL_T.Manager
{
    public abstract class LocalSettingsManager
    {
        public void Set(string key, string value)
        {
            ValidateSecurity();
            WriteSetting(key, value);
            Audit();
        }

        public void ValidateSecurity()
        {
            //TODO a lot of things
        }

        public void Audit()
        {
            Debug.WriteLine("Parameter Set on {0}", this.Message);
            //TODO a lot of things
        }

        public abstract void WriteSetting(string key, string value);

        public virtual string Message { get{return "[Generic]";} }
    }
}
