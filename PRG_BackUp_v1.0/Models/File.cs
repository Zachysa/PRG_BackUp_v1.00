using System.ComponentModel.DataAnnotations.Schema;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbbackupfiles")]
    public class File
    {
        public int Id { get; set; }
        public int IdConfig { get; set; }
        public string Path { get; set; }
        /*
        [ForeignKey("IdConfig")]
        public virtual BackUpConfig _IdConfig { get; set; }
        */
    }
}
