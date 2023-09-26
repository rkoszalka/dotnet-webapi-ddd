using AutoMapper;
using Koszalka.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Koszalka.Domain.Entities;


namespace Koszalka.Application.Features.ToDoFeatures.PutToDoTask
{
    public sealed class PutToDoHandler : IRequestHandler<PutToDoRequest, PutToDoResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IToDoRepository _toDoRepository;
        private readonly IMapper _mapper;

        public PutToDoHandler(IUnitOfWork unitOfWork, IToDoRepository toDoRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _toDoRepository = toDoRepository;
            _mapper = mapper;
        }

        public async Task<PutToDoResponse> Handle(PutToDoRequest request, CancellationToken cancellationToken)
        {
            var toDo = _mapper.Map<ToDo>(request);
            try
            {
                _toDoRepository.Update(toDo);
                var updatedToDo = _unitOfWork.Update(toDo);

                return new PutToDoResponse("[ " + toDo.Id + " ]" + " updated with success");
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString);
            }

            return new PutToDoResponse("[ " + toDo.Id + " ]" + " not found or error while updating");

        }
    }

}
