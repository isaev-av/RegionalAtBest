using RegionalAtBest.Implementations;
using RegionalAtBest.Interfaces;
using System;
using System.Collections.Generic;
using ***REMOVED***;

namespace RegionalAtBest.Factories
{
    class RussiaOptionsFactory : IAbstractFactory
    {
        public IBiggestCompany CreateBiggestCompany()
        {
            return new RussiaBiggestCompany();
        }

        public ICapital CreateCapital()
        {
            return new RussiaCapital();
        }

        public ICurrency CreateCurrency()
        {
            return new RussiaCurrency();
        }

        public IFlagColors CreateFlagColors()
        {
            return new RussiaFlagColors();
        }

        public IFoundationYear CreateFoundationYear()
        {
            return new RussiaFoundationYear();
        }

        public IGreetings CreateGreetings()
        {
            return new RussianGreetings();
        }

        public ILanguage CreateLanguage()
        {
            return new RussianLanguage();
        }

        public IMostPopularReligion CreateReligion()
        {
            return new RussianMostPopularReligion();
        }

        public ITimeZone CreateTimeZone()
        {
            return new RussianCapitalTimeZone();
        }

        public ITypeOfCountry CreateTypeOfCountry()
        {
            return new RussiaTypeOfCountry();
        }
    }
}
