using bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using bookstore.DataAccess.Repository.IRepository;
using bookstore.Models.ViewModels;
using bookstore.Utility;
using Microsoft.AspNetCore.Authorization;

namespace book_store.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticData.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var products = unitOfWork.Product.GetAll(includeProperties: "Category");
            
            return View(products);
        }

        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new()
            {
                CategoryList = unitOfWork.Category.GetAll(),

                Product = new Product()

            };

            if (id == null || id == 0)
            {
                return View(productVM);
            }
            else 
            {
                productVM.Product = unitOfWork.Product.Get(u => u.Id == id);
                return View(productVM);
            }
        }

        [HttpPost]
        public IActionResult Upsert(ProductVM productVm, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = webHostEnvironment.WebRootPath;

                if(file != null) 
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product");

                    if (!string.IsNullOrEmpty(productVm.Product.ImageUrl)) 
                    {
                        var oldImagePath = Path.Combine(wwwRootPath, productVm.Product.ImageUrl.TrimStart('\\'));

                        if(System.IO.File.Exists(oldImagePath)) 
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using(var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create)) 
                    {
                        file.CopyTo(fileStream);
                    }

                    productVm.Product.ImageUrl = @"\images\product\" + fileName;
                }

                if (productVm.Product.Id == 0)
                {
                    unitOfWork.Product.Add(productVm.Product);
                }
                else 
                {
                    unitOfWork.Product.Update(productVm.Product);
                }
                
                unitOfWork.Save();
                TempData["success"] = "Product Added Successfully";
                return RedirectToAction("Index");
            }
            else 
            {
                ProductVM productVM = new()
                {
                    CategoryList = unitOfWork.Category.GetAll(),
                    Product = new Product()
                };

                return View(productVM);
            }

            return View();

        }


        public IActionResult PlaceOrder()
        {
            TempData["success"] = "Order Has Been Placed Successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product? product = unitOfWork.Product.Get(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteProduct(int? id)
        {
            Product? product = unitOfWork.Product.Get(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            unitOfWork.Product.Remove(product);

            unitOfWork.Save();

            TempData["success"] = "Product Deleted Successfully";

            return RedirectToAction("Index");

        }


        #region
        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Product> productListDto = unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            return Json(new {data =  productListDto});
        }
        #endregion
    }
}
