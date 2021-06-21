
namespace ArchitectureGeneration
{
    partial class Connection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_Url = new System.Windows.Forms.RichTextBox();
            this.label_db = new System.Windows.Forms.Label();
            this.text_db = new System.Windows.Forms.TextBox();
            this.text_Host = new System.Windows.Forms.TextBox();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_Port = new System.Windows.Forms.TextBox();
            this.text_User = new System.Windows.Forms.TextBox();
            this.text_notes = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.comboBox_Type_DB = new System.Windows.Forms.ComboBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_Host = new System.Windows.Forms.Label();
            this.label_notes = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_Name);
            this.groupBox1.Controls.Add(this.text_Url);
            this.groupBox1.Controls.Add(this.label_db);
            this.groupBox1.Controls.Add(this.text_db);
            this.groupBox1.Controls.Add(this.text_Host);
            this.groupBox1.Controls.Add(this.text_pass);
            this.groupBox1.Controls.Add(this.text_Port);
            this.groupBox1.Controls.Add(this.text_User);
            this.groupBox1.Controls.Add(this.text_notes);
            this.groupBox1.Controls.Add(this.label_url);
            this.groupBox1.Controls.Add(this.comboBox_Type_DB);
            this.groupBox1.Controls.Add(this.label_pass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_User);
            this.groupBox1.Controls.Add(this.label_Port);
            this.groupBox1.Controls.Add(this.label_Host);
            this.groupBox1.Controls.Add(this.label_notes);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(571, 387);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接信息";
            // 
            // text_Url
            // 
            this.text_Url.Location = new System.Drawing.Point(70, 262);
            this.text_Url.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Url.Name = "text_Url";
            this.text_Url.Size = new System.Drawing.Size(438, 91);
            this.text_Url.TabIndex = 17;
            this.text_Url.Text = "";
            // 
            // label_db
            // 
            this.label_db.AutoSize = true;
            this.label_db.Location = new System.Drawing.Point(-3, 218);
            this.label_db.Name = "label_db";
            this.label_db.Size = new System.Drawing.Size(84, 21);
            this.label_db.TabIndex = 16;
            this.label_db.Text = "数据库:";
            // 
            // text_db
            // 
            this.text_db.Location = new System.Drawing.Point(87, 218);
            this.text_db.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_db.Name = "text_db";
            this.text_db.Size = new System.Drawing.Size(167, 31);
            this.text_db.TabIndex = 15;
            // 
            // text_Host
            // 
            this.text_Host.Location = new System.Drawing.Point(87, 132);
            this.text_Host.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Host.Name = "text_Host";
            this.text_Host.Size = new System.Drawing.Size(167, 31);
            this.text_Host.TabIndex = 13;
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(347, 176);
            this.text_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(175, 31);
            this.text_pass.TabIndex = 11;
            // 
            // text_Port
            // 
            this.text_Port.Location = new System.Drawing.Point(347, 129);
            this.text_Port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Port.Name = "text_Port";
            this.text_Port.Size = new System.Drawing.Size(175, 31);
            this.text_Port.TabIndex = 10;
            this.text_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Port_KeyPress);
            // 
            // text_User
            // 
            this.text_User.Location = new System.Drawing.Point(87, 175);
            this.text_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_User.Name = "text_User";
            this.text_User.Size = new System.Drawing.Size(167, 31);
            this.text_User.TabIndex = 9;
            // 
            // text_notes
            // 
            this.text_notes.Location = new System.Drawing.Point(87, 83);
            this.text_notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_notes.Name = "text_notes";
            this.text_notes.Size = new System.Drawing.Size(438, 31);
            this.text_notes.TabIndex = 8;
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(16, 262);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(54, 21);
            this.label_url.TabIndex = 6;
            this.label_url.Text = "URL:";
            // 
            // comboBox_Type_DB
            // 
            this.comboBox_Type_DB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type_DB.FormattingEnabled = true;
            this.comboBox_Type_DB.Items.AddRange(new object[] {
            "MSSQL",
            "MySQL",
            "Oracle",
            "SQLite",
            "PostgreSQL"});
            this.comboBox_Type_DB.Location = new System.Drawing.Point(347, 34);
            this.comboBox_Type_DB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Type_DB.Name = "comboBox_Type_DB";
            this.comboBox_Type_DB.Size = new System.Drawing.Size(136, 29);
            this.comboBox_Type_DB.TabIndex = 3;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(278, 179);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(63, 21);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "密码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "类型:";
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(-3, 179);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(84, 21);
            this.label_User.TabIndex = 4;
            this.label_User.Text = "用户名:";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(278, 132);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(63, 21);
            this.label_Port.TabIndex = 3;
            this.label_Port.Text = "端口:";
            // 
            // label_Host
            // 
            this.label_Host.AutoSize = true;
            this.label_Host.Location = new System.Drawing.Point(15, 132);
            this.label_Host.Name = "label_Host";
            this.label_Host.Size = new System.Drawing.Size(63, 21);
            this.label_Host.TabIndex = 2;
            this.label_Host.Text = "主机:";
            // 
            // label_notes
            // 
            this.label_notes.AutoSize = true;
            this.label_notes.Location = new System.Drawing.Point(15, 86);
            this.label_notes.Name = "label_notes";
            this.label_notes.Size = new System.Drawing.Size(63, 21);
            this.label_notes.TabIndex = 1;
            this.label_notes.Text = "注释:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(15, 34);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(63, 21);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "名称:";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(205, 408);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(111, 43);
            this.btn_Create.TabIndex = 6;
            this.btn_Create.Text = "创建";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(361, 408);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 43);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(51, 408);
            this.btn_test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(111, 43);
            this.btn_test.TabIndex = 8;
            this.btn_test.Text = "测试连接";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(87, 29);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(167, 31);
            this.text_Name.TabIndex = 18;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 474);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Connection";
            this.Text = "创建新连接";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_Host;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_Port;
        private System.Windows.Forms.TextBox text_User;
        private System.Windows.Forms.TextBox text_notes;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.ComboBox comboBox_Type_DB;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_Host;
        private System.Windows.Forms.Label label_notes;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label label_db;
        private System.Windows.Forms.TextBox text_db;
        private System.Windows.Forms.RichTextBox text_Url;
        private System.Windows.Forms.TextBox text_Name;
    }
}