using Bogus;
using DemoBlazeWebsite.Models;

namespace DemoBlazeWebsite.Testdata
{
    public static class CredentialsTestData
    {
        public static Credentials GetName()
        {
            var credentials = new Faker<Credentials>(locale: "en_GB")
                .RuleFor(model => model.UserName, faker => faker.Person.UserName)
                .RuleFor(model => model.PassWord, faker => faker.Random.Word());

            return credentials.Generate();
        }
    }
}
