using AutoMapper;
using Koszalka.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllTodo
{
    public sealed class GetAllToDoMapper : Profile
    {
        public GetAllToDoMapper()
        {
            CreateMap<ToDo, GetAllToDoResponse>();
        }
    }
}
