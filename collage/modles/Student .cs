using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collage.modles
{
    public  class Student
    {
        [Key]
        public int S_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(20)]
        [Required]
        public string Phone_no { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public int HostelId { get; set; }

       
        public Hostel Hostel { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Faculty> Faculties { get; set; }


    }
}
