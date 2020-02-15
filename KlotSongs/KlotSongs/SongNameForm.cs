using KlotSongs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlotSongs
{
    public partial class SongNameForm : Form
    {
        Song song;

        public SongNameForm(Song song)
        {
            InitializeComponent();
            this.song = song;
            confirmBtn.Enabled = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            song.Name = nameTxtBox.Text;
            song.Artist = artistTxtBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckFilledFields();
        }

        private void CheckFilledFields()
        {
            if (nameTxtBox.Text != "" && artistTxtBox.Text != "")
                confirmBtn.Enabled = true;
            else
                confirmBtn.Enabled = false;
        }

        private void artistTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckFilledFields();
        }
    }
}
