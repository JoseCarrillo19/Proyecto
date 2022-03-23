using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Autores.Commands.DeleteAutor
{
    public class DeleteAutorCommand : IRequest
    {
        public int Id { get; set; }
    }
}
