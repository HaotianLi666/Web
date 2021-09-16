/* File: RepositoryContext.cs
 * Authors: Jonathan Wenek
 * Purpose: This class is the single point of contact from the application to MongoDB in the cloud */

using Sprouty.Entities.Models;
using MongoDB.Driver;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Sprouty.Entities
{
    public class RepositoryContext: DbContext
    {
        private IMongoDatabase _database;
        public RepositoryContext(IMongoSettings settings)
        {
            if (settings == null)
                return; // TODO : add logging

            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoCollection<T> DbSet<T>() where T : BaseModel
        {
            // fetch the name given to the table attribute of the model and return that specific collection
            var collection = typeof(T).GetCustomAttribute<TableAttribute>(false).Name; 
            return _database.GetCollection<T>(collection); 
        }

    }

     
}
