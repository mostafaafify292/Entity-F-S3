﻿using Entity_F_S1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S3.Entities
{
    public class Course_Instructor
    {
        public int CourseId {  get; set; }
        public int InstructorId { get; set; }
        public string evaluate {  get; set; }
        public Course course { get; set; }
        public Instructor instructor { get; set; }

    }
}
