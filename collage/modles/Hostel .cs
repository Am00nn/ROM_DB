using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collage.modles
{
    public class Hostel
    {
        [Key]
        public int Hostel_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Hostel_name { get; set; }

        [Required]
        public int No_of_seats { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(10)]
        public string Pin_code { get; set; }

        
        public ICollection<Student> Students { get; set; }
    }
}
