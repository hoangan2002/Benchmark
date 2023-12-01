using Benchmark.Domain;

namespace Benchmark.Applications.Interfaces
{
    public interface IStudentServiceGood
    {
        List<Student> GetStudentsDetail();

        List<Student> GetStudentsDetailById(); // => Not Found

        List<Student> GetStudents();

        Task<Student> FindByIdAsync(Guid Id, CancellationToken cancellationToken = default);
        Task<Student> FindByConditionAsync(Guid Id, CancellationToken cancellationToken = default);
    }
}
