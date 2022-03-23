using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Autores.Commands.CreateAutor
{
    public class CreateAutorCommand : IRequest<int>
    {
        public string Nombre { get; set; } = String.Empty;

    }
}
