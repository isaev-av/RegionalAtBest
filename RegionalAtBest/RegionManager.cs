using RegionalAtBest.Factories;
using RegionalAtBest.Interfaces;
using System;
using System.Collections.Generic;
using ***REMOVED***;

namespace RegionalAtBest
{
    /// <summary>
    /// Manager for operation with region options
    /// </summary>
    class RegionManager
    {
        string Region { get; set; }

        IAbstractFactory Factory;

        IBiggestCompany company;
        ICapital capital;
        ICurrency currency;
        IFlagColors flagColors;
        IFoundationYear foundationYear;
        IGreetings greetings;
        ILanguage language;
        IMostPopularReligion mostPopularReligion;
        ITimeZone timeZone;
        ITypeOfCountry typeOfCountry;

        public RegionManager(string region)
        {
            Region = region;
            DefineFactory();
            SetRegionOptions();
        }

        /// <summary>
        /// Prints all regio options
        /// </summary>
        internal void PrintRegionOption()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"The biggest company: {company.getBiggestCompany()}");
            Console.WriteLine($"Capital: {capital.getCapital()}");
            Console.WriteLine($"Currency: {currency.getCurrency()}");
            Console.WriteLine($"Flag colors: {flagColors.getFlagColors()}");
            Console.WriteLine($"Foundation year: {foundationYear.getFoundationYear()}");
            Console.WriteLine($"Greeting: {greetings.getGreetings()}");
            Console.WriteLine($"Language: {language.getLanguage()}");
            Console.WriteLine($"The most popular religion: {mostPopularReligion.getMostPopularReligion()}");
            Console.WriteLine($"Time zone: {timeZone.getTimeZone()}");
            Console.WriteLine($"Type of country: {typeOfCountry.getTypeOfCountry()}");
        }

        /// <summary>
        /// Defines the factory depending of region
        /// </summary>
        private void DefineFactory()
        {
            Factory = Region switch
            {
                "Russia" => new RussiaOptionsFactory(),
                "Germany" => new GermanyOptionsFactory(),
                "China" => new ChinaOptionsFactory(),
                _ => throw new ArgumentException("Unknown country"),
            };
        }

        /// <summary>
        /// Set options for the region
        /// </summary>
        private void SetRegionOptions()
        {
            company = Factory.CreateBiggestCompany();
            capital = Factory.CreateCapital();
            currency = Factory.CreateCurrency();
            flagColors = Factory.CreateFlagColors();
            foundationYear = Factory.CreateFoundationYear();
            greetings = Factory.CreateGreetings();
            language = Factory.CreateLanguage();
            mostPopularReligion = Factory.CreateReligion();
            timeZone = Factory.CreateTimeZone();
            typeOfCountry = Factory.CreateTypeOfCountry();
        }
    }
}
