

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IPais Paises { get; }
        //IRegion Regiones { get; }

        Task<int> SaveAsync();
    }
}