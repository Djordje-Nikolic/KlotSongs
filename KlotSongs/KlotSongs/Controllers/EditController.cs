using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlotSongs.Models;
using KlotSongs.Services;

namespace KlotSongs.Controllers
{
    public class EditController
    {
        public readonly Song EditedSong;
        public readonly DBService dBService;

        public EditController(Song song, DBService dBService = null)
        {
            EditedSong = song;
            if (dBService == null)
            {
                this.dBService = new DBService();
            }
            else
            {
                this.dBService = dBService;
            }
        }

        public string GenerateSongDisplayText()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Song name: {EditedSong.Name}");
            stringBuilder.AppendLine($"Artist name: {EditedSong.Artist}");

            int i = 0;
            foreach (var paragraph in EditedSong.Lyrics)
            {
                stringBuilder.AppendLine();
                stringBuilder.AppendLine($"{paragraph.Type} Index: {i}");
                stringBuilder.AppendLine(paragraph.Lyrics);
                i++;
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
            if (index >= 0 && index < EditedSong.Lyrics.Count)
                return EditedSong.Lyrics.ElementAt(index);
            else
                return null;
        }

        public void RemoveParagraphAt(int index)
        {
            if (index >= 0 && index < EditedSong.Lyrics.Count)
                EditedSong.Lyrics.RemoveAt(index);
        }

        public void CommitChanges()
        {
            dBService.UpdateSong(EditedSong);
        }
    }
}
