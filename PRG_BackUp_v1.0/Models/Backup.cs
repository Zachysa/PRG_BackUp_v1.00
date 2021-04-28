using System.ComponentModel.DataAnnotations.Schema;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbbackup")]
    public class Backup
    {
        public int Id { get; set; }
        public int IdPcBackUp { get; set; }
        public string BackupTime { get; set; }
        public int FileCount { get; set; }
        public int FileCountSuccess { get; set; }
        public int FileCountFailed { get; set; }
        public string Errors { get; set; }
        public string Operations { get; set; }
        /*
        [ForeignKey("IdPcBackUp")]
        public virtual PcBackUp _IdPcBackUp { get; set; }
        */
    }
}
