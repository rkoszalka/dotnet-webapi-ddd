using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Koszalka.Application.Features.ToDoFeatures.DeleteToDoResponse
{

    public sealed record DeleteToDoRequest(string Task, string Owner, Guid Id) : IRequest<DeleteToDoResponse>;

}
