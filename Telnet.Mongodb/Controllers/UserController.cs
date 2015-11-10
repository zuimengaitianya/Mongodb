using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Telnet.Common;
using Telnet.Bll;
using System.Text;

namespace Telnet.Mongodb.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            try
            {
                UserBLL userBll = new UserBLL();
                var db = userBll.GetDB();

                var testTable = db["user"].FindAll();
                var result = new StringBuilder();
                foreach (var testData in testTable)
                {
                    foreach (var property in testData.Names)
                    {
                        result.AppendFormat("{0}:{1} ", property, testData[property]);
                    }

                    result.Append("<br />");
                }

                return Content(result.ToString());
            }
            catch
            {
                return View();
            }
        }
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                UserBLL userBll = new UserBLL();
                var db = userBll.GetDB();
                foreach (var key in collection.AllKeys)
                {
                    db["user"].Insert(new MongoDB.Bson.BsonDocument{
                       {key, collection[key]}
                    });
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
