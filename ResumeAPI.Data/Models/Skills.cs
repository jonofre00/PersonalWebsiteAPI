using System.ComponentModel.DataAnnotations;

namespace ResumeAPI.Data.Models
{
    public class Skills
    {
        [Key]
        public long Id { get; set; }

        public string SkillName { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
