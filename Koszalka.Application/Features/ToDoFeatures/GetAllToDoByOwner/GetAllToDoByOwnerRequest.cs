using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllTodoByOwner
{
    public sealed record GetAllToDoByOwnerRequest : IRequest<List<GetAllToDoByOwnerResponse>>;
}
