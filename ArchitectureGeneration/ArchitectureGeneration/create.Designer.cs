
namespace ArchitectureGeneration
{
    partial class create
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create));
            this.db_tabControl = new System.Windows.Forms.TabControl();
            this.tabDb = new System.Windows.Forms.TabPage();
            this.text_namespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox_create_type = new System.Windows.Forms.GroupBox();
            this.radio_btn_cover = new System.Windows.Forms.RadioButton();
            this.radio_btn_replace = new System.Windows.Forms.RadioButton();
            this.groupBox_Display = new System.Windows.Forms.GroupBox();
            this.radio_btn_single = new System.Windows.Forms.RadioButton();
            this.radio_btn_whole = new System.Windows.Forms.RadioButton();
            this.btn_create_code = new System.Windows.Forms.Button();
            this.btn_add_connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_server_path = new System.Windows.Forms.Button();
            this.text_server = new System.Windows.Forms.TextBox();
            this.btn_iserver_path = new System.Windows.Forms.Button();
            this.text_iserver = new System.Windows.Forms.TextBox();
            this.btn_dao_path = new System.Windows.Forms.Button();
            this.text_dao = new System.Windows.Forms.TextBox();
            this.btn_idao_path = new System.Windows.Forms.Button();
            this.text_idao_path = new System.Windows.Forms.TextBox();
            this.btn_entity_path = new System.Windows.Forms.Button();
            this.text_entity_path = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_structure = new System.Windows.Forms.GroupBox();
            this.checkBox_other = new System.Windows.Forms.CheckBox();
            this.checkBox_Server = new System.Windows.Forms.CheckBox();
            this.checkBox_IServer = new System.Windows.Forms.CheckBox();
            this.checkBox_Dao = new System.Windows.Forms.CheckBox();
            this.checkBox_IDao = new System.Windows.Forms.CheckBox();
            this.checkBox_entity = new System.Windows.Forms.CheckBox();
            this.comboBox_template = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView_Menu = new System.Windows.Forms.TreeView();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.view_table = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTemplate = new System.Windows.Forms.TabPage();
            this.db_tabControl.SuspendLayout();
            this.tabDb.SuspendLayout();
            this.groupBox_create_type.SuspendLayout();
            this.groupBox_Display.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_structure.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_tabControl
            // 
            this.db_tabControl.Controls.Add(this.tabDb);
            this.db_tabControl.Controls.Add(this.tabTemplate);
            this.db_tabControl.Location = new System.Drawing.Point(0, -2);
            this.db_tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.db_tabControl.Name = "db_tabControl";
            this.db_tabControl.SelectedIndex = 0;
            this.db_tabControl.Size = new System.Drawing.Size(1209, 826);
            this.db_tabControl.TabIndex = 0;
            // 
            // tabDb
            // 
            this.tabDb.Controls.Add(this.text_namespace);
            this.tabDb.Controls.Add(this.label1);
            this.tabDb.Controls.Add(this.listView1);
            this.tabDb.Controls.Add(this.groupBox_create_type);
            this.tabDb.Controls.Add(this.groupBox_Display);
            this.tabDb.Controls.Add(this.btn_create_code);
            this.tabDb.Controls.Add(this.btn_add_connect);
            this.tabDb.Controls.Add(this.groupBox2);
            this.tabDb.Controls.Add(this.groupBox_structure);
            this.tabDb.Controls.Add(this.comboBox_template);
            this.tabDb.Controls.Add(this.label2);
            this.tabDb.Controls.Add(this.treeView_Menu);
            this.tabDb.Location = new System.Drawing.Point(4, 31);
            this.tabDb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDb.Name = "tabDb";
            this.tabDb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDb.Size = new System.Drawing.Size(1201, 791);
            this.tabDb.TabIndex = 0;
            this.tabDb.Text = "数据库";
            this.tabDb.UseVisualStyleBackColor = true;
            // 
            // text_namespace
            // 
            this.text_namespace.Location = new System.Drawing.Point(536, 681);
            this.text_namespace.Name = "text_namespace";
            this.text_namespace.Size = new System.Drawing.Size(635, 31);
            this.text_namespace.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "命名空间:";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(410, 523);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(761, 143);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file.ico");
            // 
            // groupBox_create_type
            // 
            this.groupBox_create_type.Controls.Add(this.radio_btn_cover);
            this.groupBox_create_type.Controls.Add(this.radio_btn_replace);
            this.groupBox_create_type.Location = new System.Drawing.Point(764, 4);
            this.groupBox_create_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_create_type.Name = "groupBox_create_type";
            this.groupBox_create_type.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_create_type.Size = new System.Drawing.Size(353, 69);
            this.groupBox_create_type.TabIndex = 31;
            this.groupBox_create_type.TabStop = false;
            this.groupBox_create_type.Text = "生成类型";
            // 
            // radio_btn_cover
            // 
            this.radio_btn_cover.AutoSize = true;
            this.radio_btn_cover.Checked = true;
            this.radio_btn_cover.Location = new System.Drawing.Point(35, 25);
            this.radio_btn_cover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_btn_cover.Name = "radio_btn_cover";
            this.radio_btn_cover.Size = new System.Drawing.Size(119, 25);
            this.radio_btn_cover.TabIndex = 7;
            this.radio_btn_cover.TabStop = true;
            this.radio_btn_cover.Text = "覆盖生成";
            this.radio_btn_cover.UseVisualStyleBackColor = true;
            // 
            // radio_btn_replace
            // 
            this.radio_btn_replace.AutoSize = true;
            this.radio_btn_replace.Location = new System.Drawing.Point(196, 25);
            this.radio_btn_replace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_btn_replace.Name = "radio_btn_replace";
            this.radio_btn_replace.Size = new System.Drawing.Size(119, 25);
            this.radio_btn_replace.TabIndex = 8;
            this.radio_btn_replace.Text = "替换生成";
            this.radio_btn_replace.UseVisualStyleBackColor = true;
            // 
            // groupBox_Display
            // 
            this.groupBox_Display.Controls.Add(this.radio_btn_single);
            this.groupBox_Display.Controls.Add(this.radio_btn_whole);
            this.groupBox_Display.Location = new System.Drawing.Point(410, 4);
            this.groupBox_Display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Display.Name = "groupBox_Display";
            this.groupBox_Display.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Display.Size = new System.Drawing.Size(296, 69);
            this.groupBox_Display.TabIndex = 30;
            this.groupBox_Display.TabStop = false;
            this.groupBox_Display.Text = "展示模式";
            // 
            // radio_btn_single
            // 
            this.radio_btn_single.AutoSize = true;
            this.radio_btn_single.Checked = true;
            this.radio_btn_single.Location = new System.Drawing.Point(156, 26);
            this.radio_btn_single.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_btn_single.Name = "radio_btn_single";
            this.radio_btn_single.Size = new System.Drawing.Size(77, 25);
            this.radio_btn_single.TabIndex = 3;
            this.radio_btn_single.TabStop = true;
            this.radio_btn_single.Text = "单库";
            this.radio_btn_single.UseVisualStyleBackColor = true;
            // 
            // radio_btn_whole
            // 
            this.radio_btn_whole.AutoSize = true;
            this.radio_btn_whole.Location = new System.Drawing.Point(19, 26);
            this.radio_btn_whole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_btn_whole.Name = "radio_btn_whole";
            this.radio_btn_whole.Size = new System.Drawing.Size(98, 25);
            this.radio_btn_whole.TabIndex = 2;
            this.radio_btn_whole.Text = "所有库";
            this.radio_btn_whole.UseVisualStyleBackColor = true;
            // 
            // btn_create_code
            // 
            this.btn_create_code.Location = new System.Drawing.Point(1037, 741);
            this.btn_create_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_create_code.Name = "btn_create_code";
            this.btn_create_code.Size = new System.Drawing.Size(117, 42);
            this.btn_create_code.TabIndex = 24;
            this.btn_create_code.Text = "生成";
            this.btn_create_code.UseVisualStyleBackColor = true;
            this.btn_create_code.Click += new System.EventHandler(this.btn_create_code_Click);
            // 
            // btn_add_connect
            // 
            this.btn_add_connect.Location = new System.Drawing.Point(419, 741);
            this.btn_add_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_connect.Name = "btn_add_connect";
            this.btn_add_connect.Size = new System.Drawing.Size(105, 42);
            this.btn_add_connect.TabIndex = 23;
            this.btn_add_connect.Text = "添加连接";
            this.btn_add_connect.UseVisualStyleBackColor = true;
            this.btn_add_connect.Click += new System.EventHandler(this.btn_add_connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_server_path);
            this.groupBox2.Controls.Add(this.text_server);
            this.groupBox2.Controls.Add(this.btn_iserver_path);
            this.groupBox2.Controls.Add(this.text_iserver);
            this.groupBox2.Controls.Add(this.btn_dao_path);
            this.groupBox2.Controls.Add(this.text_dao);
            this.groupBox2.Controls.Add(this.btn_idao_path);
            this.groupBox2.Controls.Add(this.text_idao_path);
            this.groupBox2.Controls.Add(this.btn_entity_path);
            this.groupBox2.Controls.Add(this.text_entity_path);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(410, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(761, 269);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成路径";
            // 
            // btn_server_path
            // 
            this.btn_server_path.Location = new System.Drawing.Point(660, 207);
            this.btn_server_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_server_path.Name = "btn_server_path";
            this.btn_server_path.Size = new System.Drawing.Size(84, 35);
            this.btn_server_path.TabIndex = 31;
            this.btn_server_path.Text = "选择";
            this.btn_server_path.UseVisualStyleBackColor = true;
            this.btn_server_path.Click += new System.EventHandler(this.btn_server_path_Click);
            // 
            // text_server
            // 
            this.text_server.Location = new System.Drawing.Point(168, 207);
            this.text_server.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_server.Name = "text_server";
            this.text_server.Size = new System.Drawing.Size(464, 31);
            this.text_server.TabIndex = 30;
            // 
            // btn_iserver_path
            // 
            this.btn_iserver_path.Location = new System.Drawing.Point(660, 162);
            this.btn_iserver_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_iserver_path.Name = "btn_iserver_path";
            this.btn_iserver_path.Size = new System.Drawing.Size(84, 35);
            this.btn_iserver_path.TabIndex = 29;
            this.btn_iserver_path.Text = "选择";
            this.btn_iserver_path.UseVisualStyleBackColor = true;
            this.btn_iserver_path.Click += new System.EventHandler(this.btn_iserver_path_Click);
            // 
            // text_iserver
            // 
            this.text_iserver.Location = new System.Drawing.Point(168, 162);
            this.text_iserver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_iserver.Name = "text_iserver";
            this.text_iserver.Size = new System.Drawing.Size(464, 31);
            this.text_iserver.TabIndex = 28;
            // 
            // btn_dao_path
            // 
            this.btn_dao_path.Location = new System.Drawing.Point(660, 118);
            this.btn_dao_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dao_path.Name = "btn_dao_path";
            this.btn_dao_path.Size = new System.Drawing.Size(84, 35);
            this.btn_dao_path.TabIndex = 27;
            this.btn_dao_path.Text = "选择";
            this.btn_dao_path.UseVisualStyleBackColor = true;
            this.btn_dao_path.Click += new System.EventHandler(this.btn_dao_path_Click);
            // 
            // text_dao
            // 
            this.text_dao.Location = new System.Drawing.Point(168, 118);
            this.text_dao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_dao.Name = "text_dao";
            this.text_dao.Size = new System.Drawing.Size(464, 31);
            this.text_dao.TabIndex = 26;
            // 
            // btn_idao_path
            // 
            this.btn_idao_path.Location = new System.Drawing.Point(660, 71);
            this.btn_idao_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_idao_path.Name = "btn_idao_path";
            this.btn_idao_path.Size = new System.Drawing.Size(84, 35);
            this.btn_idao_path.TabIndex = 25;
            this.btn_idao_path.Text = "选择";
            this.btn_idao_path.UseVisualStyleBackColor = true;
            this.btn_idao_path.Click += new System.EventHandler(this.btn_idao_path_Click);
            // 
            // text_idao_path
            // 
            this.text_idao_path.Location = new System.Drawing.Point(169, 71);
            this.text_idao_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_idao_path.Name = "text_idao_path";
            this.text_idao_path.Size = new System.Drawing.Size(464, 31);
            this.text_idao_path.TabIndex = 24;
            // 
            // btn_entity_path
            // 
            this.btn_entity_path.Location = new System.Drawing.Point(660, 24);
            this.btn_entity_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_entity_path.Name = "btn_entity_path";
            this.btn_entity_path.Size = new System.Drawing.Size(84, 35);
            this.btn_entity_path.TabIndex = 23;
            this.btn_entity_path.Text = "选择";
            this.btn_entity_path.UseVisualStyleBackColor = true;
            this.btn_entity_path.Click += new System.EventHandler(this.btn_entity_path_Click);
            // 
            // text_entity_path
            // 
            this.text_entity_path.Location = new System.Drawing.Point(169, 24);
            this.text_entity_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_entity_path.Name = "text_entity_path";
            this.text_entity_path.Size = new System.Drawing.Size(464, 31);
            this.text_entity_path.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "实体路径:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "业务实现路径:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "业务接口路径:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "数据实现路径:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "数据接口路径:";
            // 
            // groupBox_structure
            // 
            this.groupBox_structure.Controls.Add(this.checkBox_other);
            this.groupBox_structure.Controls.Add(this.checkBox_Server);
            this.groupBox_structure.Controls.Add(this.checkBox_IServer);
            this.groupBox_structure.Controls.Add(this.checkBox_Dao);
            this.groupBox_structure.Controls.Add(this.checkBox_IDao);
            this.groupBox_structure.Controls.Add(this.checkBox_entity);
            this.groupBox_structure.Location = new System.Drawing.Point(410, 77);
            this.groupBox_structure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_structure.Name = "groupBox_structure";
            this.groupBox_structure.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_structure.Size = new System.Drawing.Size(761, 124);
            this.groupBox_structure.TabIndex = 16;
            this.groupBox_structure.TabStop = false;
            this.groupBox_structure.Text = "生成结构";
            // 
            // checkBox_other
            // 
            this.checkBox_other.AutoSize = true;
            this.checkBox_other.Location = new System.Drawing.Point(15, 83);
            this.checkBox_other.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_other.Name = "checkBox_other";
            this.checkBox_other.Size = new System.Drawing.Size(78, 25);
            this.checkBox_other.TabIndex = 21;
            this.checkBox_other.Text = "其它";
            this.checkBox_other.UseVisualStyleBackColor = true;
            this.checkBox_other.CheckedChanged += new System.EventHandler(this.checkBox_other_CheckedChanged);
            // 
            // checkBox_Server
            // 
            this.checkBox_Server.AutoSize = true;
            this.checkBox_Server.Location = new System.Drawing.Point(551, 37);
            this.checkBox_Server.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Server.Name = "checkBox_Server";
            this.checkBox_Server.Size = new System.Drawing.Size(162, 25);
            this.checkBox_Server.TabIndex = 20;
            this.checkBox_Server.Text = "业务接口实现";
            this.checkBox_Server.UseVisualStyleBackColor = true;
            this.checkBox_Server.CheckedChanged += new System.EventHandler(this.checkBox_Server_CheckedChanged);
            // 
            // checkBox_IServer
            // 
            this.checkBox_IServer.AutoSize = true;
            this.checkBox_IServer.Location = new System.Drawing.Point(427, 37);
            this.checkBox_IServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_IServer.Name = "checkBox_IServer";
            this.checkBox_IServer.Size = new System.Drawing.Size(120, 25);
            this.checkBox_IServer.TabIndex = 19;
            this.checkBox_IServer.Text = "业务接口";
            this.checkBox_IServer.UseVisualStyleBackColor = true;
            this.checkBox_IServer.CheckedChanged += new System.EventHandler(this.checkBox_IServer_CheckedChanged);
            // 
            // checkBox_Dao
            // 
            this.checkBox_Dao.AutoSize = true;
            this.checkBox_Dao.Location = new System.Drawing.Point(261, 37);
            this.checkBox_Dao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Dao.Name = "checkBox_Dao";
            this.checkBox_Dao.Size = new System.Drawing.Size(162, 25);
            this.checkBox_Dao.TabIndex = 18;
            this.checkBox_Dao.Text = "数据接口实现";
            this.checkBox_Dao.UseVisualStyleBackColor = true;
            this.checkBox_Dao.CheckedChanged += new System.EventHandler(this.checkBox_Dao_CheckedChanged);
            // 
            // checkBox_IDao
            // 
            this.checkBox_IDao.AutoSize = true;
            this.checkBox_IDao.Location = new System.Drawing.Point(130, 37);
            this.checkBox_IDao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_IDao.Name = "checkBox_IDao";
            this.checkBox_IDao.Size = new System.Drawing.Size(120, 25);
            this.checkBox_IDao.TabIndex = 17;
            this.checkBox_IDao.Text = "数据接口";
            this.checkBox_IDao.UseVisualStyleBackColor = true;
            this.checkBox_IDao.CheckedChanged += new System.EventHandler(this.checkBox_IDao_CheckedChanged);
            // 
            // checkBox_entity
            // 
            this.checkBox_entity.AutoSize = true;
            this.checkBox_entity.Checked = true;
            this.checkBox_entity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_entity.Location = new System.Drawing.Point(15, 37);
            this.checkBox_entity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_entity.Name = "checkBox_entity";
            this.checkBox_entity.Size = new System.Drawing.Size(99, 25);
            this.checkBox_entity.TabIndex = 15;
            this.checkBox_entity.Text = "实体类";
            this.checkBox_entity.UseVisualStyleBackColor = true;
            this.checkBox_entity.CheckedChanged += new System.EventHandler(this.checkBox_entity_CheckedChanged);
            // 
            // comboBox_template
            // 
            this.comboBox_template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_template.FormattingEnabled = true;
            this.comboBox_template.Location = new System.Drawing.Point(536, 483);
            this.comboBox_template.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_template.Name = "comboBox_template";
            this.comboBox_template.Size = new System.Drawing.Size(161, 29);
            this.comboBox_template.TabIndex = 9;
            this.comboBox_template.SelectedIndexChanged += new System.EventHandler(this.comboBox_template_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "选择模版:";
            // 
            // treeView_Menu
            // 
            this.treeView_Menu.ContextMenuStrip = this.Menu;
            this.treeView_Menu.HideSelection = false;
            this.treeView_Menu.Location = new System.Drawing.Point(0, 2);
            this.treeView_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Menu.Name = "treeView_Menu";
            this.treeView_Menu.Size = new System.Drawing.Size(387, 781);
            this.treeView_Menu.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_table,
            this.Refresh});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(271, 110);
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // view_table
            // 
            this.view_table.Name = "view_table";
            this.view_table.Size = new System.Drawing.Size(270, 34);
            this.view_table.Text = "查看表";
            // 
            // Refresh
            // 
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(270, 34);
            this.Refresh.Text = "刷新";
            // 
            // tabTemplate
            // 
            this.tabTemplate.Location = new System.Drawing.Point(4, 31);
            this.tabTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTemplate.Name = "tabTemplate";
            this.tabTemplate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTemplate.Size = new System.Drawing.Size(1201, 791);
            this.tabTemplate.TabIndex = 1;
            this.tabTemplate.Text = "模版管理";
            this.tabTemplate.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1201, 823);
            this.Controls.Add(this.db_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "create";
            this.Text = "代码生成工具";
            this.Load += new System.EventHandler(this.create_Load);
            this.db_tabControl.ResumeLayout(false);
            this.tabDb.ResumeLayout(false);
            this.tabDb.PerformLayout();
            this.groupBox_create_type.ResumeLayout(false);
            this.groupBox_create_type.PerformLayout();
            this.groupBox_Display.ResumeLayout(false);
            this.groupBox_Display.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_structure.ResumeLayout(false);
            this.groupBox_structure.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl db_tabControl;
        private System.Windows.Forms.TabPage tabTemplate;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem view_table;
        private System.Windows.Forms.ToolStripMenuItem Refresh;
        private System.Windows.Forms.TabPage tabDb;
        private System.Windows.Forms.GroupBox groupBox_create_type;
        private System.Windows.Forms.RadioButton radio_btn_cover;
        private System.Windows.Forms.RadioButton radio_btn_replace;
        private System.Windows.Forms.GroupBox groupBox_Display;
        private System.Windows.Forms.RadioButton radio_btn_single;
        private System.Windows.Forms.RadioButton radio_btn_whole;
        private System.Windows.Forms.Button btn_create_code;
        private System.Windows.Forms.Button btn_add_connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_server_path;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.Button btn_iserver_path;
        private System.Windows.Forms.TextBox text_iserver;
        private System.Windows.Forms.Button btn_dao_path;
        private System.Windows.Forms.TextBox text_dao;
        private System.Windows.Forms.Button btn_idao_path;
        private System.Windows.Forms.TextBox text_idao_path;
        private System.Windows.Forms.Button btn_entity_path;
        private System.Windows.Forms.TextBox text_entity_path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_structure;
        private System.Windows.Forms.CheckBox checkBox_other;
        private System.Windows.Forms.CheckBox checkBox_Server;
        private System.Windows.Forms.CheckBox checkBox_IServer;
        private System.Windows.Forms.CheckBox checkBox_Dao;
        private System.Windows.Forms.CheckBox checkBox_IDao;
        private System.Windows.Forms.CheckBox checkBox_entity;
        private System.Windows.Forms.ComboBox comboBox_template;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView_Menu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_namespace;
    }
}

