using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvancedSerach.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("AGE")]
        public int Age { get; set; }

        [Column("PHONE")]
        public string Phone { get; set; }

        [Column("GENDER")]
        public string Gender { get; set; }
    }
}
