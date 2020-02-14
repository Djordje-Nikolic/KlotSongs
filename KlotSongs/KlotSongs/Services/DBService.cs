using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using KlotSongs.Models;

namespace KlotSongs.Services
{
	class DBService
	{
		const string ConnectionString = "mongodb://localhost/?safe=true";
		public List<Song> GetSongList()
		{
			using (DatabaseHandler database = new DatabaseHandler())
			{

				var collection = database.GetCollection<Song>("songs").AsQueryable();

				return collection.ToList();
			}
		}

		public void AddSong(Song song)
		{
			using (DatabaseHandler database = new DatabaseHandler())
			{
				var collection = database.GetCollection<Song>("songs");

				collection.InsertOne(song);
			}
		}
	}
}
