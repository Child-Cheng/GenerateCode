using Commons.Collections;
using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using NVelocity.Runtime;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ArchitectureGeneration.Help
{
    /// <summary>
    /// NVelocity模板工具类 VelocityHelper
    /// </summary>
    public class VelocityHelper
    {
        private VelocityEngine velocity = null;
        private IContext context = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="templatDir">模板文件夹路径</param>
        public VelocityHelper(string templatDir)
        {
            Init(templatDir);
        }

        /// <summary>
        /// 无参数构造函数
        /// </summary>
        public VelocityHelper() { }

        /// <summary>
        /// 初始话NVelocity模块
        /// </summary>
        public void Init(string templatDir)
        {
            //创建VelocityEngine实例对象
            velocity = new VelocityEngine();

            //使用设置初始化VelocityEngine
            ExtendedProperties props = new ExtendedProperties();
            props.AddProperty(RuntimeConstants.RESOURCE_LOADER, "file");
            props.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, templatDir);
            props.AddProperty(RuntimeConstants.INPUT_ENCODING, "utf-8");
            props.AddProperty(RuntimeConstants.OUTPUT_ENCODING, "utf-8");

            //模板的缓存设置
            props.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_CACHE, true);              //是否缓存
            props.AddProperty("file.resource.loader.modificationCheckInterval", (Int64)30);    //缓存时间(秒)

            velocity.Init(props);

            //为模板变量赋值
            context = new VelocityContext();
        }

        /// <summary>
        /// 给模板变量赋值
        /// </summary>
        /// <param name="key">模板变量</param>
        /// <param name="value">模板变量值</param>
        public void Add(string key, object value)
        {
            if (context == null)
                context = new VelocityContext();
            context.Put(key, value);
        }

        /// <summary>
        /// 显示模板
        /// </summary>
        /// <param name="templatFileName">模板文件名</param>
        public string Display(string templatFileName)
        {
            //从文件中读取模板
            Template template = velocity.GetTemplate(templatFileName);
            //合并模板
            using (StringWriter writer = new StringWriter())
            {
                template.Merge(context, writer);
                var str = writer.ToString();
                writer.Flush();
                writer.Close();
                //输出
                return str;
            }
        }

        /// <summary>
        /// 根据模板生成文件
        /// </summary>
        /// <param name="templatFileName"></param>
        /// <param name="path">保存路径</param>
        public void CreateFile(string templatFileName, string path, string fileName)
        {
            //从文件中读取模板
            Template template = velocity.GetTemplate(templatFileName);
            //合并模板
            StringWriter writer = new StringWriter();
            template.Merge(context, writer);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllText(path + "\\" + fileName, writer.ToString(), new System.Text.UTF8Encoding(false));

            writer.Write(writer);
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// 根据模板生成文件
        /// </summary>
        /// <param name="templatFileName"></param>
        /// <param name="path">保存路径</param>
        public void CreateFile(string templatFileName, string path)
        {
            //从文件中读取模板
            Template template = velocity.GetTemplate(templatFileName);
            //合并模板
            StringWriter writer = new StringWriter();
            template.Merge(context, writer);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName = GetClassName(writer.ToString());
            if (!string.IsNullOrEmpty(fileName))
            {
                File.WriteAllText(path + "\\" + fileName, writer.ToString(), new System.Text.UTF8Encoding(false));
                writer.Write(writer);
                writer.Flush();
            }
            writer.Close();
        }

        /// <summary>
        /// 获取类名
        /// </summary>
        /// <param name="code"></param>
        private string GetClassName(string code)
        {
            MatchCollection mc = Regex.Matches(code, @"class\s*(?<class>\w+)");
            foreach (Match m in mc)
            {
                foreach (Capture c in m.Groups["class"].Captures)
                {
                    return c.Value + ".cs";
                }
            }
            return null;
        }
    }
}