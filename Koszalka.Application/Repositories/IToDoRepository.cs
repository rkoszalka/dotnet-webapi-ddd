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
        IQueryable<ToDo> GetByOwner(string owner, CancellationToken cancellationToken);


    }
}
