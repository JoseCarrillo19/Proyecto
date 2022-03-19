

using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface ILibroRepository : IAsyncRepository<Libro>
    {
        Task<Libro> GetLibroByNombre(string nombreLibro);
        Task<IEnumerable<Libro>> GetLibroByUserName(string userName);
    }
}
