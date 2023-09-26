using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Koszalka.Application.Features.ToDoFeatures.PutToDoTask
{

    public sealed record PutToDoRequest(string Task, string Owner, Guid Id) : IRequest<PutToDoResponse>;

}
