using System.ComponentModel.DataAnnotations.Schema;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbbackupconfig")]
    public class BackUpConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public bool EmailBool { get; set; }
    }
}
