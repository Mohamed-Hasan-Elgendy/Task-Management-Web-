using System.ComponentModel.DataAnnotations;

namespace TMC.Models
{
    public class myprojects
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        /////////////////////////////////////////////////
        public List<mytasks> Mytasks { get; set; }
        /////////////////////////////////////////////////
    }
}
