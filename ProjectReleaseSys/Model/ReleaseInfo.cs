using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReleaseInfo
    {
        private string id;//   `id` VARCHAR(32) NOT NULL COMMENT '发布信息Id标识',

        /// <summary>
        /// 发布信息id标识
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string releaseType;// VARCHAR(64) DEFAULT NULL COMMENT '发布类型',
        /// <summary>
        /// 发布类型
        /// </summary>
        public string ReleaseType
        {
            get { return releaseType; }
            set { releaseType = value; }
        }
        private string personalId;// VARCHAR(64) DEFAULT NULL COMMENT '个人资料id',
        /// <summary>
        /// 个人资料id标识
        /// </summary>
        public string PersonalId
        {
            get { return personalId; }
            set { personalId = value; }
        }
        private string title;// VARCHAR(128) DEFAULT NULL COMMENT '标题',
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string threshold;// DOUBLE DEFAULT NULL COMMENT '入伙门槛，转让门槛,加盟金额,购入门槛，投资金额，代理金额,需要金额',
        /// <summary>
        /// 入伙门槛，转让门槛,加盟金额,购入门槛，投资金额，代理金额,需要金额,出售金额
        /// </summary>
        public string Threshold
        {
            get { return threshold; }
            set { threshold = value; }
        }
        private string industryChoice;// VARCHAR(255) DEFAULT NULL COMMENT '行业选择',
        /// <summary>
        /// 行业
        /// </summary>
        public string IndustryChoice
        {
            get { return industryChoice; }
            set { industryChoice = value; }
        }
        private string fundDistribution;// VARCHAR(255) DEFAULT NULL COMMENT '资金规划',
        /// <summary>
        /// 资金规划
        /// </summary>
        public string FundDistribution
        {
            get { return fundDistribution; }
            set { fundDistribution = value; }
        }
        private string projectDescription;// VARCHAR(1024) DEFAULT NULL COMMENT '项目描述',
        /// <summary>
        /// 项目描述
        /// </summary>
        public string ProjectDescription
        {
            get { return projectDescription; }
            set { projectDescription = value; }
        }
        private string incomeDescription;// VARCHAR(1024) DEFAULT NULL COMMENT '收益描述',
        /// <summary>
        /// 收益描述
        /// </summary>
        public string IncomeDescription
        {
            get { return incomeDescription; }
            set { incomeDescription = value; }
        }
        private string teamIntroduction;// VARCHAR(255) DEFAULT NULL COMMENT '公司/团队介绍',
        /// <summary>
        /// 团队介绍
        /// </summary>
        public string TeamIntroduction
        {
            get { return teamIntroduction; }
            set { teamIntroduction = value; }
        }
        private string phone;// VARCHAR(11) DEFAULT NULL COMMENT '联系方式',
        /// <summary>
        /// 联系方式
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string imageArray;// VARCHAR(1024) DEFAULT NULL COMMENT '图片数组',
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImageArray
        {
            get { return imageArray; }
            set { imageArray = value; }
        }
        private string publisherIdentity;// VARCHAR(255) DEFAULT NULL COMMENT '发布人身份',
        /// <summary>
        /// 发布人身份
        /// </summary>
        public string PublisherIdentity
        {
            get { return publisherIdentity; }
            set { publisherIdentity = value; }
        }
        private string geographicalPosition;// VARCHAR(255) DEFAULT NULL COMMENT '地理位置',
        /// <summary>
        /// 地理位置
        /// </summary>
        public string GeographicalPosition
        {
            get { return geographicalPosition; }
            set { geographicalPosition = value; }
        }
        private string operatingArea;// VARCHAR(255) DEFAULT NULL COMMENT '经营面积',
        /// <summary>
        /// 经营面积
        /// </summary>
        public string OperatingArea
        {
            get { return operatingArea; }
            set { operatingArea = value; }
        }
        private string monthlyRent;// VARCHAR(255) DEFAULT NULL COMMENT '每月租金',
        /// <summary>
        /// 每月租金
        /// </summary>
        public string MonthlyRent
        {
            get { return monthlyRent; }
            set { monthlyRent = value; }
        }
        private string businessDescription;// VARCHAR(255) DEFAULT NULL COMMENT '经营描述',
        /// <summary>
        /// 营业描述
        /// </summary>
        public string BusinessDescription
        {
            get { return businessDescription; }
            set { businessDescription = value; }
        }
        private string transferReason;// VARCHAR(255) DEFAULT NULL COMMENT '转让原因',
        /// <summary>
        /// 转让原因
        /// </summary>
        public string TransferReason
        {
            get { return transferReason; }
            set { transferReason = value; }
        }
        private string throwInTheCity;// VARCHAR(255) DEFAULT NULL COMMENT '投放城市',
        /// <summary>
        /// 投放城市
        /// </summary>
        public string ThrowInTheCity
        {
            get { return throwInTheCity; }
            set { throwInTheCity = value; }
        }
        private string headquartersLocation;// VARCHAR(255) DEFAULT NULL COMMENT '总部位置',
        /// <summary>
        /// 总部位置
        /// </summary>
        public string HeadquartersLocation
        {
            get { return headquartersLocation; }
            set { headquartersLocation = value; }
        }
        private string resourceRequirements;// VARCHAR(255) DEFAULT NULL COMMENT '技能/资源要求',
        /// <summary>
        /// 资源要求
        /// </summary>
        public string ResourceRequirements
        {
            get { return resourceRequirements; }
            set { resourceRequirements = value; }
        }
        private string shareDivision;// VARCHAR(255) DEFAULT NULL COMMENT '股份划分',
        /// <summary>
        /// 出售股份，股份划分
        /// </summary>
        public string ShareDivision
        {
            get { return shareDivision; }
            set { shareDivision = value; }
        }
        private string productType;// VARCHAR(255) DEFAULT NULL COMMENT '产品种类',
        /// <summary>
        /// 产品种类
        /// </summary>
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        private string houseType;// VARCHAR(255) DEFAULT NULL COMMENT '房产类型',
        /// <summary>
        /// 房产类型
        /// </summary>
        public string HouseType
        {
            get { return houseType; }
            set { houseType = value; }
        }
        private string projectAdvantage;// VARCHAR(255) DEFAULT NULL COMMENT '项目优势',
        /// <summary>
        /// 项目优势
        /// </summary>
        public string ProjectAdvantage
        {
            get { return projectAdvantage; }
            set { projectAdvantage = value; }
        }
        private string productCategory;// VARCHAR(255) DEFAULT NULL COMMENT '产品类目',
        /// <summary>
        /// 产品类目
        /// </summary>
        public string ProductCategory
        {
            get { return productCategory; }
            set { productCategory = value; }
        }
        private string productHighlights;// VARCHAR(255) DEFAULT NULL COMMENT '产品亮点',
        /// <summary>
        /// 产品亮点
        /// </summary>
        public string ProductHighlights
        {
            get { return productHighlights; }
            set { productHighlights = value; }
        }
        private string currentCity;// VARCHAR(255) DEFAULT NULL COMMENT '当前城市',
        /// <summary>
        /// 当前城市
        /// </summary>
        public string CurrentCity
        {
            get { return currentCity; }
            set { currentCity = value; }
        }
        private string agentCondition;// VARCHAR(255) DEFAULT NULL COMMENT '代理条件',
        /// <summary>
        /// 代理条件
        /// </summary>
        public string AgentCondition
        {
            get { return agentCondition; }
            set { agentCondition = value; }
        }
        private string agencyRule;// VARCHAR(255) DEFAULT NULL COMMENT '代理规则',
        /// <summary>
        /// 代理规则
        /// </summary>
        public string AgencyRule
        {
            get { return agencyRule; }
            set { agencyRule = value; }
        }
        private int top;// INT(1) DEFAULT '0' COMMENT '置顶',
        /// <summary>
        /// 置顶
        /// </summary>
        public int Top
        {
            get { return top; }
            set { top = value; }
        }
        private DateTime cdate;// DATETIME DEFAULT NULL COMMENT '创建时间',
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Cdate
        {
            get { return cdate; }
            set { cdate = value; }
        }
        private DateTime mdate;// DATETIME DEFAULT NULL COMMENT '最后修改时间',
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime Mdate
        {
            get { return mdate; }
            set { mdate = value; }
        }
        private string creator;// VARCHAR(32) DEFAULT NULL COMMENT '创建人',
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        private string uman;// VARCHAR(32) DEFAULT NULL COMMENT '修改人',
        /// <summary>
        /// 修改人
        /// </summary>
        public string Uman
        {
            get { return uman; }
            set { uman = value; }
        }
        private int df;// INT(11) DEFAULT '0' COMMENT '是否删除',
        /// <summary>
        /// 是否删除,0=正常显示，1=已下架,2=未发布，4=审核中,5=未通过
        /// </summary>
        public int Df
        {
            get { return df; }
            set { df = value; }
        }
        private int version;// `version` INT(11) DEFAULT '0' COMMENT '数据版本',

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
