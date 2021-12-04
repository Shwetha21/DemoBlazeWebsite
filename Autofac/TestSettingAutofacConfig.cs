using Autofac;
using DemoBlazeWebsite.Settings;
using Microsoft.Extensions.Configuration;

namespace DemoBlazeWebsite.Autofac
{
    public class TestSettingAutofacConfig : Module
    {
        private readonly IConfigurationRoot _configuration;

        public TestSettingAutofacConfig(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            var urlSettings = new UrlSettings();
            _configuration.GetSection("urls").Bind(urlSettings);
            builder.Register(configuration => urlSettings).AsSelf().SingleInstance();
        }
    }
}
