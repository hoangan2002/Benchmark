using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoBenmark.Models
{

    public class Evaluation
    {
        public Guid Id { get; set; }
        public int Grade { get; set; }
        public string AdditionalExplanation { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
