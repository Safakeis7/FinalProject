namespace FinalProject.Models
{
    public class Songs
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Songs() { }

        public Songs(int id, string title, string artist, string album, DateTime releaseDate)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Album = album;
            ReleaseDate = releaseDate;
        }
    }
}


