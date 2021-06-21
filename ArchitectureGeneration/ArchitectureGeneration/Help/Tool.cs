using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace ArchitectureGeneration.Help
{
    public class Tool
    {
        public static string STANDARD_DATE = "yyyy-MM-dd HH:mm:ss";
        public static string STANDARD_DATE_SIMPLE = "yyyy-MM-dd";
        public static string CHN_DATE = "yyyy年MM月dd日 HH时mm分ss秒";
        public static string CHN_DATE_SIMPLE = "yyyy年MM月dd日";

        /// <summary>
        /// 字符串首字母大写
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string StrFirstUpperCase(string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1);
        }

        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string FirstUpperCase(string name)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name);
        }

        public bool IsUnderline(string name)
        {
            return name.IndexOf("_") > -1;
        }

        /// <summary>
        /// 首字母小写
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string FirstLowerCase(string name)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToLower(name);
        }

        /// <summary>
        /// 去除空格
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string StrTrim(string name)
        {
            return name.Trim();
        }

        /// <summary>
        /// 自定义替换
        /// </summary>
        /// <param name="name"></param>
        /// <param name="replaceName"></param>
        /// <param name="replaceValue"></param>
        /// <returns></returns>
        public string Replace(string name, string replaceName, string replaceValue)
        {
            return name.Replace(replaceName, replaceValue);
        }

        /// <summary>
        /// 去除前缀
        /// </summary>
        /// <param name="name"></param>
        /// <param name="replaceName"></param>
        /// <returns></returns>
        public string ReplaceFirst(string name, string replaceName)
        {
            return name.Replace(replaceName, "");
        }

        /// <summary>
        /// 数据库类型转C#类型
        /// </summary>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public string ConvertDataType(string dbType)
        {
            string type = String.Empty;
            switch (dbType.ToLower())
            {
                case "int":
                    type = "int";
                    break;

                case "bigint":
                    type = "long";
                    break;

                case "binary":
                    type = "System.Byte[]";
                    break;

                case "bit":
                    type = "Boolean";
                    break;

                case "datetime":
                    type = "System.DateTime";
                    break;

                case "decimal":
                    type = "System.Decimal";
                    break;

                case "float":
                    type = "System.Double";
                    break;

                case "image":
                    type = "System.Byte[]";
                    break;

                case "money":
                    type = "System.Decimal";
                    break;

                case "numeric":
                    type = "System.Decimal";
                    break;

                case "real":
                    type = "System.Single";
                    break;

                case "smalldatetime":
                    type = "System.DateTime";
                    break;

                case "smallint":
                    type = "Int16";
                    break;

                case "smallmoney":
                    type = "System.Decimal";
                    break;

                case "timestamp":
                    type = "System.DateTime";
                    break;

                case "tinyint":
                    type = "System.Byte";
                    break;

                case "varbinary":
                    type = "System.Byte[]";
                    break;

                case "Variant":
                    type = "Object";
                    break;

                case "double":
                    type = "double";
                    break;

                case "unique identifier":
                    type = "System.Guid";
                    break;

                default:
                    type = "string";
                    break;
            }
            return type;
        }

        /// <summary>
        ///  时间戳转本地时间-时间戳精确到秒
        /// </summary>
        public static DateTime ToLocalTimeDateBySeconds(long unix)
        {
            var dto = DateTimeOffset.FromUnixTimeSeconds(unix);
            return dto.ToLocalTime().DateTime;
        }

        /// <summary>
        ///  时间转时间戳Unix-时间戳精确到秒
        /// </summary>
        public static long ToUnixTimestampBySeconds(DateTime dt)
        {
            DateTimeOffset dto = new DateTimeOffset(dt);
            return dto.ToUnixTimeSeconds();
        }

        /// <summary>
        ///  时间戳转本地时间-时间戳精确到毫秒
        /// </summary>
        public static DateTime ToLocalTimeDateByMilliseconds(long unix)
        {
            var dto = DateTimeOffset.FromUnixTimeMilliseconds(unix);
            return dto.ToLocalTime().DateTime;
        }

        /// <summary>
        ///  时间转时间戳Unix-时间戳精确到毫秒
        /// </summary>
        public static long ToUnixTimestampByMilliseconds(DateTime dt)
        {
            DateTimeOffset dto = new DateTimeOffset(dt);
            return dto.ToUnixTimeMilliseconds();
        }

        public static bool IsValueMin(decimal value1, decimal value2)
        {
            return value1 > value2;
        }

        /// <summary>
        /// 时间格式转换成Quartz任务调度器Cron表达式
        /// </summary>
        /// <param name="time">时间值</param>
        /// <param name="format">格式ss(秒)|mm(分)|HH(小时)|HH:mm|HH:mm:ss</param>
        /// <returns></returns>
        public static string TimeToQuartzCron(string time, string format)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(time)) return "";

                if (format.Equals("ss"))
                {
                    var second = SecondConversion(Convert.ToInt32(time));
                    return CreateCron(second, "ss");
                }
                else if (format.Equals("mm"))
                {
                    var second = SecondConversion(Convert.ToInt32(Convert.ToInt32(time) * 60.0));
                    return CreateCron(second, "mm");
                }
                else if (format.Equals("HH"))
                {
                    var second = SecondConversion(Convert.ToInt32(Convert.ToInt32(time) * 3600.0));
                    return CreateCron(second, "HH");
                }
                else if (format.Equals("HH:mm"))
                {
                    if (!Regex.IsMatch(time, "^([0-2]+[0-3]|[0-1]+[0-9])\\:([0-5]+[0-9])*$")) throw new Exception("格式有问题");
                    string[] times = time.Split(':');
                    TimeSpan ts = new TimeSpan(Convert.ToInt32(times[0]), Convert.ToInt32(times[1]), 0);
                    return CreateCron(ts, "HH:mm");
                }
                else if (format.Equals("HH:mm:ss"))
                {
                    if (!Regex.IsMatch(time, "^([0-2]+[0-3]|[0-1]+[0-9])\\:([0-5]+[0-9])\\:([0-5]+[0-9])*$")) throw new Exception("格式有问题");
                    string[] times = time.Split(':');
                    TimeSpan ts = new TimeSpan(Convert.ToInt32(times[0]), Convert.ToInt32(times[1]), Convert.ToInt32(times[2]));
                    return CreateCron(ts, "HH:mm:ss");
                }
                else if (format.Equals("dd"))
                {
                }
                else if (format.Equals("MM"))
                {
                }
                return null;
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        /// <summary>
        /// 秒转时分秒
        /// </summary>
        /// <param name="second"></param>
        /// <returns></returns>
        public static TimeSpan SecondConversion(int second)
        {
            int hour = second / 3600;
            int min = (second - hour * 3600) / 60;
            int sen = second - hour * 3600 - min * 60;
            TimeSpan ts = new TimeSpan(0, 0, second);
            return ts;
        }

        /// <summary>
        /// 生成表达式
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static string CreateCron(TimeSpan date, string format)
        {
            string ss = "*", mm = "*", hh = "*", dd = "*", month = "*", week = "? ";
            if (Regex.IsMatch(date.ToString(), "^(00:00:)[0-5]+[0-9]*$"))
            {
                //主要针对零点做处理
                if (format.Equals("HH:mm"))
                {
                    hh = "0/" + date.ToString("%h");
                    mm = date.ToString("%m");
                }
                else if (format.Equals("HH:mm:ss"))
                {
                    //取小时、分、秒
                    hh = "0/" + date.ToString("%h");
                    ss = date.ToString("%s");
                    mm = date.ToString("%m");
                }
                else
                {
                    //取秒
                    ss = "0/" + date.ToString("%s");
                }
            }
            else if (Regex.IsMatch(date.ToString(), "^(00:)([0-5]+[1-9]|[1-5]+[0-9])\\:([0-5]+[0-9])*$"))
            {
                //主要针对零点做处理
                if (format.Equals("HH:mm"))
                {
                    hh = "0/" + date.ToString("%h");
                    mm = date.ToString("%m");
                }
                else if (format.Equals("HH:mm:ss"))
                {
                    //取小时、分、秒
                    hh = "0/" + date.ToString("%h");
                    ss = date.ToString("%s");
                    mm = date.ToString("%m");
                }
                else
                {
                    //取分和秒
                    mm = "0/" + date.ToString("%m");
                    ss = date.ToString("%s");
                }
            }
            else if (Regex.IsMatch(date.ToString(), "^([0-2]+[0-3]|[0-1]+[0-9])\\:([0-5]+[0-9])\\:([0-5]+[0-9])*$"))
            {
                //取小时、分、秒
                hh = "0/" + date.ToString("%h");
                ss = date.ToString("%s");
                mm = date.ToString("%m");
            }
            else if (Regex.IsMatch(date.ToString(), "^([1-9]|[0-2]+[0-9]|[3]+[0-1])\\.([0-2]+[0-3]|[0-1]+[0-9])\\:([0-5]+[0-9])\\:([0-5]+[0-9])*$"))
            {
                //取天
                dd = "0/" + date.ToString("%d");
                //取小时
                hh = date.ToString("%h");
                //取分
                mm = date.ToString("%m");
                //取秒
                ss = date.ToString("%s");
            }
            else
            {
                return null;
            }
            string cronValue = ss + " " + mm + " " + hh + " " + dd + " " + month + " " + week;
            return cronValue;
        }

        /// <summary>
        /// list转datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(IEnumerable<T> collection)
        {
            var props = typeof(T).GetProperties();
            var dt = new DataTable();
            dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
            if (collection.Count() > 0)
            {
                for (int i = 0; i < collection.Count(); i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in props)
                    {
                        object obj = pi.GetValue(collection.ElementAt(i), null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    dt.LoadDataRow(array, true);
                }
            }
            return dt;
        }

        /// <summary>
        /// 获取时间戳 -秒
        /// </summary>
        /// <returns></returns>
        public static long GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }
    }
}