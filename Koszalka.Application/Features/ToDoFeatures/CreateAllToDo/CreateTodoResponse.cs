using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.CreateToDoTask
{
    public sealed record CreateTodoResponse
    {
        public Guid Id { get; set; }
        public string Task { get; set; }
        public string Owner { get; set; }
    }
}
