using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_QLSach_ThuVien.Areas.Admin.Controllers
{
    public class QLDanhMucController : Controller
    {
        // GET: Admin/QLDanhMuc
        public ActionResult DanhMuc()
        {
            return View();
        }
        public ActionResult Sach()
        {
            return View();
        }
        public ActionResult BanDoc()
        {
            return View();
        }
        public ActionResult ThanhVien()
        {
            return View();
        }
        public ActionResult NhaXuatBan()
        {
            return View();
        }
    }
}