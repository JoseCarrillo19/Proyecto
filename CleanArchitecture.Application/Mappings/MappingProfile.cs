using AutoMapper;
using CleanArchitecture.Application.Features.Autores.Commands.CreateAutor;
using CleanArchitecture.Application.Features.Libros.Queries.GetLibrosList;
using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Libro, LibrosVm>();
            CreateMap<CreateAutorCommand, Autor>();
        }
    }
}
