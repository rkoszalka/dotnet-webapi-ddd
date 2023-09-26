using AutoMapper;
using Koszalka.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Koszalka.Domain.Entities;


namespace Koszalka.Application.Features.ToDoFeatures.DeleteToDoResponse
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
            try
            {
                var toDo = _mapper.Map<ToDo>(request);
                _toDoRepository.Delete(toDo);
                 _unitOfWork.Delete(toDo);
                return _mapper.Map<DeleteToDoResponse>(toDo);
            } catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
            
        }
    }

}
