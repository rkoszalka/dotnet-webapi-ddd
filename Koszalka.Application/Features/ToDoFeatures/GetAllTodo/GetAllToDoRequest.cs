using Koszalka.Application.Features.ToDoResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllTodo
{
    public sealed record GetAllToDoRequest : IRequest<List<RequestResponse>>;
}
