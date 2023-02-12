using PersonManagement.Common.Filters.Interfaces;
using PersonManagement.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagement.Common.Repositories
{
    /// <summary>
    /// PersonRepository
    /// </summary>
    /// <seealso cref="PersonManagement.Common.Repositories.IPersonRepository" />
    public class PersonRepository : IPersonRepository
    {
        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<bool> CreateAsync(IPerson model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<IEnumerable<IPerson>> GetAllAsync(IPersonFilter filter = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<IPerson> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<IPerson> UpdateAsync(Guid id, IPerson model)
        {
            throw new NotImplementedException();
        }
    }
}
