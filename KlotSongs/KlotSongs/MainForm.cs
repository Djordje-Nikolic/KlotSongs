using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlotSongs.Controllers;
using KlotSongs.Models;
using KlotSongs.Services;
using MongoDB.Bson;

namespace KlotSongs
{
	public partial class MainForm : Form
	{
		private User currentUser;
		DBService db = new DBService();

		public MainForm(User user)
		{
			InitializeComponent();

			currentUser = user;
			SetMySongs();
		}

		private void SetMySongs()
		{
			List<Song> mySongs = db.GetOwnedSongs(currentUser.Id, 20);
			mySongsListBox.DataSource = mySongs;
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			Song song = new Song() { OwnerId = currentUser.Id, Lyrics = new List<Paragraph>() };

			SongNameForm songNameForm = new SongNameForm(song);
			songNameForm.ShowDialog();

			if(songNameForm.DialogResult == DialogResult.OK)
			{
				db.AddSong(song);
				EditController editController = new EditController(song, db);
				EditForm editForm = new EditForm(editController);
				editForm.ShowDialog();
			}		
		}
	}
}
