using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koszalka.Application.Features.ToDoResponse;
using MediatR;

namespace Koszalka.Application.Features.ToDoFeatures.CreateToDoTask
{

    public sealed record CreateTodoRequest(string Task, string Owner) : IRequest<RequestResponse>;

}
