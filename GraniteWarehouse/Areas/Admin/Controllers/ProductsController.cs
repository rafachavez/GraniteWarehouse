using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteWarehouse.Data;
using GraniteWarehouse.Models;
using GraniteWarehouse.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GraniteWarehouse.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db; // this is for dependency injection

        public ProductViewModels ProductsVM { get; set; }

        public ProductsController(ApplicationDbContext db) // contructor
        {
            _db = db;
            ProductsVM = new ProductViewModels() //initialize the viewmodel
            {
                ProductTypes = _db.ProductTypes.ToList(),
                SpecialTags = _db.SpecialTags.ToList(),
                Products = new Models.Products()
            };
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}