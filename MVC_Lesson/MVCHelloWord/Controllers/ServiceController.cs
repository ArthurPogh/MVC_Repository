﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHelloWord.Models;
namespace MVCHelloWord.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Pizza(int page = 1)
        {

            ViewBag.Page = page;


            for(int i = 0; i < 10;i++)
            {

                ViewData[$"data{i}"] = i;
            }


            var quantity = 2;


            var list = ModelFactory.GetPizzaList();


            var model = list
                .Skip((page - 1) * quantity)
                .Take(quantity)
                .Select(p => ModelFactory.Create(p));


            return View(model);
        }
    }
}