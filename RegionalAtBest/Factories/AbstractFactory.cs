using RegionalAtBest.Interfaces;
using System;
using System.Collections.Generic;
using ***REMOVED***;

namespace RegionalAtBest.Factories
{
    interface IAbstractFactory
    {
        public IBiggestCompany CreateBiggestCompany();

        public ICapital CreateCapital();

        public ICurrency CreateCurrency();

        public IFlagColors CreateFlagColors();

        public IFoundationYear CreateFoundationYear();

        public IGreetings CreateGreetings();

        public ILanguage CreateLanguage();

        public IMostPopularReligion CreateReligion();

        public ITimeZone CreateTimeZone();

        public ITypeOfCountry CreateTypeOfCountry();
    }
}
