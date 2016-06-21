﻿using Business.FibonacciNumbers;
using MvcApp.FibonacciNumbers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.FibonacciNumbers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var ViewModel = new HomeViewModel()
            {
                ResultNumber = 0
            };
            return View(ViewModel);
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel ViewModel)
        {
            var Index = ViewModel.IndexNumber;
            var Result = FibonacciNumberArray.GetFibonacciNumbersByIndex(Index);
            HomeViewModel NewViewModel = new HomeViewModel()
            {
                ResultNumber = Result,
                IndexNumber = Index
            };
            return View(NewViewModel);
        }
    }
}