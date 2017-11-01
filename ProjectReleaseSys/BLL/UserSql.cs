using ADL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 用户表sql操作
    /// </summary>
   public class UserSql
    {
        DBHeple db = new DBHeple();

        /// <summary>
        /// 根据条件获取用户数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<User> getWhereList(string where)
        {
            return db.getUserinfoList(string.Format("select * from sys_userinfo " + where));
        }
    }
}
