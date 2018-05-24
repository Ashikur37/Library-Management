using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using LEntity;
using LService;
namespace LMS.Controllers
{   
    public class AUserController : Controller
    {
        IBookService service = ServiceFactory.GetBookService();
        ICategoryService cservice = ServiceFactory.GetCategoryService();
        IDeskService dservice = ServiceFactory.GetDeskService();
        IBorrowService bservice = ServiceFactory.GetBorrowService();
        // GET: /AUser/

        public ActionResult Index()
        {
            if (Convert.ToInt32(Session["type"])!=0)
                return RedirectToAction("Index", "User");
            else
            return View();
        }

        public ActionResult Searchbook()
        {
            if (Convert.ToInt32(Session["type"]) != 0)
                return RedirectToAction("Index", "User");
            else
            return View();
        }
        public ActionResult Allbook()
        {
            if (Convert.ToInt32(Session["type"]) != 0)
                return RedirectToAction("Index", "User");
            else
            {
                ViewBag.cat_list = cservice.GetAll();
                ViewBag.dlist = dservice.GetAll();
                return View("SearchBooks", service.GetAll());
            }
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SearchBook(string key)
        {
            if (Convert.ToInt32(Session["type"]) != 0)
                return RedirectToAction("Index", "User");
            else
            {
                ViewBag.cat_list = cservice.GetAll();
                ViewBag.dlist = dservice.GetAll();
                return View("SearchBooks", service.getSearch(key));
            }
        }

        public ActionResult Borrow(int id)
        {
            if (Convert.ToInt32(Session["type"]) != 0)
                return RedirectToAction("Index", "User");
            else
            return View(service.Get(id));
        }
        public ActionResult BorrowHistory()
        {
            if (Convert.ToInt32(Session["type"]) != 0)
                return RedirectToAction("Index", "User");
            else
            {
                ViewBag.blist = service.GetAll();
                return View(bservice.GetByBorrower(Convert.ToInt32(Session["uid"])));
            
            }
        }
        public ActionResult ConfirmBorrow(int id)
        {
            Borrow b=new Borrow();
            b.Book = id;
            b.Borrower = Convert.ToInt32(Session["uid"]);
            
            DateTime today=DateTime.Now;
            b.Bdate = today;
            b.Edate = today.AddDays(7);
            b.Status = 0;
            bservice.Insert(b);
            Book bk=service.Get(id);
            bk.Copy = bk.Copy - 1;
            service.Update(bk);
            return RedirectToAction("Index");
        }



    }
}
