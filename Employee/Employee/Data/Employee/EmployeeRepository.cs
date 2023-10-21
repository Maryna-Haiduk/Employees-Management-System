using Employee;
using Employee.Data;
using Employee.Models;

namespace EmployeeNamespace
{
    public class EmployeeRepository : Repository<Employee.Models.Employee>, IEmployeeRepository
    {
        private readonly IApplicationDbContext _context;

        public EmployeeRepository(IApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }

    public interface IEmployeeRepository : IRepository<Employee.Models.Employee>
    {

    }
}