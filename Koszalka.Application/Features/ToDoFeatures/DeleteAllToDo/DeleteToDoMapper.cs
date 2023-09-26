using AutoMapper;
using Koszalka.Application.Features.ToDoFeatures.CreateToDoTask;
using Koszalka.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.DeleteToDoResponse
{
    public sealed class DeleteToDoMapper : Profile
    {
        public DeleteToDoMapper()
        {
            CreateMap<DeleteToDoRequest, ToDo>();
            CreateMap<ToDo, DeleteToDoResponse>();
            CreateMap<ToDo, DeleteToDoRequest>();
        }
    }
}
