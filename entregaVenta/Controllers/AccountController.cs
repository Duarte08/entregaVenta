using entregaVenta.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using ventasControl.Data;

namespace entregaVenta.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users
                             .FirstOrDefault(u => u.Mail == model.Email && u.Password == model.Password);

                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, model.RememberMe);
                    TempData["UserRole"] = user.Type; // Store the user role in TempData

                    // Redirect based on the user role
                    switch (user.Type)
                    {
                        case "ADMIN":
                            return RedirectToAction("Index", "Home");
                        case "Seller":
                            return RedirectToAction("SellerHome", "Home");
                        case "Accountant":
                            return RedirectToAction("AccountantHome", "Home");
                        default:
                            ModelState.AddModelError("", "Usuario Desconocido.");
                            break;
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt. User does not exist.");
                }
            }

            return View(model);
        }

        // GET: /Account/Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account"); // Redirect to the home page or login page
        }
    }
}
