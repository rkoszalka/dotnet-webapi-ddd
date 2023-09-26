using Koszalka.Application.Repositories;
using Koszalka.Domain.Entities;
using Koszalka.Persistence.Context;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public Task Save(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        public int Delete(ToDo todo)
        {
            _context.Attach(todo);
            _context.Remove(todo);
            return _context.SaveChanges();
        }
    }
}
