using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Linq_labb2.Models
{
    public class Teacher
    {
#nullable enable
        [Key]
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
#nullable disable
        public ICollection<TeacherStudent> TeacherStudents { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
