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

namespace KlotSongs
{
    public partial class EditForm : Form
    {
        private EditController editController;
        private Paragraph displayedParagraph = null;

        public EditForm(EditController editController)
        {
            InitializeComponent();

            this.editController = editController;

            InitializeSong();
        }

        private void InitializeSong()
        {
            textBoxSong.Text = editController.GenerateSongDisplayText();
            numericUpDownAddAfterParagraph.Minimum = 0;
            numericUpDownAddAfterParagraph.Maximum = editController.EditedSong.Lyrics.Count();
            numericUpDownAddAfterParagraph.DecimalPlaces = 0;
            numericUpDownAddAfterParagraph.Increment = 1;

            if (editController.EditedSong.Lyrics.Count() > 0)
            {
                numericUpDownParagraphChoice.Minimum = 0;
                numericUpDownParagraphChoice.Maximum = editController.EditedSong.Lyrics.Count() - 1;
            }
            else
            {
                numericUpDownParagraphChoice.Minimum = 0;
                numericUpDownParagraphChoice.Maximum = 0;
            }
            numericUpDownParagraphChoice.DecimalPlaces = 0;
            numericUpDownParagraphChoice.Increment = 1;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxParagraphType.Text) || string.IsNullOrWhiteSpace(textBoxParagraph.Text))
            {
                MessageBox.Show("Paragraph or paragraph type cannot be an empty string.", "Add error");
                return;
            }

            Paragraph paragraph = new Paragraph();
            paragraph.Lyrics = textBoxParagraph.Text;
            paragraph.Type = textBoxParagraphType.Text;

            editController.AddParagraph(paragraph, (int) numericUpDownAddAfterParagraph.Value);

            textBoxParagraph.Text = string.Empty;
            textBoxParagraphType.Text = string.Empty;

            InitializeSong();
        }

        private void buttonLoadParagraph_Click(object sender, EventArgs e)
        {
            displayedParagraph = editController.GetParagraphAt((int)numericUpDownParagraphChoice.Value);

            if (displayedParagraph != null)
            {
                textBoxEditedParagraph.Text = displayedParagraph.Lyrics;
                textBoxEditedParagraphType.Text = displayedParagraph.Type;
            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEditedParagraphType.Text) || string.IsNullOrWhiteSpace(textBoxEditedParagraph.Text))
            {
                MessageBox.Show("Paragraph or paragraph type cannot be an empty string.", "Edit error");
                return;
            }

            displayedParagraph.Lyrics = textBoxEditedParagraph.Text;
            displayedParagraph.Type = textBoxEditedParagraphType.Text;

            textBoxEditedParagraph.Text = string.Empty;
            textBoxEditedParagraphType.Text = string.Empty;

            textBoxSong.Text = editController.GenerateSongDisplayText();
        }

        private void buttonCommitGlobal_Click(object sender, EventArgs e)
        {
            editController.CommitChanges();
            this.Close();
        }

        private void buttonDeleteParagraph_Click(object sender, EventArgs e)
        {
            editController.RemoveParagraphAt((int) numericUpDownParagraphChoice.Value);

            InitializeSong();
        }
    }
}
