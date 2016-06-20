using Business;
using MVC.Fibonacci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Fibonacci.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var view = new ViewModel()
            {
                cikti = 0
            };
            return View(view);
        }

        [HttpPost]
        public ActionResult Index(ViewModel viewmodel)
        {
            var indeks = viewmodel.sayi;
            var cikti = Sayilar.Islem(indeks);
            ViewModel model = new ViewModel()
            {
                cikti = cikti,
                sayi = indeks
            };
            return View(model);
        }
    }
}