using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteWarehouse.Data;
using GraniteWarehouse.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraniteWarehouse.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialTagsController : Controller
    {
        public readonly ApplicationDbContext _db;

        public SpecialTagsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}