using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Linq_labb2.Models
{
    public class Subject
    {
#nullable enable
        [Key]
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
#nullable disable
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
