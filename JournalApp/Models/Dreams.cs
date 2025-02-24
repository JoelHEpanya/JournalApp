namespace JournalApp.Models
{
    public class Dreams
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Note { get; set; }
        public int rating { get; set; }
        public DateTime createdDate = DateTime.Now;
    }
}
