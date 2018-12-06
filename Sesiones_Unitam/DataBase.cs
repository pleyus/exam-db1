using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesiones_Unitam
{
    public static class DataBase
    {
        public static DataRowCollection Select(string sqlquery)
        {
            DataRowCollection Result = null;
            return Result;
        }
        public static bool Insert(string query)
        {
            return true;
        }
        public static bool Update(string query)
        {
            return true;
        }
    }
}
