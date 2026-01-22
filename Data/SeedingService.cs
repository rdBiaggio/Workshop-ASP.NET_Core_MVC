using System.Linq;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // Verifica se já existem dados no banco
            if (_context.Department.Any())
            {
                return; // Banco já populado
            }

            // Criação dos dados iniciais
            Department d1 = new Department { Name = "Computers" };
            Department d2 = new Department { Name = "Electronics" };

            _context.Department.AddRange(d1, d2);
            _context.SaveChanges();
        }
    }
}
