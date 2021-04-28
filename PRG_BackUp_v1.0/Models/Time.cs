using System.ComponentModel.DataAnnotations.Schema;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbtime")]
    public class Time
    {
        public int Id { get; set; }
        public int IdConfig { get; set; }
        public string Frequency { get; set; }
        public string Days { get; set; }
        public string Date { get; set; }
        /*
        [ForeignKey("IdConfig")]
        public virtual BackUpConfig _IdConfig { get; set; }
        */
    }
}
