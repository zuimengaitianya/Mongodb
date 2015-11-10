using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using Telnet.DAL;
using Telnet.Common;

namespace Telnet.Bll
{
    public class UserBLL
    {
        /// <summary>
        /// 返回mongodb连接
        /// </summary>
        /// <returns></returns>
        public MongoDatabase GetDB()
        {
            MongoDBHelp mongoDBHelp = new MongoDBHelp();
            return mongoDBHelp.GetDB();
        }
    }
}
