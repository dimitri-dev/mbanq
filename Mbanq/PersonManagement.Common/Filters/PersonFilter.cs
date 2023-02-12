using PersonManagement.Common.Filters.Interfaces;

namespace PersonManagement.Common.Filters
{
    /// <summary>
    /// PersonFilter
    /// </summary>
    /// <seealso cref="PersonManagement.Common.Filters.BaseFilter" />
    /// <seealso cref="PersonManagement.Common.Filters.Interfaces.IPersonFilter" />
    public class PersonFilter : BaseFilter, IPersonFilter
    {
        /// <summary>
        /// Gets or sets the oib.
        /// </summary>
        /// <value>
        /// The oib.
        /// </value>
        public string? OIB { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string? Surname { get; set; }
    }
}
