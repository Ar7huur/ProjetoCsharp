using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers {
    public class SellersController : Controller {

        //Declaração de dependência para seller service
        private readonly SellerService _sellerService;
        public SellersController(SellerService sellerService) {
            _sellerService = sellerService;
        }


        public IActionResult Index() {
            //retorna uma lista de seller.
            var list = _sellerService.FindAll();
            
            //assim que receber a lista, passo ela como argumento na view. - dinâmica MVC.
            return View(list);
        }
    }
}
