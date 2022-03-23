using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using MediatR;


namespace CleanArchitecture.Application.Features.Libros.Queries.GetLibrosList
{
    public class GetLibrosListQueryHandler : IRequestHandler<GetLibrosListQuery, List<LibrosVm>>
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;

        public GetLibrosListQueryHandler(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository;
            _mapper = mapper;
        }

        public async Task<List<LibrosVm>> Handle(GetLibrosListQuery request, CancellationToken cancellationToken)
        {
            var libroList = await _libroRepository.GetLibroByUserName(request.UserName);
            return _mapper.Map<List<LibrosVm>>(libroList);
        }
    }
}
