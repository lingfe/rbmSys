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
    /// 回复表sql操作
    /// </summary>
   public class ReplySql
    {
       DBHeple db = new DBHeple();

       /// <summary>
       /// 根据条件获取回复数据
       /// </summary>
       /// <param name="where">条件</param>
       /// <returns></returns>
       public List<Reply> getWhereList(string where)
       {
           return db.getReplyInfoList(string.Format("select * from reply " + where));
       }

       /// <summary>
       /// 根据id删除
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public int delete(string id)
       {
           string sql = string.Format("delete FROM reply where id='{0}'", id);
           return db.GetExecuteNonQuery(sql);
       }

       /// <summary>
       /// 添加一条回复
       /// </summary>
       /// <param name="rep"></param>
       /// <returns></returns>
       public int setInsert(Reply rep) {
           string sql = string.Format("INSERT  INTO `reply`(`id`,`commentinfoId`,`releaseId`,`personalId`,`personalName`,`avatarUrl`,"
               +"`content`,`replypersonalId`,`memo`,`cdate`,`mdate`,`creator`,`uman`,`df`,`version`) "
               +"VALUES ('{0}','{1}','{2}','{3}',"
               +"'{4}','{5}','{6}','{7}','{8}',"
               +"'{9}','{10}','{11}','{12}',{13},{14})"
               ,rep.Id,rep.CommentinfoId,rep.ReleaseId,rep.PersonalId
               ,rep.PersonalName,rep.AvatarUrl,rep.Content,rep.ReplypersonalId,rep.Memo
               ,rep.Cdate,rep.Mdate,rep.Creator,rep.Uman,rep.Df,rep.Version);

           return db.GetExecuteNonQuery(sql);
       }
    }
}
