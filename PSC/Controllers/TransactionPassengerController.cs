using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PSC.Repository;

namespace PSC.Controllers
{
    public class TransactionPassengerController : Controller
    {
        ITransactionPassengerRepository passengerRepo;
        public TransactionPassengerController()
        {
            passengerRepo = new TransactionPassengerRepository();
        }
        public JsonResult Bayar(TransactionPassenger transaction)
        {
            try
            {
                passengerRepo.AddTransactionPassenger(transaction);
                return Json(new { error = false, data = transaction }, JsonRequestBehavior.AllowGet);
            }
            catch (ApplicationException ex)
            {
                return Json(new { error = true, data = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
