using ProjectWebAspNet.Data;
using ProjectWebAspNet.Models;
using System.Collections.Generic;
using System.Linq;


namespace ProjectWebAspNet.Services
{
    public class DepartmentService
    {
        private readonly ProjectWebAspNetContext _context;

        public DepartmentService(ProjectWebAspNetContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
