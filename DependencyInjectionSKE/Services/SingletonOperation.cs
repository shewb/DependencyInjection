namespace DependencyInjectionSKE.Services
{
    public interface ISingletonOperation : IOperation
    {
    }

    public class SingletonOperation : ISingletonOperation
    {
        public Guid Id { get; }

        public SingletonOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}
