using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlotSongs
{
	internal sealed class DatabaseHandler : IDisposable
	{

		public IMongoDatabase MongoDatabase;

		public DatabaseHandler()
		{
			var mongoClient = new MongoClient(Properties.Settings.Default.DBConnection);

			MongoDatabase = mongoClient.GetDatabase(Properties.Settings.Default.DBName);
		}

		public void Dispose()
		{
			return;
		}

		public IMongoCollection<T> GetCollection<T>(string name)
		{
			return MongoDatabase.GetCollection<T>(name);
		}
	}
}
