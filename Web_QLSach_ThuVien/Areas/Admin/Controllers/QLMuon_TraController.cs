using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_QLSach_ThuVien.Areas.Admin.Controllers
{
    public class QLMuon_TraController : Controller
    {
        // GET: Admin/QLMuon_Tra
        public ActionResult Muon_Tra()
        {
            return View();
        }

        public ActionResult CTMuonTra()
        {
            return View();
        }
        public ActionResult QLPhat()
        {
            return View();
        }
    }
}