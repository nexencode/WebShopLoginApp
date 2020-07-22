using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WebShopLoginApp
{
    public class DataAccess
    {
        public List<User> GetUsers(string lastName)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("WebShopDB")))
            {
                var output =  connection.Query<User>($"select * from [User] where LastName = '{ lastName }'").ToList();
                return output;
            }
        }
    }
}
