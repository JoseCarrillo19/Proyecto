using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Models;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Features.Autores.Commands.CreateAutor
{
    public class CreateAutorCommandHandler : IRequestHandler<CreateAutorCommand, int>
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<CreateAutorCommandHandler> _logger;

        public CreateAutorCommandHandler(IAutorRepository autorRepository, IMapper mapper, IEmailService emailService, ILogger<CreateAutorCommandHandler> logger)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task<int> Handle(CreateAutorCommand request, CancellationToken cancellationToken)
        {
            var autorEntity = _mapper.Map<Autor>(request);
            var newAutor = await _autorRepository.AddAsync(autorEntity);
            _logger.LogInformation($"Autor{newAutor.Id} fue creado exitosamente");
            await SendEmail(newAutor);
            return newAutor.Id;
        }

        private async Task SendEmail(Autor autor)
        {
            var email = new Email
            {
                To = "josecarloscarrillo@gmail.com",
                Body = "El registro de autor se realizo satisfactoriamente",
                Subject = "Mensaje de alerta"
            };

            try
            {

            }
            catch (Exception ex)
            {
                _logger.LogError($"Errores enviando email de {autor.Id}");
            }
        }

    }
}
