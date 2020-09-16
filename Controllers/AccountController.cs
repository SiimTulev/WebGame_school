using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebGame.Models.AccountViewModels;
using WebGame.Models.WebGame;

namespace WebGame.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }
        private readonly webgameContext _context;

        public AccountController(webgameContext context, UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;

            _context = context;
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("SelectGame", "Game");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result = await SignInMgr.PasswordSignInAsync(model.UserName, model.Password, false, false);

                if (result.Succeeded)
                {
                    //return RedirectToLocal(returnUrl);
                    return RedirectToAction("SelectGame", "Game");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Playeraccount playerAccount, RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            try
            {
                AppUser user = await UserMgr.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    user = new AppUser();
                    user.UserName = model.UserName;
                    user.Email = model.Email;

                    IdentityResult result = await UserMgr.CreateAsync(user, model.Password);

                    playerAccount.Wins = 0;
                    playerAccount.Losts = 0;
                    playerAccount.AccountId = user.Id;
                    playerAccount.AccountName = model.UserName;
                    _context.Add(playerAccount);
                    await _context.SaveChangesAsync();

                    // automatic login
                    var login = await SignInMgr.PasswordSignInAsync(model.UserName, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        ViewBag.FirstLogin = true;
                        return RedirectToAction(nameof(GameController.Tutorial), "Game", new { FirstLogin = true });
                    }
                    else
                    {
                        ViewBag.Error = "Something went wrong. Try Again!";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Error = "This username is already in use! Try another name.";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View();

        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(GameController.SelectGame), "SelectGame");
            }
        }
    }
}