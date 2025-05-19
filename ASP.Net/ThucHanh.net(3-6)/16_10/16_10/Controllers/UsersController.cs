using _16_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_10.Controllers
{
    public class UsersController : Controller
    {
        public static List<Users> usersList = new List<Users> {
    new Users {
        Id = 1, Name = "Nguyen Van A", Address = "Hà Nội",
        Email = "a@example.com", Password = "password123", Gender = true,Date=DateTime.Parse("03/12/2003"),ReEnterPassword = "password123"
    },
    new Users {
        Id = 2, Name = "Tran Thi B", Address = "Hà Nội",
        Email = "b@example.com", Password = "pass456", Gender = false,Date=DateTime.Parse("12/02/2003"),ReEnterPassword = "pass456"
    },
    new Users {
        Id = 3, Name = "Le Van C", Address = "Hưng Yên",
        Email = "c@example.com", Password = "123456", Gender = true,Date=DateTime.Parse("05/10/2003"),ReEnterPassword = "123456"
    },
    new Users {
        Id = 4, Name = "Pham Thi D", Address = "Thái Bình",
        Email = "d@example.com", Password = "pass789", Gender = false,Date=DateTime.Parse("10/10/2003"),ReEnterPassword = "pass789"
    }
};
        // GET: Users
        public ActionResult Index()
        {
            return View(usersList);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            // lây user đầu tiên
            var user=usersList.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            List<SelectListItem> lstAddress = new List<SelectListItem>
            {
                new SelectListItem{Text="Hà Nội", Value="Hà Nội"},
                new SelectListItem{Text="Hưng Yên", Value="Hưng Yên"},
                new SelectListItem{Text="Thái Bình", Value="Thái Bình"},
                new SelectListItem{Text="Nam Định", Value="Nam Định"}

            };
            ViewBag.lstAdd = new SelectList(lstAddress, "Value", "Text");
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(Users u)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    u.Id = usersList.Max(us => us.Id) + 1;
                    usersList.Add(u);
                    return RedirectToAction("Index");
                }

                return View(u);
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            var user = usersList.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            List<SelectListItem> lstAddress = new List<SelectListItem>
            {
                new SelectListItem{Text="Hà Nội", Value="Hà Nội"},
                new SelectListItem{Text="Hưng Yên", Value="Hưng Yên"},
                new SelectListItem{Text="Thái Bình", Value="Thái Bình"},
                new SelectListItem{Text="Nam Định", Value="Nam Định"}

            };
            ViewBag.lstAdd = new SelectList(lstAddress, "Value", "Text");
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Users update)
        {
            try
            {
               var user = usersList.FirstOrDefault(u => u.Id == id);
                if(user==null) return HttpNotFound();
                else if (ModelState.IsValid)
                {
                    user.Name= update.Name;
                    user.Email= update.Email;
                    user.Password= update.Password;
                    user.Gender= update.Gender;
                    user.Address= update.Address;
                    user.Age = DateTime.Now.Year - update.Date.Year;
                    user.ReEnterPassword= update.ReEnterPassword;
                    user.Date= update.Date;
                    return RedirectToAction("Index");
                }

                return View(update);
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            var user = usersList.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var user = usersList.FirstOrDefault(x => x.Id == id);
                if (user != null)
                {
                    usersList.Remove(user);
                    return RedirectToAction("Index");

                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
