using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAdvancedSerach.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("UID")]
        public int Uid { get; set; }

        [Column("ADDRESS")]
        public string address { get; set; }
    }
}
