﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlotSongs.Models
{
	public class Song
	{
		public ObjectId Id { get; set; }
		public ObjectId OwnerId { get; set; }
		public string Name { get; set; }
		public string Artist { get; set; }
		public List<Paragraph> Lyrics { get; set; }

		public override string ToString()
		{
			return Name + " " + "by: " + Artist;
		}
	}
}
