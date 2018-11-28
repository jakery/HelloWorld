namespace HelloWorld.Api
{
    public class Settings : ISettings
    {
        private const string defaultParadigmKey = "defaultParadigm";

        public string defaultParadigm => System.Configuration.ConfigurationManager.AppSettings[defaultParadigmKey];
    }
}