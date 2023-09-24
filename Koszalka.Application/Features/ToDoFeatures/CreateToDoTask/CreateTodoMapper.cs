using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koszalka.Domain.Entities;


namespace Koszalka.Application.Features.ToDoFeatures.CreateToDoTask
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateTodoRequest, ToDo>();
            CreateMap<ToDo, CreateTodoResponse>();
        }
    }
}
