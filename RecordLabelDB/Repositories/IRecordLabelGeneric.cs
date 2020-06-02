using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordLabelDB.Repositories
{
    interface IRecordLabelGeneric<T> where T : class
    {
        List<T> GetAll(); // Returns all
        IQueryable<T> Get();
        T GetById(int id); // Get one using Id
        void DeleteById(int id); // Delete using id
        void Update(T entity); // Update an entity
        void Create(T entity); // Add new record
        void Save(); // Save changes
        
    }
}
