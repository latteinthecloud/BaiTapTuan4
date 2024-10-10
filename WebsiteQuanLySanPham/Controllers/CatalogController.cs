using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLySanPham.Models;

namespace WebsiteQuanLySanPham.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            string connection = "Server=localhost;Database=QuanLySanPham;Integrated Security=True;";
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connection);
            List<Catalog> dsCatalog = context.Catalogs.ToList();
            return View(dsCatalog);
        }
    }
}