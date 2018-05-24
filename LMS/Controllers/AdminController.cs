using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LEntity;
using LService;
namespace LMS.Controllers
{
    public class AdminController : Controller
    {        
        //
        // GET: /Admin/

        IUserService service = ServiceFactory.GetUserService();
        IBorrowService bservice = ServiceFactory.GetBorrowService();
        IBookService bkservice = ServiceFactory.GetBookService();
        ICategoryService cservice = ServiceFactory.GetCategoryService();
        IDeskService dservice = ServiceFactory.GetDeskService();

       public ActionResult Index()
        {
            if (Convert.ToInt32(Session["type"]) == 1)
                return View();
            else
                return RedirectToAction("Index", "User");
        }
       public ActionResult Borrowdetails()
       {
           ViewBag.blist = bkservice.GetAll();
           ViewBag.ulist = service.GetAll();
           return View(bservice.GetAll());
       }
        public ActionResult Book()
        {
            return RedirectToAction("Index", "Book");
        }
        public ActionResult Desk()
        {
            return View();
        }
        public ActionResult User()
        {
            return View(service.GetAll());
        }
        public ActionResult Return(int id)
        {
            Borrow b = bservice.Get(id);
            Book bk = bkservice.Get(b.Book);
            bk.Copy = bk.Copy + 1;
            bkservice.Update(bk);
            b.Status = 1;
            b.Rdate = DateTime.Now;
            bservice.Update(b);
            return RedirectToAction("Borrowdetails");
        }
        public ActionResult Block(int id)
        {
            User u = service.Get(id);
            u.Type = -1;
            service.Update(u);
            return RedirectToAction("User");
        }
        public ActionResult UnBlock(int id)
        {
            User u = service.Get(id);
            u.Type = 0;
            service.Update(u);
            return RedirectToAction("User");
        }
        public ActionResult Logout()
        {
            return View();
        }
        

    }
}
