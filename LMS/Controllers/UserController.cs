using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LEntity;
using LService;

namespace LMS.Controllers
{
    public class UserController : BaseController
    {
        //
        // GET: /User/
        IUserService service = ServiceFactory.GetUserService();
        public ActionResult Index()
        {
            ViewBag.message = "";
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
           return RedirectToAction("Index");
        
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
            
        }
        [HttpGet]
        public ActionResult ChangePassword()
        {
            ViewBag.msg = "";
            return View();

        }
        [ActionName("ChangePassword")]
        public ActionResult ChangePassword(FormCollection fm)
        {
            string op = fm["old"];
            string np = fm["nps"];
            User u = service.Get(Convert.ToInt32(Session["uid"]));
            if (op == u.Password)
            {
                if (np.Length < 5)
                {
                    ViewBag.msg = "Password length must be atleast 5";
                    return View();
                }
                else
                {
                    u.Password = np;
                    service.Update(u);
                    if (Convert.ToInt32(Session["type"]) == 1)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("Index", "AUser");
                    }

                }
            }
            else
            {
                ViewBag.msg = "Wrong old password";
                return View();
            }
        }
        [HttpPost]
        public ActionResult Signup(User u)
        {
            if (ModelState.IsValid)
            {
                u.Type = 0;
                service.Insert(u);

                return RedirectToAction("Index");
            }
            else
            {
                return View(u);
            }
        }
        [ActionName("Login")]
        public ActionResult Login(FormCollection fm)
        {
            string un = fm["un"];
            string ps = fm["ps"];
            User u=service.GetByPass(un, ps);
            if (u.Type == 10)
            {
                ViewBag.msg = "Invalid username or password";
                return View();
            }
            else if (u.Type == 1)
            {
                Session["uid"] = u.ID;
                Session["type"] =1;
                return RedirectToAction("Index", "Admin");
            }
            else if (u.Type == 0 || u.Type == 5)
            {
                Session["type"] = u.Type; ;
                Session["uid"] = u.ID;
                return RedirectToAction("Index", "AUser");
            }
            else 
            {
                Session["uid"] = u.ID;
                return RedirectToAction("Index", "User");
            }
            

            
            
        }

    }
}
