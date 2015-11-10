using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace Telnet.DAL
{
    public class MongoDBHelp
    {
        /// <summary>
        /// Mongodb数据库连接
        /// </summary>
        /// <returns></returns>
        public MongoDatabase GetDB()
        {
            return MongoDatabase.Create(ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString);
        }
        
    }
}
