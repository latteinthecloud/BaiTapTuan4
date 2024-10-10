using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLySanPham.Models;

namespace WebsiteQuanLySanPham.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            string connection = "Server=localhost;Database=QuanLySanPham;Integrated Security=True;";
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connection);
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
    }
}