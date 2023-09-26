using AutoMapper;
using Koszalka.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllTodoByOwner
{
    public sealed class GetAllToDoByOwnerMapper : Profile
    {
        public GetAllToDoByOwnerMapper()
        {
            CreateMap<ToDo, GetAllToDoByOwnerResponse>();
        }
    }
}
