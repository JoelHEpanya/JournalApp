namespace JournalApp.Models.LastFM
{
    public class LastFmResponse
    {
        public RecentTracks recenttracks { get; set; }
    }
    public class RecentTracks
    {
        public List<Track> track { get; set; }
    }
}
