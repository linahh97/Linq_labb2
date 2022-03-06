using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Linq_labb2.Models
{
    public class TeacherStudent
    {
        [Key]
        public int TeachStudentID { get; set; }
        public int TeacherID { get; set; }
        public int StudentID { get; set; }

        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
    }
}
