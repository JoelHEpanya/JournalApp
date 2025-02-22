using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JournalApp.Models
{
    public class Meals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Thoughts { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal (18,2)")]
        public decimal Price { get; set; }

        public string Rating { get; set; }

    }
}
