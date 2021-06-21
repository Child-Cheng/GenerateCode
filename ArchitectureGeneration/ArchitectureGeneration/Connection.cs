using ArchitectureGeneration.Dao;
using ArchitectureGeneration.Help;
using ArchitectureGeneration.Model;
using SqlSugar;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ArchitectureGeneration
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        #region 事件方式

        //增加event关键字
        //定 义消息发布的事件  事件是委托的一个特殊实例  事件只能在类的内部触发执行
        public event EventHandler SendMsgEvent; //使用默认的事件处理委托

        #endregion 事件方式

        /// <summary>
        /// 关闭当前窗口显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput(out string url, out DbType? dbType);
                if (dbType != null)
                {
                    ConnectDb db = new ConnectDb(url, (DbType)dbType);
                    try
                    {
                        var tables = db.Db.DbMaintenance.GetTableInfoList();
                        if (SendMsgEvent != null)
                        {
                            #region 事件传入参数

                            //触发事件
                            SendMsgEvent(this, new DBEventArg()
                            {
                                ClientDb = db.Db,
                                Type = (DbType)dbType,
                                Url = url,
                                DbName = this.text_db.Text,
                                Name = this.text_Name.Text
                            });

                            #endregion 事件传入参数
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageUtil.ShowError("连接失败,请检查");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput(out string url, out DbType? dbType);
                if (dbType != null)
                {
                    ConnectDb db = new ConnectDb(url, (DbType)dbType);
                    try
                    {
                        var tables = db.Db.DbMaintenance.GetTableInfoList();
                    }
                    catch (Exception)
                    {
                        MessageUtil.ShowError("连接失败,请检查");
                    }
                }
                else
                {
                    MessageUtil.ShowError("请检查连接参数");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 检查输入参数
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dbType"></param>
        private void CheckInput(out string url, out DbType? dbType)
        {
            string text_Name = this.text_Name.Text;
            url = "";
            dbType = null;
            if (string.IsNullOrEmpty(text_Name))
            {
                MessageUtil.ShowError("名称不能为空");
                return;
            }
            string typeDb = this.comboBox_Type_DB.SelectedItem as string;
            if (string.IsNullOrEmpty(typeDb))
            {
                MessageUtil.ShowError("请选择数据库类型");
                return;
            }

            string host = this.text_Host.Text;
            if (string.IsNullOrEmpty(host))
            {
                MessageUtil.ShowError("请输入连接主机");
                return;
            }

            int port = Convert.ToInt32(this.text_Port.Text);
            if (port == 0)
            {
                MessageUtil.ShowError("请输入端口");
                return;
            }
            string user = this.text_User.Text;
            if (string.IsNullOrEmpty(user))
            {
                MessageUtil.ShowError("请输入用户名");
                return;
            }
            string pass = this.text_pass.Text;
            if (string.IsNullOrEmpty(pass))
            {
                MessageUtil.ShowError("请输入密码");
                return;
            }
            string db = this.text_db.Text;
            if (string.IsNullOrEmpty(db))
            {
                MessageUtil.ShowError("请输入数据库");
                return;
            }
            //url = $@"server={text_Host};port={text_Port};user={text_User};password={text_pass};database={text_db};sslMode=none;";
            //url = $@"Data Source={host};port={port};  Initial Catalog={db};uid={user}; pwd={pass};SslMode=none";
            string path = AppPath.GetPath();
            path = Path.Combine(path, "Config/DbConfig.json");
            if ("MySQL".Equals(typeDb))
            {
                dbType = DbType.MySql;
                url = ConfigHelper.Readjson("MySQL", path);
            }
            else if ("MSSQL".Equals(typeDb))
            {
                dbType = DbType.SqlServer;
                url = ConfigHelper.Readjson("MSSQL", path);
            }
            else if ("Oracle".Equals(typeDb))
            {
                dbType = DbType.Oracle;
                url = ConfigHelper.Readjson("Oracle", path);
            }
            else if ("SQLite".Equals(typeDb))
            {
                dbType = DbType.Sqlite;
                url = ConfigHelper.Readjson("SQLite", path);
            }
            else if ("PostgreSQL".Equals(typeDb))
            {
                dbType = DbType.PostgreSQL;
                url = ConfigHelper.Readjson("PostgreSQL", path);
            }
            url = Regex.Replace(url, "{Host}", host, RegexOptions.IgnoreCase);
            url = Regex.Replace(url, "{port}", Convert.ToString(port), RegexOptions.IgnoreCase);
            url = Regex.Replace(url, "{db}", db, RegexOptions.IgnoreCase);
            url = Regex.Replace(url, "{user}", user, RegexOptions.IgnoreCase);
            url = Regex.Replace(url, "{pass}", pass, RegexOptions.IgnoreCase);
            this.text_Url.Text = url;
        }

        private void Connection_Load(object sender, EventArgs e)
        {
        }

        private void text_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }
    }
}