using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using Model;

namespace ADL
{
    /// <summary>
    /// SQL帮助类
    /// </summary>
    public class DBHeple
    {

        public DBHeple() {
            con.Open();
        
        #region  建立Sql server 数据库连接
        }
        //SqlConnection con = new SqlConnection("server=.;database=dome1;uid=root;pwd=root;");
        //SqlCommand cmd;
        //SqlDataReader dr;
        #endregion

        #region  建立MySql数据库连接
        /// <summary>
        /// 服务器1：ip=119.23.59.68; port=330;
        /// 服务器2：ip=39.108.118.48;port=3306;
        /// 本地  : ip=192.168.1.104;port=3306;
        /// </summary>
        // MySqlConnection con = new MySqlConnection("server=39.108.118.48;port=3306;user id=dahuo;CharSet=utf8;password=dahuo;database=ally"); //根据自己的设置http://sosoft.cnblogs.com/
        MySqlConnection con = new MySqlConnection("server=39.108.118.48;port=3306;user id=dahuo;CharSet=utf8;password=dahuo;database=dahuodb"); //根据自己的设置http://sosoft.cnblogs.com/
        
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        #endregion

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void close() {
            con.Close();
        }


        /// <summary>
        /// 得到DataSet类型的数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet getDataSet(string sql) {

            da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        /// <summary>
        /// 返回影响的行数的方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>影响的行数</returns>
        public int GetExecuteNonQuery(string sql)
        {
            int tt = -1;
            try
            {
                
                cmd = new MySqlCommand(sql, con);
                tt = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                Console.WriteLine(ex.Message);
            }
            finally
            {
               // con.Close();
            }
            return tt;
        }

        /// <summary>
        /// 得到dataTable数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable getEmployeeLevelDataTable(string sql)
        {

            DataTable ds = null;
            try
            {
                da = new MySqlDataAdapter(sql, con);
                ds = new DataTable();
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                Console.WriteLine(ex.Message);

            }
            finally
            {
                //con.Close();
            }
            return ds;
        }

        /// <summary>
        /// 定义查询所有发布信息的方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>List集合，包含employeeLevel数据</returns>
        public List<ReleaseInfo> getEmployeeLevel(string sql)
        {
            List<ReleaseInfo> st = new List<ReleaseInfo>();

            try
            {
                //con.Open();
                cmd = new MySqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ReleaseInfo fo = new ReleaseInfo();
                    fo.Id = dr["id"].ToString();
                    fo.Title = dr["title"].ToString();
                    fo.Threshold = Convert.ToDouble(dr["threshold"].ToString());
                    fo.ThrowInTheCity = dr["throwInTheCity"].ToString();
                    fo.TeamIntroduction = dr["teamIntroduction"].ToString();
                    fo.ShareDivision = dr["shareDivision"].ToString();
                    fo.ResourceRequirements = dr["resourceRequirements"].ToString();
                    fo.ReleaseType = dr["releaseType"].ToString();
                    fo.PublisherIdentity = dr["publisherIdentity"].ToString();
                    fo.ProjectDescription = dr["projectDescription"].ToString();
                    fo.ProjectAdvantage = dr["projectAdvantage"].ToString();
                    fo.ProductType = dr["productType"].ToString();
                    fo.ProductHighlights = dr["productHighlights"].ToString();
                    fo.ProductCategory = dr["productCategory"].ToString();
                    fo.Phone = dr["phone"].ToString();
                    fo.PersonalId = dr["personalId"].ToString();
                    fo.AgencyRule = dr["agencyRule"].ToString();

                    fo.AgentCondition = dr["AgentCondition"].ToString();
                    fo.BusinessDescription = dr["BusinessDescription"].ToString();
                    fo.Cdate = Convert.ToDateTime(dr["cdate"].ToString());
                    fo.Creator = dr["creator"].ToString();
                    fo.CurrentCity = dr["currentCity"].ToString();
                    fo.Df = Convert.ToInt32(dr["df"].ToString());

                    fo.FundDistribution = dr["FundDistribution"].ToString();
                    fo.GeographicalPosition = dr["GeographicalPosition"].ToString();
                    fo.HeadquartersLocation = dr["GeographicalPosition"].ToString();
                    fo.HouseType = dr["HouseType"].ToString();
                    fo.IncomeDescription = dr["IncomeDescription"].ToString();
                    fo.IndustryChoice = dr["IndustryChoice"].ToString();
                    fo.Mdate = Convert.ToDateTime(dr["mdate"].ToString());
                    fo.MonthlyRent = dr["MonthlyRent"].ToString();
                    fo.OperatingArea = dr["MonthlyRent"].ToString();
                    fo.TransferReason = dr["TransferReason"].ToString();

                    st.Add(fo);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                Console.WriteLine(ex.Message);

            }
            finally
            {
                //con.Close();
            }

            return st;
        }        
    }
}
