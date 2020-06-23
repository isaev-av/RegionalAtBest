using RegionalAtBest.Interfaces;
using System;
using System.Collections.Generic;
using ***REMOVED***;

namespace RegionalAtBest.Factories
{
    /// <summary>
    /// Abstract factory for creating options depending on inputed country
    /// </summary>
    interface IAbstractFactory
    {
        /// <summary>
        /// Creates the biggest company of country option
        /// </summary>
        /// <returns>Biggest company of country option</returns>
        public IBiggestCompany CreateBiggestCompany();

        /// <summary>
        /// Creates capital of country option
        /// </summary>
        /// <returns>Capital option</returns>
        public ICapital CreateCapital();

        /// <summary>
        /// Creates currency option
        /// </summary>
        /// <returns>Currency option</returns>
        public ICurrency CreateCurrency();

        /// <summary>
        /// Creates Flag colors option
        /// </summary>
        /// <returns>Flag colors option</returns>
        public IFlagColors CreateFlagColors();

        /// <summary>
        /// Creates Foundation year option
        /// </summary>
        /// <returns>Foundation year option</returns>
        public IFoundationYear CreateFoundationYear();

        /// <summary>
        /// Creates Greetings option
        /// </summary>
        /// <returns>Greetings option</returns>
        public IGreetings CreateGreetings();

        /// <summary>
        /// Creates Language option
        /// </summary>
        /// <returns>Language option</returns>
        public ILanguage CreateLanguage();

        /// <summary>
        /// Creates Popular religion option
        /// </summary>
        /// <returns>Popular religion option</returns>
        public IMostPopularReligion CreateReligion();

        /// <summary>
        /// Creates Time zone option
        /// </summary>
        /// <returns>Time zone option</returns>
        public ITimeZone CreateTimeZone();

        /// <summary>
        /// Creates Type of country option
        /// </summary>
        /// <returns>Type of country option</returns>
        public ITypeOfCountry CreateTypeOfCountry();
    }
}
