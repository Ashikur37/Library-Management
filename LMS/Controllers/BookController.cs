using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LEntity;
using LService;

namespace LMS.Controllers
{
    public class BookController : BaseController
    {
        IBookService service = ServiceFactory.GetBookService();
        ICategoryService cservice = ServiceFactory.GetCategoryService();
        IDeskService dservice = ServiceFactory.GetDeskService();
        // GET: Department
        public ActionResult Index()
        {
            if (Convert.ToInt32(Session["type"]) == 1)
            {
                ViewBag.cat_list = cservice.GetAll();
                ViewBag.dlist = dservice.GetAll();
                return View(service.GetAll());
            
            }
            else
            {

                return RedirectToAction("Index", "User");
            }
            
        }
        public ActionResult Edit_Book()
        {
            if (Convert.ToInt32(Session["type"]) == 1)
            {
                ViewBag.cat_list = cservice.GetAll();
                ViewBag.dlist = dservice.GetAll();
                return View(service.GetAll());
            }
            else
                return RedirectToAction("Index", "User");
        }
        public ActionResult Stat()
        {
            ViewBag.tlcopy = service.TotalCopies();
            return View();
        }
        [HttpGet]
        public ActionResult Add_Book()
        {
            ViewBag.Category = new SelectList(cservice.GetAll(), "ID", "Name");
            ViewBag.Desk = new SelectList(dservice.GetAll(), "ID", "Name");
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Add_Book(Book book)
        {
            if (ModelState.IsValid)
            {
                service.Insert(book);


                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Category = new SelectList(cservice.GetAll(), "ID", "Name");
            ViewBag.Desk = new SelectList(dservice.GetAll(), "ID", "Name");
            return View(service.Get(id));
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {   
            return View(service.Get(id));
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }
        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
               service.Update(book);

                
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }
    }
}
