using CrudWithBlazorApp.Data;
using CrudWithBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithBlazorApp.Services
{
    public class PersonService
    {
        public DatabaseDataContext Dbcontext { get; }

        public PersonService()
        {
             
        }


        public async Task CreatePerson(Person person)
        {
           await Dbcontext.People.AddAsync(person);
           Dbcontext.SaveChanges();
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await Task.FromResult(Dbcontext.People.ToList());
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            var data = await Dbcontext.People.FindAsync(id);
            return data;
        }

    }
}
