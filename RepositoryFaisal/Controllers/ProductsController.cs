using Microsoft.AspNetCore.Mvc;
using RepositoryFaisal.Data;
using RepositoryFaisal.Interfaces.Manager;
using RepositoryFaisal.Manager;
using RepositoryFaisal.Models;

namespace RepositoryFaisal.Controllers
{
    public class ProductsController : Controller
    {
        //private ApplicationDbContext _context; //dependency remove
        IProductManger _productManger;
        public ProductsController(/*ApplicationDbContext context*/ ProductManager productManager)
        {
            //_context = context;
            //_productManger = new ProductManager(_context);
            _productManger = productManager;
        }
        public IActionResult Index()
        {
            var product = _productManger.GetAll();

            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            string msg = "";
           bool isSaved= _productManger.Add(product);
            if(isSaved)
            {
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Product Has been Failed";

            }
            ViewBag.msg = msg;
            return View();
        }
        public IActionResult Edit(int id)
        {
            var product = _productManger.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            bool isUpdated=_productManger.Update(product);
            if(isUpdated)
            {
                return RedirectToAction("Index");
            }
             return View(product);
        }
        public IActionResult Details(int id)
        {
            var product =_productManger.GetById(id);
            if(product == null)
            {
                return NotFound(); 
            }
            return View(product);
        } 
        public IActionResult Delete(int id)
        {
            var product=_productManger.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            bool isDeleted =_productManger.Delete(product);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}
