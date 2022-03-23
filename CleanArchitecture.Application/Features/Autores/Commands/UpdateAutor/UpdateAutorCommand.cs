

using MediatR;

namespace CleanArchitecture.Application.Features.Autores.Commands.UpdateAutor
{
    public class UpdateAutorCommand : IRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}
