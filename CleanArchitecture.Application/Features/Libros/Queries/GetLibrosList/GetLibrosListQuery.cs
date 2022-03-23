using MediatR;


namespace CleanArchitecture.Application.Features.Libros.Queries.GetLibrosList
{
    public class GetLibrosListQuery : IRequest<List<LibrosVm>>
    {
        public string UserName { get; set; } = String.Empty;

        public GetLibrosListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
