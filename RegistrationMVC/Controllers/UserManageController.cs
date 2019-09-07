using RegistrationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationMVC.Controllers
{
    public class UserManageController : Controller
    {
        // GET: UserManage
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserManage/Create
        [HttpPost]
        public ActionResult Create(UserModel collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserManage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UserModel collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserManage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, UserModel collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}