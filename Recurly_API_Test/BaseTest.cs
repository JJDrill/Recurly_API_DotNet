using System.Configuration;

namespace Recurly_API_Test
{
    public abstract class BaseTest
    {

        protected BaseTest()
        {
            var recurlyApiKey = ConfigurationManager.AppSettings["recurlyApiKey"];
            var recurlySubdomain = ConfigurationManager.AppSettings["recurlySubdomain"];
            Recurly.Configuration.SettingsManager.Initialize(recurlyApiKey, recurlySubdomain);
        }

    }
}
