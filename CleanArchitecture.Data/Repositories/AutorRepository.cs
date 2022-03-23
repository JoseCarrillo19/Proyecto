

using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Data;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class AutorRepository : RepositoryBase<Autor>, IAutorRepository
    {
        public AutorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
