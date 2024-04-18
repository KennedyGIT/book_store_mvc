using bookstore.DataAccess.Repository.IRepository;
using bookstore.Models;
using bookstore.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace book_store.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {

        public readonly IUnitOfWork unitOfWork;
        public ShoppingCartVM ShoppingCartVM { get; set; }

        public CartController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            ShoppingCartVM = new()
            {
                ShoppingCartList = unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId, includeProperties: "Product"),
            };

            foreach (var cart in ShoppingCartVM.ShoppingCartList) 
            {
                cart.Price = GetPriceBasedOnQuantity(cart);
                ShoppingCartVM.Total += (cart.Price * cart.Count);
            }
            return View(ShoppingCartVM);
        }

        private double GetPriceBasedOnQuantity(ShoppingCart shoppingCart) 
        {
            if (shoppingCart.Count <= 50)
            {
                return shoppingCart.Product.Price;
            }
            else 
            {
                if (shoppingCart.Count <= 100)
                {
                    return shoppingCart.Product.Price50;
                }
                else 
                {
                    return shoppingCart.Product.Price100;
                }
            }
        }

        public IActionResult Plus(int cartid) 
        {
            var cartFromDb = unitOfWork.ShoppingCart.Get(u => u.Id == cartid);
            cartFromDb.Count += 1;
            unitOfWork.ShoppingCart.Update(cartFromDb);
            unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Minus(int cartid)
        {
            var cartFromDb = unitOfWork.ShoppingCart.Get(u => u.Id == cartid);
            if (cartFromDb.Count <= 1)
            {
                unitOfWork.ShoppingCart.Remove(cartFromDb);
            }
            else 
            {
                cartFromDb.Count -= 1;
                unitOfWork.ShoppingCart.Update(cartFromDb);
            }
            unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        

        public IActionResult Remove(int cartid)
        {
            var cartFromDb = unitOfWork.ShoppingCart.Get(u => u.Id == cartid);
            
            unitOfWork.ShoppingCart.Remove(cartFromDb);
            
            unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}
