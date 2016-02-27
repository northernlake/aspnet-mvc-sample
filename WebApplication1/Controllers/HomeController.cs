﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Hostname = Environment.MachineName;
            ViewBag.ApplicationVersion = ConfigurationManager.AppSettings["ApplicationVersion"];
            ViewBag.Environment = ConfigurationManager.AppSettings["Environment"];
            ViewBag.BuildNumber = ConfigurationManager.AppSettings["BuildNumber"];
            ViewBag.BuildHash = ConfigurationManager.AppSettings["BuildHash"];
            ViewBag.BuildDate = ConfigurationManager.AppSettings["BuildDate"];
            ViewBag.BuildUrl = ConfigurationManager.AppSettings["BuildUrl"];
            ViewBag.DeployNumber = ConfigurationManager.AppSettings["DeployNumber"];
            ViewBag.ReleaseNumber = ConfigurationManager.AppSettings["ReleaseNumber"];
      
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewBag.MvcVersion = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewBag.Runtime = (isMono ? "Mono" : ".NET") + " " + Environment.Version.ToString();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}