using System.ComponentModel.DataAnnotations.Schema;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbstorage")]
    public class Storage
    {
        public int Id { get; set; }
        public int IdConfig { get; set; }
        public string Place { get; set; }
        public string Format { get; set; }
        public string ServerIP { get; set; }
        public string ServerLogin { get; set; }
        public string ServerPass { get; set; }
        public string Path { get; set; }
    }
}
