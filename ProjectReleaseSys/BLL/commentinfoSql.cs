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
    /// 评论表sql操作
    /// </summary>
    public class commentinfoSql
    {
        DBHeple db = new DBHeple();

        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Commentinfo> getWhereList(string where)
        {
            return db.getcommentinfoList(string.Format("select * from commentinfo " + where));
        }

        /// <summary>
        /// 添加一条评论或者回复
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int setCommentInfo(Commentinfo info)
        {
            string sql = string.Format("INSERT  INTO `commentinfo`"
                +"(`id`,`releaseId`,`personalId`,`commentContent`,`avatarUrl`,`remark`,`cdate`,`mdate`,`creator`,`uman`,`df`,`version`)"
                +" VALUES "
                +"('{0}','{1}','{2}',"
                +" '{3}','{4}',"
                +"'{5}','{6}','{7}','{8}','{9}',{10},{11}) "
                ,info.Id,info.ReleaseId,info.PersonalId
                ,info.CommentContent,info.AvatarUrl
                ,info.Remark,info.Cdate,info.Mdate,info.Creator,info.Uman,info.Df,info.Version);

            return db.GetExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据id删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int delete(string id) {
            string sql = string.Format("delete FROM commentinfo where id='{0}'", id);
            return db.GetExecuteNonQuery(sql);
        }

    }
}
