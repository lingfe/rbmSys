using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 文件上传工具类
    /// </summary>
    public class UpdateUtile
    {

        /// <summary>
        /// FTP上传文件,简单,缺点只能上传到两张照片，未解决
        /// </summary>
        /// <param name="safeFileName">文件名称+后缀</param>
        /// <param name="fileName">文件url包含文件名称后缀</param>
        /// <returns>返回上传通知</returns>
        public string ftpUpload(string safeFileName, string fileName)
        {
            FileInfo fileInf = new FileInfo(fileName);
            //截取文件后缀
            string hozui = safeFileName.Substring(safeFileName.IndexOf("."));
            //保存uri
            string strpathss = "web.echsoft.cn/admin/" + System.Guid.NewGuid().ToString("N") + hozui;
            //ftp请求uri
            string uri = "ftp://" + FtpServerParam.ftpServerIP + "//app/static/upload/" + strpathss;
            FtpWebRequest reqFTP;

            // 根据uri创建FtpWebRequest对象 
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
            // ftp用户名和密码
            reqFTP.Credentials = new NetworkCredential(FtpServerParam.ftpUserID, FtpServerParam.ftpPassword);

            reqFTP.Timeout = 10000;
            reqFTP.ReadWriteTimeout = 10000;
            // 默认为true，连接不会被关闭
            // 在一个命令之后被执行
            //reqFTP.KeepAlive = false;
            reqFTP.KeepAlive = true;
            // 指定执行什么命令
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;            

            // 指定数据传输类型
            reqFTP.UseBinary = true;
            reqFTP.UsePassive = false;  //上传“操作已超时” 
            //reqFTP.UsePassive = true;
            
            // 上传文件时通知服务器文件的大小
            reqFTP.ContentLength = fileInf.Length;
            // 缓冲大小设置为2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // 打开一个文件流 (System.IO.FileStream) 去读上传的文件
            FileStream fs = fileInf.OpenRead();

            try
            {
                // 把上传的文件写入流
                Stream strm = reqFTP.GetRequestStream();
                // 每次读文件流的2kb
                contentLen = fs.Read(buff, 0, buffLength);

                // 流内容没有结束
                while (contentLen != 0)
                {
                    // 把内容从file stream 写入 upload stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                //返回通知，uri
                return strpathss;
            }
            catch (Exception ex)
            {
                //失败原因
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ftp身份验证
        /// </summary>
        /// <param name="URI"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private static FtpWebRequest GetRequest(string URI, string username, string password)
        {
            //根据服务器信息FtpWebRequest创建类的对象
            FtpWebRequest result = (FtpWebRequest)FtpWebRequest.Create(URI);
            //提供身份验证信息
            result.Credentials = new System.Net.NetworkCredential(username, password);
            //设置请求完成之后是否保持到FTP服务器的控制连接，默认值为true
            result.KeepAlive = false;
            return result;
        }

        /// <summary>
        /// ftp上传文件,上传无限制
        /// </summary>
        /// <param name="fileinfo">需要上传的文件</param>
        /// <param name="targetDir">目标路径</param>
        /// <param name="hostname">ftp地址</param>
        /// <param name="username">ftp用户名</param>
        /// <param name="password">ftp密码</param>
        public string UploadFile(FileInfo fileinfo, string targetDir, string hostname, string username, string password)
        {
            //截取文件后缀
            string hozui = fileinfo.Name.Substring(fileinfo.Name.LastIndexOf("."));
            
            //文件名
            string target = System.Guid.NewGuid().ToString("N");  //使用临时文件名
            
            //保存uri
            string strpathss = "web.echsoft.cn/admin/" + target + hozui;
            string URI = "FTP://" + hostname + "//" + targetDir + "/" + strpathss;
            ///WebClient webcl = new WebClient();
            System.Net.FtpWebRequest ftp = GetRequest(URI, username, password);

            //设置FTP命令 设置所要执行的FTP命令，上传
            ftp.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
            //指定文件传输的数据类型
            ftp.UseBinary = true;
            ftp.UsePassive = true;

            //告诉ftp文件大小
            ftp.ContentLength = fileinfo.Length;
            //缓冲大小设置为2KB
            const int BufferSize = 2048;
            byte[] content = new byte[BufferSize - 1 + 1];
            int dataRead;

            //打开一个文件流 (System.IO.FileStream) 去读上传的文件
            using (FileStream fs = fileinfo.OpenRead())
            {
                try
                {
                    //把上传的文件写入流
                    using (Stream rs = ftp.GetRequestStream())
                    {
                        do
                        {
                            //每次读文件流的2KB
                            dataRead = fs.Read(content, 0, BufferSize);
                            rs.Write(content, 0, dataRead);
                        } while (!(dataRead < BufferSize));
                        rs.Close();
                    }

                    return strpathss;

                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    fs.Close();
                }

            }

            //设置为空，重新获取对象
            //ftp = null;
            ////设置FTP命令
            //ftp = GetRequest(URI, username, password);
            //ftp.Method = System.Net.WebRequestMethods.Ftp.Rename; //改名
            //ftp.RenameTo = fileinfo.Name;
            //try
            //{
            //    ftp.GetResponse();
            //}
            //catch (Exception ex)
            //{
            //    ftp = GetRequest(URI, username, password);
            //    ftp.Method = System.Net.WebRequestMethods.Ftp.DeleteFile; //删除
            //    ftp.GetResponse();
            //    throw ex;
            //}
        }

        /// <summary>
        /// 中转ftp上传，无限制
        /// </summary>
        /// <param name="fileName">文件url包含文件名称后缀</param>
        /// <returns>上传结果</returns>
        public string setUploadFile(string fileName) {
            FileInfo fileInf = new FileInfo(fileName);
            return this.UploadFile(fileInf, "app/static/upload", FtpServerParam.ftpServerIP, FtpServerParam.ftpUserID, FtpServerParam.ftpPassword);
        }
    }
}
