using Autofac;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlow.Autofac;
using System;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;

namespace DemoBlazeWebsite.Autofac
{
    public class TestDependencies
    {
        [ScenarioDependencies]
        public static ContainerBuilder Container()
        {
            var builder = new ContainerBuilder();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile($"{Directory.GetCurrentDirectory()}/configs/config.json", optional: false, reloadOnChange: true)
                .Build();

            builder.RegisterModule(new TestSettingAutofacConfig(configuration));
            builder.RegisterTypes(typeof(TestDependencies).Assembly.GetTypes()
                .Where(t => Attribute.IsDefined(t, typeof(BindingAttribute))).ToArray()).SingleInstance();

            IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory());
            builder.Register(c => driver).AsSelf().SingleInstance();

            return builder;
        }

    }
}
