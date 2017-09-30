using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectReleaseSys
{
    /// <summary>
    /// 委托事件类
    /// </summary>
   public class myTest
    {
        public string filename;
        public delegate void myUpEventsHandler(string _filename);
        public event myUpEventsHandler startUpEvent;

        public myTest()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_filename">上传的文件名</param>
        public myTest(string _filename)
        {
            this.filename = _filename;
        }

        /// <summary>
        /// 开始一个线程，执行事件
        /// </summary>
        public void mythreadStart()
        {
            Thread thr = new Thread(new ThreadStart(this.mystart));
            thr.Start();
        }

        /// <summary>
        /// 开始事件
        /// </summary>
        public void mystart()
        {
            startUpEvent(this.filename);
        }
    }
}
