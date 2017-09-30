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
        /// FTP上传文件
        /// </summary>
        /// <param name="safeFileName">文件名称+后缀</param>
        /// <param name="fileName">文件url包含文件名称后缀</param>
        /// <returns>返回上传通知</returns>
        public string ftpUpload(string safeFileName, string fileName)
        {
            FileInfo fileInf = new FileInfo(fileName);
            string uri = "ftp://" + FtpServerParam.ftpServerIP + "/" + safeFileName;
            FtpWebRequest reqFTP;

            // 根据uri创建FtpWebRequest对象 
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
            // ftp用户名和密码
            reqFTP.Credentials = new NetworkCredential(FtpServerParam.ftpUserID, FtpServerParam.ftpPassword);

            // 默认为true，连接不会被关闭
            // 在一个命令之后被执行
            reqFTP.KeepAlive = false;
            // 指定执行什么命令
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            // 指定数据传输类型
            reqFTP.UseBinary = true;
            reqFTP.UsePassive = false;
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

                // 关闭两个流
                strm.Close();
                fs.Close();

                //返回通知
                return safeFileName;
            }
            catch (Exception ex)
            {
                //失败原因
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
