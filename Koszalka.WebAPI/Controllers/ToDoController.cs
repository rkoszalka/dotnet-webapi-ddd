using Koszalka.Application.Features.ToDoFeatures.PutToDoTask;
using Koszalka.Application.Features.ToDoFeatures.DeleteToDoReq;
using Koszalka.Application.Features.ToDoFeatures.GetAllTodo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Koszalka.Application.Features.ToDoFeatures.CreateToDoTask;
using Koszalka.Domain.Entities;
using Koszalka.Persistence.Repositories;
using Koszalka.Application.Features.ToDoFeatures.GetAllToDoByOwner;
using Koszalka.Application.Features.ToDoFeatures.GetAllToDoByTask;
using Koszalka.Application.Features.ToDoResponse;
using Microsoft.AspNetCore.Authorization;

namespace Koszalka.WebAPI.Controllers
{
    [ApiController]
    [Route("test")]
    public class ToDoController : Controller
    {
        private readonly IMediator _mediator;

        public ToDoController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<ActionResult<List<RequestResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllToDoRequest(), cancellationToken);
            return Ok(response);
        }
        
        [HttpGet("byOwner/")]
        public async Task<ActionResult<IQueryable<ToDo>>> GetByOwner(CancellationToken cancellationToken, [FromQuery] string owner)
        {
            var request = new GetAllToDoByOwnerRequest(owner);
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("byTask/")]
        public async Task<ActionResult<IQueryable<ToDo>>> GetByTask(CancellationToken cancellationToken, [FromQuery] string task)
        {
            var request = new GetAllToDoByTaskRequest(task);
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<RequestResponse>> Create(CreateTodoRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<RequestResponse>> Delete(DeleteToDoRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<PutToDoResponse>> Put(PutToDoRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }

}
