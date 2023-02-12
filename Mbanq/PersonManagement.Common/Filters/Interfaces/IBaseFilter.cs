using System;
using System.Collections.Generic;

namespace PersonManagement.Common.Filters.Interfaces
{
    /// <summary>
    /// IBaseFilter
    /// </summary>
    public interface IBaseFilter
    {
        /// <summary>
        /// Gets or sets the ids.
        /// </summary>
        /// <value>
        /// The ids.
        /// </value>
        IEnumerable<Guid> Ids { get; set; }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>
        /// The date created.
        /// </value>
        DateTimeRange? DateCreatedRange { get; set; }

        /// <summary>
        /// Gets or sets the search phrase.
        /// </summary>
        /// <value>
        /// The search phrase.
        /// </value>
        string? SearchPhrase { get; set; }
    }
}