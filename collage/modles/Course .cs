using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collage.modles
{
    public class Course
    {
        [Key]
        public int Course_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Course_name { get; set; }

        [Required]
        public int Duration { get; set; }

        public int DepartmentId { get; set; }

       
        public Department Department { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
