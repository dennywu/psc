using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSC.ReportingRepository;

namespace PSC.Controllers
{
    [Authorize]
    public class GateController : Controller
    {
        IGateReportingRepository gateRepo;
        public GateController()
        {
            gateRepo = new GateReportingRepository();
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetById(int id)
        {
            Gate gate = gateRepo.GetById(id);
            return Json(gate, JsonRequestBehavior.AllowGet);
        }
    }
}
