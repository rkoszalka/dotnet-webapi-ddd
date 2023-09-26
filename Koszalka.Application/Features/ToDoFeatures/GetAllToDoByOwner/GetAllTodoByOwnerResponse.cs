using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllTodoByOwner
{
    public sealed record GetAllToDoByOwnerResponse
    {
        public Guid Id { get; set; }
        public string Task { get; set; }
        public string Owner { get; set; }
    }
}
