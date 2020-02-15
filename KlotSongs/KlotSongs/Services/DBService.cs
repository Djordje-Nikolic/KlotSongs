﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using KlotSongs.Models;

namespace KlotSongs.Services
{
	public enum Searches
	{
		User,
		String
	}

	class DBService
	{
		public int nextBatch { get; set; } = 0;
		public Searches lastSearch { get; private set; }

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

		public void UpdateSong(Song song)
		{

			FilterDefinition<Song> updateFilter = "{ Id: " + song.Id + " }";
			UpdateDefinition<Song> songUpdate = "{ Name: " + song.Name + ", Artist: " + song.Artist + ", Lyrics: " + song.Lyrics + " }";
			using (DatabaseHandler database = new DatabaseHandler())
			{
				var collection = database.GetCollection<Song>("songs");

				collection.UpdateOne(updateFilter, songUpdate);
			}
		}

		public List<Song> GetOwnedSongs(ObjectId ownerId, int batchSize)
		{
			if (this.lastSearch != Searches.User)
			{
				this.ClearBatchIndex();
				this.lastSearch = Searches.User;
			}
			this.nextBatch++;
			FilterDefinition<Song> userFilter = Builders<Song>.Filter.Eq(song => song.OwnerId, ownerId);

			using (DatabaseHandler database = new DatabaseHandler())
			{
				var collection = database.GetCollection<Song>("songs");
				return collection.Find(userFilter).Skip(batchSize * --this.nextBatch).Limit(batchSize).ToList();
			}
		}

		public List<Song> GetSongsMatching(string searchString, int batchSize)
		{
			if (this.lastSearch != Searches.String)
			{
				this.ClearBatchIndex();
				this.lastSearch = Searches.String;
			}
			this.nextBatch++;
			FilterDefinition<Song> stringFilter = "{ Name:" + "/" + searchString + "/i }" ;

			using (DatabaseHandler database = new DatabaseHandler())
			{
				var collection = database.GetCollection<Song>("songs");
				return collection.Find(stringFilter).Skip(batchSize * --this.nextBatch).Limit(batchSize).ToList();
			}
		}
		
		private void ClearBatchIndex()
		{
			this.nextBatch = 0;
		}

		public User LogIn(string username, string password)
		{
			FilterDefinition<User> logInFilter = "{ Username: " + "\"" + username + "\"" + ", " + "Password: " + "\"" + password + "\"" + " }";

			using (DatabaseHandler database = new DatabaseHandler())
			{
				var collection = database.GetCollection<User>("users");
				return collection.Find(logInFilter).ToList().Last();
			}
		}

		public bool Register (string username, string password)
		{
			FilterDefinition<User> registerFilter = "{ Username: " + "\"" + username + "\"" + " }";

			using (DatabaseHandler database = new DatabaseHandler())
			{
				var collection = database.GetCollection<User>("users");
				if (collection.Find(registerFilter).CountDocuments() == 0)
				{
					collection.InsertOne(new User()
					{
						Id = new ObjectId(),
						Username = username,
						Password = password
					});
					return true;
				}
				else
					return false;
			}
		}
	}
}
