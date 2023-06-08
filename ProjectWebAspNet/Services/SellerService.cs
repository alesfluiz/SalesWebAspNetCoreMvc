using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectWebAspNet.Data;
using ProjectWebAspNet.Models;

namespace ProjectWebAspNet.Services
{
    public class SellerService
    {
        private readonly ProjectWebAspNetContext _context;

        public SellerService(ProjectWebAspNetContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
