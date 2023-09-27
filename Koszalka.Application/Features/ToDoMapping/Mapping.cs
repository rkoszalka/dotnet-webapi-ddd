using AutoMapper;
using Koszalka.Application.Features.ToDoFeatures.CreateToDoTask;
using Koszalka.Application.Features.ToDoFeatures.DeleteToDoReq;
using Koszalka.Application.Features.ToDoFeatures.GetAllTodo;
using Koszalka.Application.Features.ToDoFeatures.GetAllToDoByOwner;
using Koszalka.Application.Features.ToDoFeatures.PutToDoTask;
using Koszalka.Application.Features.ToDoResponse;
using Koszalka.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.MappingProfile
{
    public sealed class EventMapping : Profile
    {
        public EventMapping()
        {
            CreateMap<CreateTodoRequest, ToDo>();
            CreateMap<DeleteToDoRequest, ToDo>();
            CreateMap<PutToDoRequest, ToDo>();
            CreateMap<ToDo, RequestResponse>();
            CreateMap<ToDo, RequestResponse>();
            CreateMap<ToDo, DeleteToDoRequest>();
            CreateMap<ToDo, RequestResponse>();
            CreateMap<ToDo, RequestResponse>();
            CreateMap<ToDo, RequestResponse>();
        }
    }
}
