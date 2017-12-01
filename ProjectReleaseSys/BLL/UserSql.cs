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


        /// <summary>
        /// 添加一个虚拟用户
        /// </summary>
        /// <param name="rep"></param>
        /// <returns></returns>
        public int setInsert(User u)
        {
            string sql = string.Format("INSERT  INTO `sys_userinfo`(`id`,`appId`,`username`,`realname`,"
                +"`parentId`,`avatarUrl`,"
                +"`ename`,`pwd`,`tel`,`fax`,`email`,`mobile`,`qq`,`userType`,`balance`,"
                +"`status`,`bankAccount`,`idCard`,`provinceCode`,`provinceName`,`cityCode`,`cityName`,`regionCode`,`regionName`,`address`,`memo`,"
                +"`df`,`creator`,`uman`,`cdate`,`mdate`,`version`) "
                +"VALUES ('{0}','3DF7469FD3A1485B95ED16ED794780A8','{1}','{2}',"
                +"NULL,'{3}',"
                +"NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,0,"
                +"NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'{4}',NULL,"
                +"0,'root','root','{5}','{6}',0)"
                ,u.Id,u.Mobile,u.Realname
                ,u.AvatarUrl,u.Address
                ,u.Cdate,u.Mdate);

            return db.GetExecuteNonQueryUser(sql);
        }
    }
}
