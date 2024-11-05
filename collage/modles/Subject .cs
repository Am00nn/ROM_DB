using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collage.modles
{
    public class Subject
    {
        [Key]
        public int Subject_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Subject_name { get; set; }

      
        public ICollection<Faculty> Faculties { get; set; }
    }
}
