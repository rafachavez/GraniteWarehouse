using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteWarehouse.Data;
using Microsoft.AspNetCore.Mvc;

namespace GraniteWarehouse.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        public readonly ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }
    }
}