using Bogus;
using DemoBlazeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoBlazeWebsite.Testdata
{
    public class CustomerTestData
    {
        public static Customer GetName()
        {
            var customer = new Faker<Customer>(locale: "en_GB")
                .RuleFor(model => model.Name, faker => faker.Person.FullName)
                .RuleFor(model => model.Country, faker => faker.Address.Country())
                .RuleFor(model => model.City, faker => faker.Address.City())
                .RuleFor(model => model.CreditCard, faker => faker.Finance.CreditCardNumber())
                .RuleFor(model => model.Month, faker => faker.Date.Future().Month)
                .RuleFor(model => model.Year, faker => faker.Date.Future().Year);

            return customer.Generate();
        }
    }
}
