using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Linq_labb2.Models
{
    public class StudentSubject
    {
        [Key]
        public int StudentSubID { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
