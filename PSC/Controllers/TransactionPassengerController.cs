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
        public JsonResult Bayar(TransactionPassenger transaction)
        {
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }
    }
}
