
using ADL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class ReleaseInfoSql
    {
        DBHeple db = new DBHeple();

        /// <summary>
        /// 得到所有今天的发布信息
        /// </summary>
        /// <returns></returns>
        public List<ReleaseInfo> getList()
        {

            return db.getEmployeeLevel(string.Format("select * from releaseinfo WHERE DATEDIFF(mdate,NOW())=0 ORDER BY id DESC"));
        }

        /// <summary>
        /// 执行一条sql,删除，修改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int setUpdate(string sql) {
            return db.GetExecuteNonQuery(sql);
        }

        /// <summary>
        /// 关闭链接
        /// </summary>
        public void close() {
            db.close();
        }

        /// <summary>
        /// 修改发布信息的状态
        /// </summary>
        /// <param name="staticstr">状态</param>
        /// <param name="id">编号</param>
        /// <returns></returns>
        public int setWhereDF(int staticstr,string id) {
            return db.GetExecuteNonQuery(string.Format("UPDATE releaseinfo set static={0}  WHERE id='{1}'", staticstr, id));
        }

        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<ReleaseInfo> getWhereList(string where) {
            return db.getEmployeeLevel(string.Format("select * from releaseinfo "+where));
        }

        /// <summary>
        /// 根据id删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int setdelelte(string id) {

            return db.GetExecuteNonQuery(string.Format("delete FROM releaseinfo where id='{0}'",id));
        }

        /// <summary>
        /// 插入发布信息
        /// </summary>
        /// <param name="fo">实体对象</param>
        /// <returns></returns>
        public int setInsert(ReleaseInfo fo) {
            //sql语句
            string sql = string.Format("INSERT  INTO "
                +"`releaseinfo`(`id`,`releaseType`,`personalId`,`title`,`threshold`,"
                +"`industryChoice`,`fundDistribution`,`projectDescription`,`incomeDescription`,`teamIntroduction`,`phone`,`imageArray`,"
                +"`publisherIdentity`,`geographicalPosition`,`operatingArea`,`monthlyRent`,`businessDescription`,`transferReason`,`throwInTheCity`,"
                +"`headquartersLocation`,`resourceRequirements`,`shareDivision`,`productType`,`houseType`,`projectAdvantage`,`productCategory`,`productHighlights`,"
                +"`currentCity`,`agentCondition`,`agencyRule`,"
                + "`top`,static,`cdate`,`mdate`,`creator`,`uman`,`df`,`version`) "
                +"VALUES "
                +"('{0}','{1}','{2}','{3}',{4},"
                +"'{5}','{6}','{7}','{8}','{9}','{10}','{11}',"
                +"'{12}','{13}','{14}','{15}','{16}','{17}','{18}',"
                +"'{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}',"
                +"'{27}','{28}','{29}',"
                +"{30},'{31}','{32}','{33}','{34}','{35}',{36},{37})",
                fo.Id,fo.ReleaseType,fo.PersonalId,fo.Title,fo.Threshold,
                fo.IndustryChoice,fo.FundDistribution,fo.ProjectDescription,fo.IncomeDescription,fo.TeamIntroduction,fo.Phone,fo.ImageArray,
                fo.PublisherIdentity,fo.GeographicalPosition,fo.OperatingArea,fo.MonthlyRent,fo.BusinessDescription,fo.TransferReason,fo.ThrowInTheCity,
                fo.HeadquartersLocation,fo.ResourceRequirements,fo.ShareDivision,fo.ProductType,fo.HouseType,fo.ProjectAdvantage,fo.ProductCategory,fo.ProductHighlights,
                fo.CurrentCity,fo.AgentCondition,fo.AgencyRule,
                fo.Top, fo.Staticstr,fo.Cdate, fo.Mdate, fo.Creator, fo.Uman, fo.Df, fo.Version);

            return db.GetExecuteNonQuery(sql);
        }

        /// <summary>
        /// 得到DataTable 类型的发布信息
        /// </summary>
        /// <returns></returns>
        public DataTable getDataTable()
        {
            return db.getEmployeeLevelDataTable(string.Format("select * from releaseinfo"));
        }

        /// <summary>
        /// 得到DataSet类型的releaseinfo信息
        /// </summary>
        /// <returns></returns>
        public DataSet getreleaseinfoDataSet()
        {
            return db.getDataSet(string.Format("select * from releaseinfo"));
        }

    }
}
