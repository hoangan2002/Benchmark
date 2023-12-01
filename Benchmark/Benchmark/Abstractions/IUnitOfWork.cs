namespace Benchmark.Abstractions
{

    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>
         void  Commit();
    }
}
