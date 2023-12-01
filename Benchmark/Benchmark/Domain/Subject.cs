using Benchmark.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benchmark.Domain
{
    public class Subject : DomainEntity<Guid>
    {
        [Column("SubjectId")]
        public override Guid Id { get; set; }
        public string SubjectName { get; set; }

        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }

}
