using PersonManagement.Common.Filters.Interfaces;
using PersonManagement.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagement.Common.Repositories
{
    public interface IPersonRepository
    {
        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<IPerson>> GetAllAsync(IPersonFilter filter = null);

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<IPerson> GetAsync(Guid id);

        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        Task<bool> CreateAsync(IPerson model);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        Task<IPerson> UpdateAsync(Guid id, IPerson model);

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Guid id);
    }
}
