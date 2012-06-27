using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSC.ReportingRepository;

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
