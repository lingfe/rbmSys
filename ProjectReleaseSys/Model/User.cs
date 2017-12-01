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

        private int df;//    `df` INT(11) DEFAULT '32' COMMENT '是否删除',

        public int Df
        {
            get { return df; }
            set { df = value; }
        }
        private string creator;//  `creator` VARCHAR(32) DEFAULT NULL COMMENT '创建人',

        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        private string uman;//  `uman` VARCHAR(32) DEFAULT NULL COMMENT '修改人',

        public string Uman
        {
            get { return uman; }
            set { uman = value; }
        }
        private DateTime cdate;//  `cdate` DATETIME DEFAULT NULL COMMENT '创建时间',

        public DateTime Cdate
        {
            get { return cdate; }
            set { cdate = value; }
        }
        private DateTime mdate;//  `mdate` DATETIME DEFAULT NULL COMMENT '最后修改时间',

        public DateTime Mdate
        {
            get { return mdate; }
            set { mdate = value; }
        }
        private int version;//  `version` INT(11) DEFAULT '0' COMMENT '数据版本',

        public int Version
        {
            get { return version; }
            set { version = value; }
        }
    }
}
