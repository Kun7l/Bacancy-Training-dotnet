namespace Product_Catalog_Api.Repository.Repository
{
    public interface IIdService { Guid Id { get; } }
    public interface ITransientService : IIdService { }
    public interface IScopedService : IIdService { }
    public interface ISingletonService : IIdService { }

    public class IdService : ITransientService, IScopedService, ISingletonService
    {
        public Guid Id { get; } = Guid.NewGuid();
    }

}
