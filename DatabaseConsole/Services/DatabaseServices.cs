using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConsole.Models;
using DatabaseConsole.Data;
using Microsoft.EntityFrameworkCore;

namespace DatabaseConsole.Services
{
    public class DatabaseServices
    {
/*        private readonly DatabaseContext _context;

        public DatabaseServices(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers
                .AsNoTracking()
                .ToList();
        }

        public Customer? GetById(int id)
        {
            return _context.Customers
                .Include(c => c.CustomerId)
                .AsNoTracking()
                .SingleOrDefault(c => c.CustomerId == id);
        }*/
    }
}
