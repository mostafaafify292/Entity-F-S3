using Entity_F_S3.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S1.Entities
{
    public class Course
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        public int Duration { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string? Description { get; set; }
        
        public ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Course_Instructor> course_Instructors { get; set; } = new HashSet<Course_Instructor>();
    }
}
