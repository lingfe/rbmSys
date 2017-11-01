using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   /// <summary>
   /// 评论表实体
   /// </summary>
   public class Commentinfo
    {
        private string id;//         `id` varchar(32) NOT NULL COMMENT '评论信息id标识',
       /// <summary>
        /// 评论信息id
       /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string releaseId;//  `releaseId` varchar(32) NOT NULL COMMENT '发布信息id',
       /// <summary>
        /// 发布信息id
       /// </summary>
        public string ReleaseId
        {
            get { return releaseId; }
            set { releaseId = value; }
        }
        private string personalId;//  `personalId` varchar(32) NOT NULL COMMENT '个人资料Id',
       /// <summary>
        /// 个人资料id
       /// </summary>
        public string PersonalId
        {
            get { return personalId; }
            set { personalId = value; }
        }
        private string commentContent;//  `commentContent` varchar(255) DEFAULT NULL COMMENT '评论内容',
       /// <summary>
        /// 评论内容
       /// </summary>
        public string CommentContent
        {
            get { return commentContent; }
            set { commentContent = value; }
        }
        private string avatarUrl;//  `avatarUrl` varchar(255) DEFAULT NULL COMMENT '头像用户',
       /// <summary>
        /// 头像用户
       /// </summary>
        public string AvatarUrl
        {
            get { return avatarUrl; }
            set { avatarUrl = value; }
        }
        private string remark;//  `remark` varchar(255) DEFAULT NULL COMMENT '评论备注',
       /// <summary>
        /// 评论备注
       /// </summary>
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        private DateTime cdate;//  `cdate` datetime DEFAULT NULL COMMENT '创建时间',
       /// <summary>
        /// 创建时间
       /// </summary>
        public DateTime Cdate
        {
            get { return cdate; }
            set { cdate = value; }
        }
        private DateTime mdate;//  `mdate` datetime DEFAULT NULL COMMENT '最后修改时间',
       /// <summary>
        /// 最后修改时间
       /// </summary>
        public DateTime Mdate
        {
            get { return mdate; }
            set { mdate = value; }
        }
        private string creator;//  `creator` varchar(32) DEFAULT NULL COMMENT '创建人',
       /// <summary>
        /// 创建人
       /// </summary>
        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        private string uman;//`uman` varchar(32) DEFAULT NULL COMMENT '修改人',
       /// <summary>
        /// 修改人
       /// </summary>
        public string Uman
        {
            get { return uman; }
            set { uman = value; }
        }
        private int df;//  `df` int(11) DEFAULT '0' COMMENT '是否删除',
       /// <summary>
        /// 是否删除
       /// </summary>
        public int Df
        {
            get { return df; }
            set { df = value; }
        }
        private int version;//  `version` int(11) DEFAULT '0' COMMENT '数据版本',
       /// <summary>
        /// 数据版本
       /// </summary>
        public int Version
        {
            get { return version; }
            set { version = value; }
        }

    }
}
