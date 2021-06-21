using ArchitectureGeneration.Help;
using ArchitectureGeneration.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DbType = SqlSugar.DbType;

namespace ArchitectureGeneration
{
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
        }

        private SqlSugarClient _db;

        private DbType _type;

        private string _urlDb;

        private string _dbName;

        private string _name;

        /// <summary>
        /// 右键菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Click(object sender, EventArgs e)
        {
            var menu = (sender as ContextMenuStrip);
            var item = menu.Items;
            foreach (ToolStripItem items in menu.Items)
            {
                if (items.Selected == true)
                {
                    if ("查看表".Equals(items.ToString()))
                    {
                    }
                    else if ("刷新".Equals(items.ToString()))
                    {
                    }
                }
            }
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="list"></param>
        /// <param name="pnode"></param>
        private void AddTree<T>(List<T> list, TreeNode pnode) where T : class
        {
            foreach (var item in list)
            {
                TreeNode node = new TreeNode();
                var type = item.GetType();
                SqlSugarClient sugarClient;
                if (pnode == null)
                {
                    //获取所有库下的所有表
                    node.Text = item.ToString();
                    node.Tag = item.ToString();    //作为节点标识符
                    this.treeView_Menu.Nodes.Add(node);
                    GetBaseDbTableList(node, item.ToString(), out sugarClient);
                }
                else
                {
                    if ("SqlSugar.DbTableInfo".Equals(type.FullName))
                    {
                        var _item = item as DbTableInfo;
                        node.Text = _item.Name;
                        node.Tag = _item.Name;    //作为节点标识符
                        pnode.Nodes.Add(node);
                        List<DbColumnInfo> tableInfo = SqlSugarHelp.GetColumnInfosByTableName(_item.Name, _db);
                        AddTree<DbColumnInfo>(tableInfo, node);
                        //GetBaseDbTableList(node, item.ToString());
                    }
                    else if ("SqlSugar.DbColumnInfo".Equals(type.FullName))
                    {
                        var _item = item as DbColumnInfo;
                        node.Text = _item.DbColumnName;
                        node.Tag = _item.DbColumnName;    //作为节点标识符
                        pnode.Nodes.Add(node);
                    }
                    else
                    {
                        node.Text = item.ToString();
                        node.Tag = item.ToString();    //作为节点标识符
                        pnode.Nodes.Add(pnode);
                    }
                }
            }
        }

        /// <summary>
        /// 获取数据库下的所有表
        /// </summary>
        private void GetBaseDbTableList(TreeNode node, string dbName, out SqlSugarClient sugarClient)
        {
            string dbConfig = _urlDb;
            string url = dbConfig.Replace(_dbName, dbName);
            _dbName = dbName;
            var db = new SqlSugarClient(
                     new ConnectionConfig()
                     {
                         ConnectionString = url, //
                         DbType = _type,
                         InitKeyType = InitKeyType.Attribute, //从特性读取主键和自增列信息
                         IsAutoCloseConnection = true, //开启自动释放模式和EF原理一样我就不多解释了
                         IsShardSameThread = true, //设为true相同线程是同一个SqlConnection
                     }
            );
            List<DbTableInfo> tables = SqlSugarHelp.GetTableInfoList(db); //db.DbMaintenance.GetTableInfoList();
            sugarClient = db;
            AddTree<DbTableInfo>(tables, node);
        }

        #region 路径选择事件

        private void btn_entity_path_Click(object sender, EventArgs e)
        {
            this.text_entity_path.Text = GetFolder();
        }

        private void btn_idao_path_Click(object sender, EventArgs e)
        {
            this.text_idao_path.Text = GetFolder();
        }

        private void btn_dao_path_Click(object sender, EventArgs e)
        {
            this.text_dao.Text = GetFolder();
        }

        private void btn_iserver_path_Click(object sender, EventArgs e)
        {
            this.text_iserver.Text = GetFolder();
        }

        private void btn_server_path_Click(object sender, EventArgs e)
        {
            this.text_server.Text = GetFolder();
        }

        #endregion 路径选择事件

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <returns></returns>
        public string GetFolder()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            //dialog.RootFolder = Environment.SpecialFolder.Programs;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                return foldPath;
            }
            return "";
        }

        /// <summary>
        /// 添加数据连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_connect_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                connection.SendMsgEvent += (obj, args) =>
                {
                    var o = (DBEventArg)args;
                    _db = o.ClientDb;
                    _type = o.Type;
                    _urlDb = o.Url;
                    _dbName = o.DbName;
                    _name = o.Name;
                };
                connection.ShowDialog();
                if (connection.DialogResult == DialogResult.OK)
                {
                    if (DisplayType())
                    {
                        var db = _db.DbMaintenance;
                        List<String> baseList = db.GetDataBaseList(_db);
                        List<DbTableInfo> tables = db.GetTableInfoList();
                        TreeNode node = new TreeNode();
                        node.Text = _name;
                        node.Tag = _name;    //作为节点标识符
                        this.treeView_Menu.Nodes.Add(node);
                        TreeNode dbNameNode = new TreeNode();
                        dbNameNode.Text = _dbName;
                        dbNameNode.Tag = _dbName;    //作为节点标识符
                        node.Nodes.Add(dbNameNode);
                        AddTree<DbTableInfo>(tables, dbNameNode);
                    }
                    else
                    {
                        //所有数据库都展示出来
                        MessageUtil.ShowTips("所有库展示功能未实现");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_create_code_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBox_other.Checked)
                {
                    MessageUtil.ShowTips("该功能未实现");
                    return;
                }
                //判断生成类型
                if (CreateType())
                {
                    string path = GetTemplate();
                    if (path == null) { MessageUtil.ShowError("请选择模版"); return; }
                    string[] templateList = GetFileAll(path);
                    if (IsCreatePath())
                        if (IsTreeViewSelectedNode())
                        {
                            if (string.IsNullOrEmpty(this.text_namespace.Text)) { MessageUtil.ShowError("请填写名命空间"); return; }

                            var treeView = this.treeView_Menu;

                            string text = treeView.SelectedNode.Text;
                            //选中的是库
                            var tables = SqlSugarHelp.GetTableInfoList(_db);
                            if (_dbName.Equals(text))
                            {
                                foreach (var table in tables)
                                {
                                    CreateClass(table.Name, templateList, table);
                                }
                            }
                            else
                            {
                                CreateClass(text, templateList, tables.Find(t => t.Name == text));
                            }
                        }
                        else
                        {
                            MessageUtil.ShowError("请选择需要生成的表或者库");
                        }
                }
                else
                {
                    //替换
                    MessageUtil.ShowWarning("该功能未实现");
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// 生成类
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="template"></param>
        private void CreateClass(string tableName, string[] template, Object tableInfo)
        {
            List<DbColumnInfo> dbColumnInfo = SqlSugarHelp.GetColumnInfosByTableName(tableName, _db);
            var v = InitVelocity();
            v.Add("namespace", this.text_namespace.Text.Trim());
            //公开表名给模版
            v.Add("tableName", tableName);
            //公开表中的所有列给模版
            v.Add("tableColumns", dbColumnInfo);
            //表的详细信息
            v.Add("tableInfo", tableInfo);
            foreach (var fullPath in template)
            {
                string filename = System.IO.Path.GetFileName(fullPath);
                v.CreateFile(filename, this.text_entity_path.Text);
            }
        }

        /// <summary>
        /// 判断展示模式
        /// </summary>
        /// <returns>true为单库,false所有库</returns>
        private bool DisplayType() => this.radio_btn_single.Checked == true ? true : false;

        /// <summary>
        /// 判断生成类型
        /// </summary>
        /// <returns>true为覆盖,false替换</returns>
        private bool CreateType() => this.radio_btn_cover.Checked == true ? true : false;

        /// <summary>
        /// 根据分组获取目录下的模版
        /// </summary>
        /// <returns></returns>
        private string GetTemplate()
        {
            try
            {
                string template = this.comboBox_template.SelectedItem as string;
                if (string.IsNullOrEmpty(template)) return null;
                string path = AppPath.GetPath();
                path = Path.Combine(path, "template");
                path = Path.Combine(path, template);
                if (!Directory.Exists(path)) { throw new NoPathException("模版路径不存"); }
                return path;
            }
            catch (NoPathException np)
            {
                throw np;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取目录下的所有文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileType"></param>
        /// <returns></returns>
        private string[] GetFileAll(string path, string fileType = "*.vm")
        {
            string[] files = Directory.GetFiles(path, fileType);
            return files;
        }

        /// <summary>
        /// 判断勾选的生成结构是否选择路径
        /// </summary>
        /// <returns></returns>
        private bool IsCreatePath()
        {
            if (this.checkBox_entity.Checked)
            {
                if (string.IsNullOrEmpty(this.text_entity_path.Text)) { MessageUtil.ShowError("请选择实体生成路径"); return false; }
            }
            if (this.checkBox_IDao.Checked) if (string.IsNullOrEmpty(this.text_idao_path.Text)) { MessageUtil.ShowError("请选择数据接口生成路径"); return false; }
            if (this.checkBox_Dao.Checked) if (string.IsNullOrEmpty(this.text_dao.Text)) { MessageUtil.ShowError("请选择数据实现生成路径"); return false; }
            if (this.checkBox_IServer.Checked) if (string.IsNullOrEmpty(this.text_iserver.Text)) { MessageUtil.ShowError("请选择业务接口生成路径"); return false; }
            if (this.checkBox_Server.Checked) if (string.IsNullOrEmpty(this.text_server.Text)) { MessageUtil.ShowError("请选择业务实现生成路径"); return false; }
            return true;
        }

        /// <summary>
        /// 当选择生成结构为其它时取消其他的选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_other_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == false) return;
            foreach (var item in this.groupBox_structure.Controls)
            {
                var c = (CheckBox)item;
                if (c.Checked && "其它".Equals(c.Text))
                {
                    foreach (CheckBox ch in this.groupBox_structure.Controls)
                    {
                        if (ch.Checked == true && !"其它".Equals(ch.Text))
                            ch.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// 取消其他的选择
        /// </summary>
        private void CheckBoxCheckedChanged()
        {
            if (this.checkBox_other.Checked)
            {
                this.checkBox_other.Checked = false;
            }
        }

        /// <summary>
        /// 判断TreeView是否选中节点
        /// </summary>
        /// <returns></returns>
        private bool IsTreeViewSelectedNode()
        {
            if (this.treeView_Menu.SelectedNode != null)
            {
                return (this.treeView_Menu.SelectedNode.Nodes.Count > 0);
            }
            return false;
        }

        #region 生成结构 checkedBox 改变事件

        private void checkBox_entity_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheckedChanged();
        }

        private void checkBox_IDao_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheckedChanged();
        }

        private void checkBox_Dao_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheckedChanged();
        }

        private void checkBox_IServer_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheckedChanged();
        }

        private void checkBox_Server_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxCheckedChanged();
        }

        #endregion 生成结构 checkedBox 改变事件

        /// <summary>
        /// 初始化模版
        /// </summary>
        /// <returns></returns>
        private VelocityHelper InitVelocity()
        {
            VelocityHelper vh = new VelocityHelper();
            var tool = new Tool();
            string temp = GetTemplate();
            if (temp == null) throw new Exception("请选择模版");
            vh.Init(temp);//模板路径
            vh.Add("tools", tool);
            //公开数据源
            vh.Add("dbTool", _db.DbMaintenance);
            return vh;
        }

        /// <summary>
        /// 显示生成类
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="template"></param>
        private string DisplayClass(string tableName, string template, Object tableInfo)
        {
            List<DbColumnInfo> dbColumnInfo = SqlSugarHelp.GetColumnInfosByTableName(tableName, _db);
            var v = InitVelocity();
            v.Add("namespace", "Com.macao.electron");
            //公开表名给模版
            v.Add("tableName", tableName);
            //公开表中的所有列给模版
            v.Add("tableColumns", dbColumnInfo);
            //表的详细信息
            v.Add("tableInfo", tableInfo);
            string filename = System.IO.Path.GetFileName(template);
            return v.Display(filename);
        }

        /// <summary>
        /// 获取模版目录下的一级目录
        /// </summary>
        /// <returns></returns>
        private DirectoryInfo[] GetTemplateFolder()
        {
            string path = AppPath.GetPath();
            path = Path.Combine(path, "template");
            DirectoryInfo root = new DirectoryInfo(path);
            DirectoryInfo[] dics = root.GetDirectories();
            return dics;
        }

        private void create_Load(object sender, EventArgs e)
        {
            var template = GetTemplateFolder();
            foreach (var folder in template)
            {
                this.comboBox_template.Items.Add(folder.Name);
            }
            //添加单击事件
            this.listView1.SelectedIndexChanged += new EventHandler(btnClick);
        }

        private void comboBox_template_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //int i = 0;
                //int row = 1;
                var templatePath = GetTemplate();
                var templateFile = GetFileAll(templatePath);

                this.listView1.Items.Clear();

                this.listView1.View = View.SmallIcon;

                this.listView1.SmallImageList = this.imageList1;

                this.listView1.BeginUpdate();

                foreach (var item in templateFile)
                {
                    string filename = System.IO.Path.GetFileNameWithoutExtension(item);
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = 0;
                    lvi.Text = filename;

                    this.listView1.Items.Add(lvi);
                }

                this.listView1.EndUpdate();

                //foreach (var item in templateFile)
                //{
                //    if (i >= buttons.Length)
                //    {
                //        Array.Resize(ref buttons, buttons.Length + 10);
                //    }

                //    string filename = System.IO.Path.GetFileNameWithoutExtension(item);
                //    buttons[i] = new Button()
                //    {
                //        Text = filename,
                //        //ForeColor = Color.FromArgb(new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255)),
                //        AutoSize = true,
                //    };
                //    if (i == 0)
                //    {
                //        buttons[i].Location = new Point(5, 5);
                //    }
                //    else
                //    {
                //        int width = 0;
                //        int height = 0;
                //        var listBoxWidth = this.listBox_btn.Width;
                //        for (int j = 0; j < buttons.Length; j++)
                //        {
                //            var btn = buttons[j];
                //            if (btn != null && j < i)
                //            {
                //                width = width + btn.Width;

                //                var w = ((width - listBoxWidth) - btn.Width);
                //                if (width > (listBoxWidth - 50))
                //                {
                //                    width = 0;
                //                    height = btn.Height;
                //                }
                //            }
                //            else
                //            {
                //                break;
                //            }
                //        }
                //        buttons[i].Location = new Point(width + 5, 5 + height);
                //    }
                //    buttons[i].Click += btnClick;
                //    this.listBox_btn.Controls.Add(buttons[i]);
                //    i++;
                //}
            }
            catch (Exception ex)
            {
                MessageUtil.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// 点击预览生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClick(object sender, EventArgs e)
        {
            ListView lvCategory = (ListView)sender;//获取动态创建的listview对象
            if (lvCategory.SelectedItems.Count > 0)
            {
                string categoryName = lvCategory.SelectedItems[0].SubItems[0].Text;//绑定产品
                if (IsTreeViewSelectedNode())
                {
                    var treeView = this.treeView_Menu;
                    string text = treeView.SelectedNode.Text;
                    string path = GetTemplate();
                    if (path == null) { MessageUtil.ShowError("请选择模版"); return; }
                    string[] templateList = GetFileAll(path, categoryName + ".vm");
                    var tables = SqlSugarHelp.GetTableInfoList(_db);
                    foreach (var item in templateList)
                    {
                        string code = DisplayClass(text, item, tables.Find(t => t.Name == text));
                        SetPreviewCode(code, text);
                    }
                }
                else
                {
                    MessageUtil.ShowTips("请选中表");
                }
            }
        }

        /// <summary>
        /// 报表列表框-单选模式的实现,列表框应关闭多选模式,放在事件_ItemCheck下
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="e"></param>
        public static void ListViewSingleSelectedAndChecked(ListView lv, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked)
            {
                int count = lv.Items.Count;
                ListViewItem item = lv.Items[e.Index];
                if (!item.Checked)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (i != e.Index)
                        {
                            ListViewItem item1 = lv.Items[i];
                            item1.Checked = false;
                            item1.Selected = false;
                        }
                        else { lv.Items[i].Selected = true; }
                    }
                }
            }
            if (e.CurrentValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
                if (lv.Items[e.Index].Selected)
                {
                    lv.Items[e.Index].Selected = false;
                }
            }
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ListViewSingleSelectedAndChecked(this.listView1, e);
        }

        private void SetPreviewCode(string code, string tileText)
        {
            PreviewCode preview = new PreviewCode(code);
            preview.Text = tileText;
            preview.Show();
        }
    }
}