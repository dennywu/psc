using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSC.ReportingRepository;

namespace PSC.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        IReportRepository reportRepo;
        public ReportController()
        {
            reportRepo = new ReportRepository();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetDetailPassenger(string fromDate, string toDate)
        {
            IList<DetailTransaction> details = reportRepo.GetDetailTransactionByDate(fromDate, toDate);
            return View("DetailTransaksi", details);
        }
        public ActionResult DetailPerHari()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DetailPerHari(string fromDate, string toDate)
        {
            IList<DetailTransactionDaily> details = reportRepo.GetDetailTransactionDailyByDate(fromDate, toDate);
            return View("DetailTransaksiPerHari", details);
        }
        public ActionResult DetailPerBulan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DetailPerBulan(string fromMonth, string fromYear, string toMonth, string toYear)
        {
            IList<DetailTransactionMonthly> details = reportRepo.GetDetailTransactionMonthlyByDate(fromYear + fromMonth, toYear + toMonth);
            return View("DetailTransaksiPerBulan", details);
        }
    }
}
