using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_QLSach_ThuVien.Areas.Admin.Controllers
{
    public class ThongKe_BaoCaoController : Controller
    {
        // GET: Admin/ThongKe_BaoCao
        public ActionResult BaoCaoSach()
        {
            return View();
        }
        public ActionResult ThongKeTheoKy()
        {
            return View();
        }
        public ActionResult ThongKeDocGia()
        {
            return View();
        }
    }
}