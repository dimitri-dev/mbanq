using PersonManagement.Common.Filters.Interfaces;
using System;
using System.Collections.Generic;

namespace PersonManagement.Common.Filters
{
    /// <summary>
    /// BaseFilter
    /// </summary>
    /// <seealso cref="PersonManagement.Common.Filters.Interfaces.IBaseFilter" />
    public class BaseFilter : IBaseFilter
    {
        /// <summary>
        /// Gets or sets the ids.
        /// </summary>
        /// <value>
        /// The ids.
        /// </value>
        public IEnumerable<Guid> Ids { get; set; }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>
        /// The date created.
        /// </value>
        public DateTimeRange? DateCreated { get; set; }
    }
}
