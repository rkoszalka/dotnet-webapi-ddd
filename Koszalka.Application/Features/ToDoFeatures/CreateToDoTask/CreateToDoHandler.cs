using AutoMapper;
using Koszalka.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Koszalka.Domain.Entities;


namespace Koszalka.Application.Features.ToDoFeatures.CreateToDoTask
{
    public sealed class CreateTodoHandler : IRequestHandler<CreateTodoRequest, CreateTodoResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IToDoRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateTodoHandler(IUnitOfWork unitOfWork, IToDoRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<CreateTodoResponse> Handle(CreateTodoRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<ToDo>(request);
            _userRepository.Create(user);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateTodoResponse>(user);
        }
    }

}
