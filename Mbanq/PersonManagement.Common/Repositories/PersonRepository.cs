using PersonManagement.Common.Filters.Interfaces;
using PersonManagement.Models.Common;
using PersonManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;

namespace PersonManagement.Common.Repositories
{
    /// <summary>
    /// PersonRepository
    /// </summary>
    /// <seealso cref="PersonManagement.Common.Repositories.IPersonRepository" />
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonContext context;
        public PersonRepository()
        {
            context = new PersonContext();
            context.Persons.Load();
        }

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
            var person = context.Persons.First(x => x.Id == id);
            context.Persons.Remove(person);
            return await context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<IEnumerable<IPerson>> GetAllAsync(IPersonFilter filter = null)
        {
            // TODO: filter implementation
            return context.Persons.Local.ToBindingList();
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<IPerson> GetAsync(Guid id)
        {
            return context.Persons.FirstOrDefault(x => x.Id == id);
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
