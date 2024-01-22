namespace DependencyInjectionSKE.Services
{
    public interface IMyService
    {
    }

    public class MyService : IMyService
    {
        public readonly ISingletonOperation _singletonOperation;
        public readonly ITransientOperation _transientOperation;
        public readonly IScopedOperation _scopedOperation;

        public Guid Id { get; }
        public MyService
         (
             ISingletonOperation singletonOperation,
             ITransientOperation transientOperation,
             IScopedOperation scopedOperation
         )
        {
            Id = Guid.NewGuid();

            _singletonOperation = singletonOperation;
            Console.WriteLine($"Singleton: {_singletonOperation.Id}");
            _transientOperation = transientOperation;
            Console.WriteLine($"_transientOperation: {_transientOperation.Id}");
            _scopedOperation = scopedOperation;
            Console.WriteLine($"_transientOperation: {_transientOperation.Id}");
        }
    }
}
