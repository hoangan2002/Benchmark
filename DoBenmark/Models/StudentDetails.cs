using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoBenmark.Models
{
    public class StudentDetails
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string AdditionalInformation { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
