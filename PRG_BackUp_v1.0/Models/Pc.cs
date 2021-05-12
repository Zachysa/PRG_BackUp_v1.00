using System.ComponentModel.DataAnnotations.Schema;

namespace PRG_BackUp_v1._0.Models
{
    [Table("tbpc")]
    public class Pc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }
        public string OS { get; set; }
        public string LastOnline { get; set; }
        public int Blocked { get; set; }
    }
}
