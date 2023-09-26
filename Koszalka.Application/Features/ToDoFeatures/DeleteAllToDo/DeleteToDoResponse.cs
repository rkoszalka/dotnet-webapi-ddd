using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.DeleteToDoResponse
{
    public sealed record DeleteToDoResponse
    {
        public  string DeleteStatus { get; set; }

        public DeleteToDoResponse() 
        {
            this.DeleteStatus = "deleted";
        }
        
   }
}
