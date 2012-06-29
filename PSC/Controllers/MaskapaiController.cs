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
    public class MaskapaiController : Controller
    {
        IMaskapaiReportingRepository maskapaiReportRepo;
        IMaskapaiRepository maskapaiRepo;
        public MaskapaiController()
        {
            maskapaiReportRepo = new MaskapaiReportingRepository();
            maskapaiRepo = new MaskapaiRepository();
        }
        public ActionResult Index()
        {
            IList<Maskapai> maskapai = maskapaiReportRepo.GetAllMaskapai();
            return View(maskapai);
        }
        public JsonResult GetById(int id)
        {
            Maskapai maskapai = maskapaiReportRepo.GetById(id);
            return Json(maskapai, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateMaskapai(int maskapaiId)
        {
            Maskapai maskapai = maskapaiReportRepo.GetById(maskapaiId);
            return View(maskapai);
        }
        [HttpPost]
        public ActionResult UpdateMaskapai(UpdateMaskapai maskapai)
        {
            if (maskapai.JenisId == 0)
                throw new ApplicationException("Silahkan Pilih Jenis Maskapai Penerbangan");
            maskapaiRepo.UpdateMaskapai(maskapai);
            return RedirectToAction("Index", "Maskapai");
        }

        public ActionResult DeleteMaskapai(int maskapaiId)
        {
            maskapaiRepo.DeleteMaskapai(maskapaiId);
            return RedirectToAction("Index", "Maskapai");
        }

        public ActionResult AddMaskapai()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMaskapai(AddMaskapai maskapai)
        {
            maskapaiRepo.AddMaskapai(maskapai);
            return RedirectToAction("Index", "Maskapai");
        }
    }
}
