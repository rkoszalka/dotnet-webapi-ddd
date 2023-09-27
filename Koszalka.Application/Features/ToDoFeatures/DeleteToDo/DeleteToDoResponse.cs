using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.DeleteToDoReq
{
    public class DeleteToDoResponse
    {
        public string DeleteStatus { get; set; }

        public DeleteToDoResponse(string status) 
        {
            this.DeleteStatus = status;
        }
        
   }
}
