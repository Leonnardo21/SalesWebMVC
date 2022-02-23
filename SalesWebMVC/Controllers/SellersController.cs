using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerSevice _sellerService;

        public SellersController(SellerSevice sellerSevice)
        {
            _sellerService = sellerSevice;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();

            return View(list);
        }
    }
}