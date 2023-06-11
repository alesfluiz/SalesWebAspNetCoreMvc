using ProjectWebAspNet.Data;
using ProjectWebAspNet.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectWebAspNet.Services
{
    public class DepartmentService
    {
        private readonly ProjectWebAspNetContext _context;

        public DepartmentService(ProjectWebAspNetContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
