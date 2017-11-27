using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 回复表
    /// </summary>
    public  class Reply
    {
        private string id;//  `id` VARCHAR(255) NOT NULL COMMENT '回复表id标识',
        /// <summary>
        /// 回复表id标识
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string commentinfoId;//  `commentinfoId` VARCHAR(255) NOT NULL COMMENT '评论表id',
        /// <summary>
        /// 评论表id
        /// </summary>
        public string CommentinfoId
        {
            get { return commentinfoId; }
            set { commentinfoId = value; }
        }
        private string releaseId;//  `releaseId` VARCHAR(255) NOT NULL COMMENT '发布信息id',
        /// <summary>
        /// 发布信息id
        /// </summary>
        public string ReleaseId
        {
            get { return releaseId; }
            set { releaseId = value; }
        }
        private string personalId;//  `personalId` VARCHAR(255) NOT NULL COMMENT '回复者Id',
        /// <summary>
        /// 回复者Id
        /// </summary>
        public string PersonalId
        {
            get { return personalId; }
            set { personalId = value; }
        }
        private string personalName;//  `personalName` VARCHAR(255) NOT NULL COMMENT '回复者名称',
        /// <summary>
        /// 回复者名称
        /// </summary>
        public string PersonalName
        {
            get { return personalName; }
            set { personalName = value; }
        }
        private string avatarUrl;//  `avatarUrl` VARCHAR(255) NOT NULL COMMENT '回复者头像',
        /// <summary>
        /// 回复者头像
        /// </summary>
        public string AvatarUrl
        {
            get { return avatarUrl; }
            set { avatarUrl = value; }
        }
        private string content;//  `content` VARCHAR(255) NOT NULL COMMENT '回复内容',
        /// <summary>
        /// 回复内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string replypersonalId;//  `replypersonalId` VARCHAR(255) NOT NULL COMMENT '回复谁的id',
        /// <summary>
        /// 回复谁的id
        /// </summary>
        public string ReplypersonalId
        {
            get { return replypersonalId; }
            set { replypersonalId = value; }
        }
        private string memo;//  `memo` VARCHAR(255) DEFAULT NULL COMMENT '备注，可以为空',
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
        private DateTime cdate;//  `cdate` DATETIME DEFAULT NULL COMMENT '创建时间',
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Cdate
        {
            get { return cdate; }
            set { cdate = value; }
        }
        private DateTime mdate;//  `mdate` DATETIME DEFAULT NULL COMMENT '最后修改时间',
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime Mdate
        {
            get { return mdate; }
            set { mdate = value; }
        }
        private string creator;//  `creator` VARCHAR(32) DEFAULT NULL COMMENT '创建人',
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        private string uman;//  `uman` VARCHAR(32) DEFAULT NULL COMMENT '修改人',
        /// <summary>
        /// 修改人
        /// </summary>
        public string Uman
        {
            get { return uman; }
            set { uman = value; }
        }
        private int df;//  `df` INT(11) DEFAULT '0' COMMENT '是否删除',
        /// <summary>
        /// 是否删除
        /// </summary>
        public int Df
        {
            get { return df; }
            set { df = value; }
        }
        private int version;//  `version` INT(11) DEFAULT '0' COMMENT '数据版本',
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
