﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using KeepAlive.Contract;

namespace Knock.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SayHi()
        {
            KeepAliveClient client = new KeepAliveClient();

            ViewBag.Message = client.SayHi("Tom");

            return View();
        }

        public ActionResult AddJob()
        {
            KeepAliveClient client = new KeepAliveClient();

            client.AddJob($"This is {Guid.NewGuid().ToString("B")}");

            return View();
        }
    }
}