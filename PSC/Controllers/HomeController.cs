﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using PSC.ReportingRepository;
using PSC.Models;

namespace PSC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        IMaskapaiReportingRepository maskapaiRepo;
        IGateReportingRepository gateRepo;
        public HomeController()
        {
            maskapaiRepo = new MaskapaiReportingRepository();
            gateRepo = new GateReportingRepository();
        }
        public ActionResult Index()
        {
            LoginInfo loginInfo = new LoginInfo(this.HttpContext);
            if (loginInfo.RoleId == 1)
                return RedirectToAction("Index", "Report");
            IList<Maskapai> maskapai = maskapaiRepo.GetAllMaskapai();
            ViewBag.Gate = gateRepo.GetAllGate();
            return View(maskapai);
        }
        public ActionResult Maskapai()
        {
            return View();
        }
    }
}
