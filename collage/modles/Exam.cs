using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collage.modles
{
    public class Exam
    {

        [Key]
        public int Exam_code { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(10)]
        public string Time { get; set; }

        [MaxLength(50)]
        public string Room { get; set; }

       
        public ICollection<Student> Students { get; set; }
    }
}
