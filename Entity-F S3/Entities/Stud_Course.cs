using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S1.Entities
{
    public class Stud_Course
    {
        
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }

    }
}
