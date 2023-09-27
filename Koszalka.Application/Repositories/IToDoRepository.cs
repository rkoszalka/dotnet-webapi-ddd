using Koszalka.Application.Features.ToDoFeatures.GetAllToDoByOwner;
using Koszalka.Application.Features.ToDoFeatures.GetAllToDoByTask;
using Koszalka.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Repositories
{
    public interface IToDoRepository : IBaseRepository<ToDo>
    {
        IQueryable<ToDo> GetByOwner(GetAllToDoByOwnerRequest getAllToDoByOwnerRequest, CancellationToken cancellationToken, string owner);

        IQueryable<ToDo> GetByTask(GetAllToDoByTaskRequest getAllToDoByTaskRequest, CancellationToken cancellationToken, string task);


    }
}
