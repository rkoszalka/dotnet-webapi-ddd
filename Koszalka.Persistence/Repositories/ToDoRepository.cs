using Koszalka.Application.Features.ToDoFeatures.GetAllToDoByOwner;
using Koszalka.Application.Repositories;
using Koszalka.Domain.Entities;
using Koszalka.Persistence.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IQueryable<ToDo> GetByOwner(GetAllToDoByOwnerRequest getAllToDoByOwnerRequest, CancellationToken cancellation, string owner)
        {
            
            return Context.Users.Where(p => p.Owner == owner);

        }
    }
}
