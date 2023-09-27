using Koszalka.Application.Features.ToDoResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllToDoByTask
{
    public sealed record GetAllToDoByTaskRequest : IRequest<List<RequestResponse>>
    {
        public string Task { get; set; }

        public GetAllToDoByTaskRequest(string task) { Task = task; }


    };
}
