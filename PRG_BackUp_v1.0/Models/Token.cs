using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbtoken")]
    public class Token
    {
        public int Id { get; set; }

        [Column("token")]
        public string Value { get; set; }

        [Column("valid_until")]
        public DateTime ValidUntil { get; set; }
    }
}
