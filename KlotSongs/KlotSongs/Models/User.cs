using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlotSongs.Models
{
	public class User
	{
		public ObjectId Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
