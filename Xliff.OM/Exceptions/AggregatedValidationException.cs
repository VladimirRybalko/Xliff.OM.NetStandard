namespace Localization.Xliff.OM.Exceptions
{
    using Localization.Xliff.OM.Properties;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Exception that indicates a document is invalid.
    /// </summary>
    /// <seealso cref="Exception"/>
    public sealed class AggregatedValidationException : ValidationException
    {
        public List<ValidationException> InnerExceptions { get; private set; }

        public AggregatedValidationException(List<ValidationException> inners)
            : base(Resources.StandardValidator_AggregatedException, selectorPath: null)
        {
            this.InnerExceptions = inners;
        }
    }
}