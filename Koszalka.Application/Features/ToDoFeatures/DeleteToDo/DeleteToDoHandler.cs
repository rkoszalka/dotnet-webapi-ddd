using AutoMapper;
using Koszalka.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Koszalka.Domain.Entities;
using Koszalka.Application.Features.ToDoFeatures.DeleteToDoReq;

namespace Koszalka.Application.Features.ToDoFeatures.DeleteToDo
{
    public sealed class DeleteToDoHandler : IRequestHandler<DeleteToDoRequest, DeleteToDoResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IToDoRepository _toDoRepository;
        private readonly IMapper _mapper;

        public DeleteToDoHandler(IUnitOfWork unitOfWork, IToDoRepository toDoRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _toDoRepository = toDoRepository;
            _mapper = mapper;
        }

        public async Task<DeleteToDoResponse> Handle(DeleteToDoRequest request, CancellationToken cancellationToken)
        {
            var toDo = _mapper.Map<ToDo>(request);

            try
            {
                _toDoRepository.Delete(toDo);
                 _unitOfWork.Delete(toDo);
                return new DeleteToDoResponse("[ " + toDo.Id + " ]" + " deleted with success");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return new DeleteToDoResponse("[ " + toDo.Id + " ]" + " not found or error while deleting");

        }
    }

}