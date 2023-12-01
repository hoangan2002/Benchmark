﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoBenmark.Models
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
