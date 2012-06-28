using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSC.ReportingRepository;

namespace PSC.Controllers
{
    public class PegawaiController : Controller
    {
        IPegawaiRepository pegawaiRepo;
        public PegawaiController()
        {
            pegawaiRepo = new PegawaiRepository();
        }
        public ActionResult Index()
        {
            return View(pegawaiRepo.GetAll());
        }
    }
}
