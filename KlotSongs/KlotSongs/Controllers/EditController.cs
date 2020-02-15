using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlotSongs.Models;

namespace KlotSongs.Controllers
{
    public class EditController
    {
        public readonly Song EditedSong;

        public EditController(Song song)
        {
            EditedSong = song;
        }

        public string GenerateSongDisplayText()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Song name: {EditedSong.Name}");
            stringBuilder.AppendLine($"Artist name: {EditedSong.Artist}");
            stringBuilder.AppendLine();

            int i = 0;
            foreach (var paragraph in EditedSong.Lyrics)
            {
                stringBuilder.AppendLine($"{paragraph.Type} Index: {i}");
                stringBuilder.AppendLine(paragraph.Lyrics);
            }

            return stringBuilder.ToString();
        }

        public void AddParagraph(Paragraph paragraph, int atIndex)
        {
            //List<Paragraph> paragraphs = new List<Paragraph>(EditedSong.Lyrics.Count + 1);

            //for (int i = 0; i < EditedSong.Lyrics.Count; i++)
            //{
            //    if (i == atIndex)
            //    {
            //        paragraphs.Add(paragraph);
            //        paragraphs.Add(EditedSong.Lyrics[i]);
            //    }
            //    else
            //    {
            //        paragraphs.Add(EditedSong.Lyrics[i]);
            //    }
            //}

            //EditedSong.Lyrics = paragraphs;
            EditedSong.Lyrics.Insert(atIndex, paragraph);
        }

        public Paragraph GetParagraphAt(int index)
        {
            return EditedSong.Lyrics.ElementAt(index);
        }

        public void RemoveParagraphAt(int index)
        {
            EditedSong.Lyrics.RemoveAt(index);
        }

        public void CommitChanges()
        {
            //Push to db
        }
    }
}
