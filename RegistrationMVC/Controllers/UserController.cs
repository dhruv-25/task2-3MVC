using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationMVC.Models;

namespace RegistrationMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        // GET: User
        public ActionResult List()
        {
            List<UserModel> userlist = new List<UserModel>();

            var user = new UserModel(1, "Sumit", "ss@s.com", "asdf", "123456789", "1.jpg", "male", 1);
            userlist.Add(user);

            user = new UserModel(1, "smit", "ss@s.com", "asdf", "123456789", "2.png", "male", 1);
            userlist.Add(user);



            return View(userlist);
        }
        [HttpGet]
        public ActionResult SignUpAuto()
        {
            UserModel userModel = new UserModel();
            userModel.StateId = new StateModel();
            SelectList countryList = new SelectList(userModel.StateId.GetCountries, "CountryId", "CountryName");

            SelectList stateList = new SelectList(userModel.GetStates, "StateId", "StateName");

            ViewBag.countrydatasource = countryList;
            ViewBag.statedatasource = stateList;
            return View();
        }
        [HttpPost]
        public ActionResult SignUpAuto(UserModel userModel)
        {
            return View();
        }
    }
}