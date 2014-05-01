
namespace PCL_S.Manager
{
    public interface ISettingsWriter
    {
        void Set(string key, string value);

        string Message { get; }
    }
}
