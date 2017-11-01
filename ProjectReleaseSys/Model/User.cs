using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户实体类
    /// </summary>
   public class User
    {
        private string id;//       `id` VARCHAR(32) NOT NULL,
        /// <summary>
        /// 用户id标识
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string realname;//       `realname` VARCHAR(32) NOT NULL COMMENT '真实姓名',
       /// <summary>
        /// 真实姓名
       /// </summary>
        public string Realname
        {
            get { return realname; }
            set { realname = value; }
        }
        private string avatarUrl;//       `avatarUrl` varchar(255) DEFAULT NULL COMMENT '头像用户',
       /// <summary>
        /// 头像
       /// </summary>
        public string AvatarUrl
        {
            get { return avatarUrl; }
            set { avatarUrl = value; }
        }
        private string mobile;//       `mobile` VARCHAR(32) DEFAULT NULL COMMENT '移动电话号码',
       /// <summary>
        /// 移动电话号码
       /// </summary>
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string memo;
       /// <summary>
       /// 备注
       /// </summary>
        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }

        private string address;
       /// <summary>
       /// 详细地址，0=虚拟用户
       /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


    }
}
