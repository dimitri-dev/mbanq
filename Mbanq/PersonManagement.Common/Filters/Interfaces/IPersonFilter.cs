namespace PersonManagement.Common.Filters.Interfaces
{
    /// <summary>
    /// IPersonFilter
    /// </summary>
    /// <seealso cref="PersonManagement.Common.Filters.Interfaces.IBaseFilter" />
    public interface IPersonFilter : IBaseFilter
    {
        /// <summary>
        /// Gets or sets the oib.
        /// </summary>
        /// <value>
        /// The oib.
        /// </value>
        string? OIB { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string? Name { get; set; }
        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        string? Surname { get; set; }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        string? Phone { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        string? Address { get; set; }
        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        /// <value>
        /// The mail.
        /// </value>
        string? Mail { get; set; }
    }
}
