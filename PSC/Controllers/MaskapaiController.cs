using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSC.ReportingRepository;

namespace PSC.Controllers
{
    [Authorize]
    public class MaskapaiController : Controller
    {
        IMaskapaiReportingRepository maskapaiRepo;
        public MaskapaiController()
        {
            maskapaiRepo = new MaskapaiReportingRepository();
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetById(int id)
        {
            Maskapai maskapai = maskapaiRepo.GetById(id);
            return Json(maskapai, JsonRequestBehavior.AllowGet);
        }
    }
}
