using Benchmark.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Benchmark.Domain
{
    public class Evaluation : DomainEntity<Guid>
    {
        [Column("EvaluationId")]
        public override Guid Id { get; set; }
        [Required]
        public int Grade { get; set; }
        public string AdditionalExplanation { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
