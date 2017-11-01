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
    /// 通知表sql操作
    /// </summary>
   public class NoticeSql
    {
       DBHeple db = new DBHeple();


       /// <summary>
       /// 添加一条通知
       /// </summary>
       /// <param name="info"></param>
       /// <returns></returns>
       public int setInsert(Notice info) {
           string sql = string.Format("INSERT  INTO `notice`"
               +"(`id`,`personalId`,`releaseId`,`imgUrl`,`ntype`,`content`,`static`,`notifyname`,`tile`,`memo`,`cdate`,`mdate`,`creator`,`uman`,`df`,`version`,`avatarUrl`,`infoType`) "
               +"VALUES ('{0}','{1}','{2}',"
               +"'{3}','{4}','{5}',{6},"
               +"'{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14},{15},"
               +"'{16}','{17}')"
               ,info.Id,info.PersonalId,info.ReleaseId
               ,info.ImgUrl,info.Ntype,info.Content,info.StaticStr
               ,info.Notifyname,info.Tile,info.Memo,info.Cdate,info.Mdate,info.Creator,info.Uman,info.Df,info.Version
               ,info.AvatarUrl,info.InfoType);

           return db.GetExecuteNonQuery(sql);
       }


    }
}
