using System.ComponentModel.DataAnnotations;

namespace TMC.Models
{
    public class myteammember
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Role { get; set; }

        public List<mytasks> Mytasks { get; set; }
    }
}
