using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Linq_labb2.Models
{
    public class TeacherSubject
    {
        [Key]
        public int TeacherSubID { get; set; }
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }

        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
    }
}
