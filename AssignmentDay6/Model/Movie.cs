using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentDay6.Model
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int MId { get; set; }

        public string? MName { get; set; }

        public string? description { get; set; }
    }
}
