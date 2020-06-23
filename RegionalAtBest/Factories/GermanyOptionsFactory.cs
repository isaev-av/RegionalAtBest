using RegionalAtBest.Implementations;
using RegionalAtBest.Interfaces;
using System;
using System.Collections.Generic;
using ***REMOVED***;

namespace RegionalAtBest.Factories
{
    class GermanyOptionsFactory : IAbstractFactory
    {
        public IBiggestCompany CreateBiggestCompany()
        {
            return new GermanyBiggestCompany();
        }

        public ICapital CreateCapital()
        {
            return new GermanyCapital();
        }

        public ICurrency CreateCurrency()
        {
            return new GermanyCurrency();
        }

        public IFlagColors CreateFlagColors()
        {
            return new GermanyFlagColors();
        }

        public IFoundationYear CreateFoundationYear()
        {
            return new GermanyFoundationYear();
        }

        public IGreetings CreateGreetings()
        {
            return new GermanyGreetings();
        }

        public ILanguage CreateLanguage()
        {
            return new GermanLanguage();
        }

        public IMostPopularReligion CreateReligion()
        {
            return new GermanyMostPopularReligion();
        }

        public ITimeZone CreateTimeZone()
        {
            return new GermanyCapitalTimeZone();
        }

        public ITypeOfCountry CreateTypeOfCountry()
        {
            return new GermanyTypeOfCountry();
        }
    }
}
