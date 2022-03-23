using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;


namespace CleanArchitecture.Application.Features.Autores.Commands.UpdateAutor
{
    public class UpdateAutorCommandHandler : IRequestHandler<UpdateAutorCommand>
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateAutorCommandHandler> _logger;

        public UpdateAutorCommandHandler(IAutorRepository autorRepository, IMapper mapper, ILogger<UpdateAutorCommandHandler> logger)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateAutorCommand request, CancellationToken cancellationToken)
        {
            var autorToUpdate = await _autorRepository.GetByIdAsync(request.Id);

            if (autorToUpdate == null)
            {
                _logger.LogError($"no se encontro el autor id {request.Id}");
                throw new NotFoundException(nameof(Autor), request.Id);
            }

            _mapper.Map(request, autorToUpdate, typeof(UpdateAutorCommand), typeof(Autor));
            await _autorRepository.UpdateAsync(autorToUpdate);
            _logger.LogInformation($"La operacion fue exitosa actualizando el autor {request.Id}");
            return Unit.Value;
        }
    }
}
