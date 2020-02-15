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
			InitializeComponent();
			DBService database = new DBService();
			//Paragraph para = new Paragraph()
			//{
			//	Lyrics = "vozi me",
			//	Type = "Chorus"
			//};
			//ObjectId owner = ObjectId.GenerateNewId();
			//List<Paragraph> pesma = new List<Paragraph>();
			//pesma.Add(para);
			//Song song = new Song()
			//{
			//	Artist = "MikaPera",
			//	Name = "Relax, kake",
			//	Id = new ObjectId(),
			//	Lyrics = pesma,
			//	OwnerId = owner
			//};
			//Song song1 = new Song()
			//{
			//	Artist = "MikaPera",
			//	Name = "Relax, kake",
			//	Id = new ObjectId(),
			//	Lyrics = pesma,
			//	OwnerId = owner
			//};
			//database.AddSong(song);
			//database.AddSong(song1);
			//List<Song> songs = database.GetSongList();
			//List<Song> songsUser = database.GetSongsMatching("rel", 1);
			//List<Song> songsUser1 = database.GetSongsMatching("kak", 1);
			//var nw = database.LogIn("Peca", "Shmeca");
		}
	}
}
