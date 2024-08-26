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
    public class Instructor
    {
        
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public int? Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }

        public ICollection<Course_Instructor> course_Instructors { get; set; }=new HashSet<Course_Instructor>();


    }
}
