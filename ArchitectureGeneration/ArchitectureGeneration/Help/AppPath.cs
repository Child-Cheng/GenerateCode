using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureGeneration.Help
{
    public class AppPath
    {
        /// <summary>
        /// 获取程序的基目录。
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            return System.AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// 获取应用程序的当前工作目录，注意工作目录是可以改变的，而不限定在程序所在目录。
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDirectory()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }
    }
}