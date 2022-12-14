namespace Localization.Xliff.OM.Exceptions
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Exception that indicates an extension is already registered.
    /// </summary>
    /// <seealso cref="Exception"/>
    [SuppressMessage("StyleCop.CSharp.Rules.Windows.Uex.UexRules",
                     "UX0810::CustomExceptionClassesShouldHaveSerializableAttribute",
                     Justification = "Portable Class Library doesn't support SerializableAttribute.")]
    public class ExtensionAlreadyRegisteredException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAlreadyRegisteredException"/> class.
        /// </summary>
        public ExtensionAlreadyRegisteredException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAlreadyRegisteredException"/> class with a specified
        /// error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ExtensionAlreadyRegisteredException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAlreadyRegisteredException"/> class with a specified
        /// error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null
        /// reference if no inner exception is specified.
        /// </param>
        public ExtensionAlreadyRegisteredException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
