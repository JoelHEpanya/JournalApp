namespace JournalApp.Models.LastFM
{
    public class Track
    {
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public string Url { get; set; }
        public string Thoughts { get; set; } = ""; // Self explanatory
        public int Rating { get; set; } = 0;    // Rating from 0-10
    }
    public class Artist
    {
        public string Name { get; set; }
    }
}
