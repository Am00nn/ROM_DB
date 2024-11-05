using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collage.modles
{
    public class Department
    {
        [Key]
        public int Department_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string D_name { get; set; }

       
        public ICollection<Course> Courses { get; set; }
        public ICollection<Faculty> Faculties { get; set; }
    }
}
