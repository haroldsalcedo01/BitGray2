using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using VO.DTO;

namespace Web.Controllers
{
    public class ClientController : Controller
    {

        [HttpGet]
        public ActionResult GetClient(int userId) 
        {
            return Json(Factory.Client.Get(userId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetClientLog()
        {
            int userId = ((UserDTO)Session["user"]).Id;
            return Json(Factory.Users.Get(userId), JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult GetConsumes()
        {
            int userId = ((UserDTO)Session["user"]).Id;
            return Json(Factory.Consumes.GetConsumesByUserId(userId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetRecharges()
        {
            int userId = ((UserDTO)Session["user"]).Id;
            return Json(Factory.Recharges.GetRechargesByUserId(userId), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Recharge(decimal value) 
        {
            int userId = ((UserDTO)Session["user"]).Id;
            VO.Entities.Recharges recharge = new VO.Entities.Recharges(){};
            return Json(Factory.Recharges.Recharge(userId, value));
        }


        [HttpPost]
        public ActionResult call(decimal seconds)
        {
            int userId = ((UserDTO)Session["user"]).Id;
            VO.Entities.Consumes recharge = new VO.Entities.Consumes() { };
            return Json(Factory.Consumes.Call(userId, seconds));
        }

    }
}
