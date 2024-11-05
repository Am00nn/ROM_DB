using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collage.modles
{
    public class Faculty
    {

        [Key]
        public int F_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string F_Name { get; set; }

        [MaxLength(50)]
        public string L_Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Mobile_no { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public decimal Salary { get; set; }



      
        public Department Department { get; set; }

        public ICollection<Subject> Subjects { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
