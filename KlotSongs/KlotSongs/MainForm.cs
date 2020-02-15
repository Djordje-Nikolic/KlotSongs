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
		User currentUser;
		Song currentSong;
		DBService db = new DBService();
		int batchSize = 10;

		public MainForm(User user)
		{
			InitializeComponent();

			currentUser = user;
			SetMySongs(true);
			SetSongButtons(false);
		}

		private void SetMySongs(bool firstLookup)
		{
			List<Song> mySongs = db.GetOwnedSongs(currentUser.Id, batchSize, firstLookup);
			mySongsListBox.DataSource = null;			
			mySongsListBox.DataSource = mySongs;
		}

		private void SetSearchedSongs(List<Song> songs)
		{
			searchedSongsListBox.DataSource = null;
			searchedSongsListBox.DataSource = songs;
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
				SetMySongs(false);
			}		
		}

		private void mySongsListBox_Click(object sender, EventArgs e)
		{
			int index = this.mySongsListBox.IndexFromPoint((e as MouseEventArgs).Location);

			if (index != -1)
			{
				Song song = (Song)mySongsListBox.Items[index];
				songTxtBox.Text = GenerateSongDisplayText(song);
			}
		}

		public string GenerateSongDisplayText(Song song)
		{
			currentSong = song;

			if (song.OwnerId == currentUser.Id)
				SetSongButtons(true);
			else
				SetSongButtons(false);

			StringBuilder stringBuilder = new StringBuilder();

			stringBuilder.AppendLine($"Song name: {song.Name}");
			stringBuilder.AppendLine($"Artist name: {song.Artist}");

			int i = 0;
			foreach (var paragraph in song.Lyrics)
			{
				stringBuilder.AppendLine();
				stringBuilder.AppendLine($"{paragraph.Type} Index: {i}");
				stringBuilder.AppendLine(paragraph.Lyrics);
				i++;
			}

			return stringBuilder.ToString();
		}

		public void SetSongButtons(bool active)
		{
			modifyBtn.Enabled = active;
			deleteBtn.Enabled = active;
		}

		private void modifyBtn_Click(object sender, EventArgs e)
		{
			EditController editController = new EditController(currentSong, db);
			EditForm editForm = new EditForm(editController);
			editForm.ShowDialog();
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to delete this song", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (res == DialogResult.Yes)
			{
				db.DeleteSong(currentSong);
				songTxtBox.Text = "";
				SetMySongs(false);
			}
		}

		private void searchBtn_Click(object sender, EventArgs e)
		{
			string searchText = searchTxtBox.Text;

			if(searchText == "")
			{
				SetSearchedSongs(new List<Song>());
				return;
			}
			List<Song> songs = db.GetSongsMatching(searchText, batchSize);
			SetSearchedSongs(songs);
		}

		private void searchedSongsListBox_Click(object sender, EventArgs e)
		{
			int index = this.searchedSongsListBox.IndexFromPoint((e as MouseEventArgs).Location);

			if (index != -1)
			{
				Song song = (Song)searchedSongsListBox.Items[index];
				songTxtBox.Text = GenerateSongDisplayText(song);
			}
		}
	}
}
