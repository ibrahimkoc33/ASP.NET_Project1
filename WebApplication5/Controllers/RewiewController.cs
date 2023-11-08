﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class RewiewController : Controller
    {
        RewiewManager rm = new RewiewManager(new EFRewiewRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddRewiew()
        {
            return PartialView();
        }
        public PartialViewResult RewiewList(int id)
        {
            var values = rm.ListAll(id);
            return PartialView(values);
        }

    }
}
