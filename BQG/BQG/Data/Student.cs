using System.ComponentModel.DataAnnotations;

namespace BQG.Data
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(8, 15)]
        public int Age { get; set; }

        public DateTime DOB { get; set; }

        [Range(5, 10)]
        public int Standard { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string School { get; set; }
    }
}
