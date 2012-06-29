using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSC.ReportingRepository;
using PSC.Repository;
using PSC.Models;

namespace PSC.Controllers
{
    public class PegawaiController : Controller
    {
        IPegawaiReportingRepository pegawaiReportRepo;
        IPegawaiRepository pegawaiRepo;
        public PegawaiController()
        {
            pegawaiReportRepo = new PegawaiReportingRepository();
            pegawaiRepo = new PegawaiRepository();
        }
        public ActionResult Index()
        {
            LoginInfo loginInfo = new LoginInfo(this.HttpContext);
            if (loginInfo.RoleId == 1)
                return RedirectToAction("IndexManager", "Pegawai");
            return View(pegawaiReportRepo.GetAll());
        }
        public ActionResult IndexManager()
        {
            return View(pegawaiReportRepo.GetAll());
        }
        public ActionResult AddPegawai()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPegawai(AddPegawai pegawai)
        {
            pegawaiRepo.AddPegawai(pegawai);
            return RedirectToAction("Index", "Pegawai");
        }
        public ActionResult UpdatePegawai(int pegawaiId)
        {
            return View(pegawaiReportRepo.GetPegawaiById(pegawaiId));
        }
        [HttpPost]
        public ActionResult UpdatePegawai(UpdatePegawai pegawai)
        {
            pegawaiRepo.UpdatePegawai(pegawai);
            return RedirectToAction("Index", "Pegawai");
        }
        public ActionResult DeletePegawai(int pegawaiId)
        {
            pegawaiRepo.DeletePegawai(pegawaiId);
            return RedirectToAction("Index", "Pegawai");
        }
    }
}
