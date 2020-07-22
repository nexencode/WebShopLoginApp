using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopLoginApp
{
    public static class Helper
    {
        /// <summary>
        /// Return Value of Connection string.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


        //genericka klasa za mapiranje
    }
}
