using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlotSongs.Models;
using KlotSongs.Services;
using MongoDB.Bson;

namespace KlotSongs
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			Paragraph para = new Paragraph()
			{
				Lyrics = "vozi me",
				Type = "Chorus"
			};
			List<Paragraph> pesma = new List<Paragraph>();
			pesma.Add(para);
			DBService database = new DBService();
			InitializeComponent();
			Song song = new Song()
			{
				Artist = "MikaPera",
				Name = "Relax, kake",
				Id = new ObjectId(),
				Lyrics = pesma 
			};
			database.AddSong(song);
			List<Song> songs = database.GetSongList();
		}
	}
}
