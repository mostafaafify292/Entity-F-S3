using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S1.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(21,60)]
        public int? Age { get; set; }
        public ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();
    }
}
