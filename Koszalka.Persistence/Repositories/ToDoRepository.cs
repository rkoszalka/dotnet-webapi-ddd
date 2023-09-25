using Koszalka.Application.Repositories;
using Koszalka.Domain.Entities;
using Koszalka.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Persistence.Repositories
{
    public class ToDoRepository : BaseRepository<ToDo>, IToDoRepository
    {
        public ToDoRepository(DataContext context) : base(context)
        {
        }

        public Task<ToDo> GetByOwner(string owner, CancellationToken cancellationToken)
        {
            return Context.Users.FirstOrDefaultAsync(x => x.Owner == owner, cancellationToken);
        }
    }
}
