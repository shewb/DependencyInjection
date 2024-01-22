namespace DependencyInjectionSKE.Services
{
    public interface IScopedOperation : IOperation
    {
    }

    public class ScopedOperation : IScopedOperation
    {
        public Guid Id { get; }

        public ScopedOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}
