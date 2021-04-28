using System.ComponentModel.DataAnnotations.Schema;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbpcbackup")]
    public class PcBackUp
    {
        public int Id { get; set; }
        public int IdPc { get; set; }
        public int IdConfig { get; set; }
        /*
        [ForeignKey("IdPc")]
        public virtual Pc _IdPc { get; set; }
        [ForeignKey("IdConfig")]
        public virtual BackUpConfig _IdConfig { get; set; }
        */
    }
}
