using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Linq_labb2.Models
{
    public class Student
    {
#nullable enable
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public Grade Grade { get; set; }
#nullable disable
        public ICollection<TeacherStudent> TeacherStudents { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
