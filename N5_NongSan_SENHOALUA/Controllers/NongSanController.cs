using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace N5_NongSan_SENHOALUA.Controllers
{
    public class NongSanController : Controller
    {
        // GET: NongSan
        public ActionResult TrangChu()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
    }
}