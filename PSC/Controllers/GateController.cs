using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSC.ReportingRepository;
using PSC.Repository;

namespace PSC.Controllers
{
    [Authorize]
    public class GateController : Controller
    {
        IGateReportingRepository gateReportRepo;
        IGateRepository gateRepo;
        public GateController()
        {
            gateReportRepo = new GateReportingRepository();
            gateRepo = new GateRepository();
        }
        public ActionResult Index()
        {
            IList<Gate> gates = gateReportRepo.GetAllGate();
            return View(gates);
        }
        public JsonResult GetById(int id)
        {
            Gate gate = gateReportRepo.GetById(id);
            return Json(gate, JsonRequestBehavior.AllowGet);
        }
        public ActionResult UpdateGate(int gateId)
        {
            Gate gate = gateReportRepo.GetById(gateId);
            return View(gate);
        }
        [HttpPost]
        public ActionResult UpdateGate(UpdateGate gate)
        {
            gateRepo.UpdateGate(gate);
            return RedirectToAction("Index", "Gate");
        }

        public ActionResult DeleteGate(int gateId)
        {
            gateRepo.DeleteGate(gateId);
            return RedirectToAction("Index", "Gate");
        }

        public ActionResult AddGate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGate(AddGate gate)
        {
            gateRepo.AddGate(gate);
            return RedirectToAction("Index", "Gate");
        }
    }
}
