#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sridhar_Bingham_L5.Models;

#endregion

namespace Sridhar_Bingham_L5.Controllers
{
    public class GroupController : Controller
    {
        //
        // GET: /Group/

        public ActionResult Index()
        {
            return View();
        }

        #region -- GetMembers() Method --
        public JsonResult GetMembers()
        {
            JsonResult result = new JsonResult();
            GroupMembers members = GroupMembers.ReturnGroupMembers();

            result = Json(members, JsonRequestBehavior.AllowGet);
            return result;
        }
        #endregion

    }
}
