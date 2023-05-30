using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services {
    public class SellerService {

        private readonly SalesWebMVCContext _context;

        //construtor
        public SellerService(SalesWebMVCContext context) { 
            _context = context;
        }

        //List com findall para todas operãções.
        public List <Seller> FindAll() {
            return _context.Seller.ToList();
        }

    }
}
