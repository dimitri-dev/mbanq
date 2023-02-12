using PersonManagement.Common.Filters.Interfaces;
using PersonManagement.Models.Common;
using PersonManagement.Models;
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
            var person = context.Persons.Add((Person)model);
            return await context.SaveChangesAsync() > 0;
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
            return await context.Persons.ToListAsync();
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<IPerson> GetAsync(Guid id)
        {
            return await context.Persons.FirstOrDefaultAsync(x => x.Id == id);
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
            var person = await context.Persons.FirstOrDefaultAsync(x => x.Id == id);
            if (person != null)
            {
                person = (Person)model;
                await context.SaveChangesAsync();
            }
            return person;
        }
    }
}
