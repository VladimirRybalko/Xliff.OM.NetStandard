namespace Localization.Xliff.OM.Core
{
    using Localization.Xliff.OM.XmlNames;

    /// <summary>
    /// This class represents CDATA in resource content.
    /// </summary>
    /// <seealso cref="ResourceStringContent"/>
    public class CDataTag : ResourceStringContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CDataTag"/> class.
        /// </summary>
        /// <param name="text">The CDATA text.</param>
        public CDataTag(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CDataTag"/> class.
        /// </summary>
        internal CDataTag()
        {
        }

        #region Properties
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets a value indicating whether the provider has text.
        /// </summary>
        protected override bool HasInnerText
        {
            get { return !string.IsNullOrEmpty(this.Text); }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object, otherwise false.</returns>
        public override bool Equals(object obj)
        {
            CDataTag text;

            text = obj as CDataTag;
            return !object.Equals(text, null) && (text.Text == this.Text);
        }

        /// <summary>
        /// Gets as a hash code for the current object.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return (this.Text != null) ? this.Text.GetHashCode() : base.GetHashCode();
        }

        /// <summary>
        /// Gets the text associated with this <see cref="XliffElement"/>.
        /// </summary>
        /// <returns>The text within the <see cref="XliffElement"/>.</returns>
        protected override string GetInnerText()
        {
            return this.Text;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Xml.CDATABeginTag + this.Text + Xml.CDATAEndTag;
        }
        #endregion Methods
    }
}
