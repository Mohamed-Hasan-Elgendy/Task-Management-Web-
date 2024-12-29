using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TMC.Models
{
    public class mytasks
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Title/*Name*/ { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(50)]
        public string Propirty { get; set; }
        public DateTime Deadline { get; set; }
        /////////////////////////////////////////////////
        [ForeignKey("ProjectID")]
        public int projectID { get; set; }
        [ForeignKey("TeamMemberID")]
        public int teamMemberID { get; set; }
        /////////////////////////////////////////////////
        public myteammember TeamMemberID { get; set; }
        public myprojects ProjectID { get; set; }
    }
}
