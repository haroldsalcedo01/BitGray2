using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using Microsoft.Practices.Unity;
using VO.DTO;
using VO.Entities;

namespace Web.Controllers
{
    public class UserController : Controller
    {
        public UserController()
        {
            IUnityContainer container = new UnityContainer();
            container.AddExtension(Factory.Builder.Instance);
        }


        [HttpPost]
        public JsonResult Create(User Data)
        {
            return Json(Factory.Users.Create(Data));
        }

   
        [HttpPost]
        public JsonResult CreateClient(User Data)
        {
            return Json(Factory.Users.CreateClient(Data));
        }

        [HttpPut]
        public JsonResult Update(User Data)
        {
            return Json(Factory.Users.Update(Data));
        }

        [HttpPost]
        public JsonResult LogIn(string user, string password)
        {
            UserDTO loged = Factory.Users.LogIn(user, password);
            if (loged != null)
            {
                Session["User"] = loged; 
            }            
            return Json(loged);
        }

    }
}
