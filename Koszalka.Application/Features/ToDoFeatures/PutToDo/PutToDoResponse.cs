using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.PutToDoTask
{
    public class PutToDoResponse
    {
        public string UpdateStatus { get; set; }

        public PutToDoResponse(string status)
        {
            this.UpdateStatus = status;
        }

    }
}
