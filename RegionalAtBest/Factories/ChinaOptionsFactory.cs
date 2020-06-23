using RegionalAtBest.Implementations;
using RegionalAtBest.Interfaces;
using System;
using System.Collections.Generic;
using ***REMOVED***;

namespace RegionalAtBest.Factories
{
    class ChinaOptionsFactory : IAbstractFactory
    {
        public IBiggestCompany CreateBiggestCompany()
        {
            return new ChinaBiggestCompany();
        }

        public ICapital CreateCapital()
        {
            return new ChinaCapital();
        }

        public ICurrency CreateCurrency()
        {
            return new ChinaCurrency();
        }

        public IFlagColors CreateFlagColors()
        {
            return new ChinaFlagColors();
        }

        public IFoundationYear CreateFoundationYear()
        {
            return new ChinaFoundationYear();
        }

        public IGreetings CreateGreetings()
        {
            return new ChinaGreetings();
        }

        public ILanguage CreateLanguage()
        {
            return new ChinaLanguage();
        }

        public IMostPopularReligion CreateReligion()
        {
            return new ChinaMostPopularReligion();
        }

        public ITimeZone CreateTimeZone()
        {
            return new ChinaCapitalTimeZone();
        }

        public ITypeOfCountry CreateTypeOfCountry()
        {
            return new ChinaTypeOfCountry();
        }
    }
}
