using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 通知实体类
    /// </summary>
   public class Notice
    {
        private string id;//         `id` VARCHAR(32) NOT NULL COMMENT '通知表id标识',
       /// <summary>
        /// 通知表id标识
       /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string personalId;//  `personalId` VARCHAR(32) NOT NULL COMMENT '接收者，			比如: 零风id..',
       /// <summary>
        /// 接收者，			比如: 零风id..
       /// </summary>
        public string PersonalId
        {
            get { return personalId; }
            set { personalId = value; }
        }
        private string releaseId;//  `releaseId` VARCHAR(32) NOT NULL COMMENT '相关的发布信息id,		比如: 零风发布的信息id..',
       /// <summary>
        /// 相关的发布信息id,		比如: 零风发布的信息id
       /// </summary>
        public string ReleaseId
        {
            get { return releaseId; }
            set { releaseId = value; }
        }
        private string imgUrl;//  `imgUrl` VARCHAR(255) NOT NULL COMMENT '信息图片url			比如: 发布信息对应的图片',
       /// <summary>
        /// 信息图片url			比如: 发布信息对应的图片
       /// </summary>
        public string ImgUrl
        {
            get { return imgUrl; }
            set { imgUrl = value; }
        }
        private string ntype;//  `ntype` VARCHAR(255) NOT NULL COMMENT '通知类型 0=系统通知,1=留言通知,2=私信通知',
       /// <summary>
        /// 通知类型 0=系统通知,1=留言通知,2=私信通知
       /// </summary>
        public string Ntype
        {
            get { return ntype; }
            set { ntype = value; }
        }
        private string content;//  `content` VARCHAR(255) NOT NULL COMMENT '通知内容,			比如: **谁谁给你评论..',
       /// <summary>
        /// 通知内容
       /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private int staticStr;//  `static` INT(11) NOT NULL DEFAULT '0' COMMENT '通知状态			0=未查看，1=已查看,',
       /// <summary>
        /// 通知状态,0=未查看，1=已查看
       /// </summary>
        public int StaticStr
        {
            get { return staticStr; }
            set { staticStr = value; }
        }
        private string notifyname;//  `notifyname` VARCHAR(255) DEFAULT NULL COMMENT '通知者名称				比如:搭伙小秘书，可以为空',
       /// <summary>
        /// 通知者名称
       /// </summary>
        public string Notifyname
        {
            get { return notifyname; }
            set { notifyname = value; }
        }

        private string tile;//  `tile` VARCHAR(255) DEFAULT NULL COMMENT '通知标题,					可以为空',
       /// <summary>
        /// 通知标题
       /// </summary>
        public string Tile
        {
            get { return tile; }
            set { tile = value; }
        }
        private string memo;//  `memo` VARCHAR(255) DEFAULT NULL COMMENT '备注，					可以为空',
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
        private string creator;//  `creator` VARCHAR(32) DEFAULT NULL COMMENT '创建人(通知者:搭伙小秘书,零风id..)',
       /// <summary>
        /// 创建人(通知者:搭伙小秘书,零风id
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
        private string avatarUrl;//  `avatarUrl` VARCHAR(255) DEFAULT NULL COMMENT '头像',
       /// <summary>
        /// 头像
       /// </summary>
        public string AvatarUrl
        {
            get { return avatarUrl; }
            set { avatarUrl = value; }
        }
        private string infoType;//  `infoType` VARCHAR(255) DEFAULT NULL COMMENT '发布信息类型',
       /// <summary>
        /// 发布信息类型
       /// </summary>
        public string InfoType
        {
            get { return infoType; }
            set { infoType = value; }
        }
    }
}
