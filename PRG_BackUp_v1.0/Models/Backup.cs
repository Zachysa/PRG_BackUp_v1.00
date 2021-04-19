using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbbackup")]
    public class Backup
    {
        public int Id { get; set; }
        public string BackupTime { get; set; }
        public int FileCount { get; set; }
        public int FileCountSuccess { get; set; }
        public int FileCountFailed { get; set; }
        public string Errors { get; set; }
        public int IdPcBackUp { get; set; }
        /*
        [ForeignKey("IdPcBackUp")]
        public virtual PcBackUp _IdPcBackUp { get; set; }
        */
    }
}
