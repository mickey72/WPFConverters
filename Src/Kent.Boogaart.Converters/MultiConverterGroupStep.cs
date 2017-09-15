using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Markup;

namespace Kent.Boogaart.Converters
{
    /// <summary>
    /// Represents a single step in a <see cref="MultiConverterGroup"/>.
    /// </summary>
    [ContentProperty("Converters")]
    public class MultiConverterGroupStep
    {
        #region Fields
        /// <summary>
        /// Converters.
        /// </summary>
        private readonly Collection<IMultiValueConverter> converters;
        #endregion
        #region Properties
        /// <summary>
        /// Gets the collection of <see cref="IMultiValueConverter"/>s in this <c>MultiConverterGroupStep</c>.
        /// </summary>
        public Collection<IMultiValueConverter> Converters
        {
            get { return this.converters; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the MultiConverterGroupStep class.
        /// </summary>
        public MultiConverterGroupStep()
        {
            this.converters = new Collection<IMultiValueConverter>();
        }
        #endregion
    }
}
