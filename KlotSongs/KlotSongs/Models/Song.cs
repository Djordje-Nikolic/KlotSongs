using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlotSongs.Models
{
	class Song
	{
		public ObjectId Id { get; set; }
		public string Name { get; set; }
		public string Artist { get; set; }
		public List<Paragraph> Lyrics { get; set; }
	}
}
