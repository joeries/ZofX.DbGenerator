namespace ZofX.DbGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnConn = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.txtModelSaveFolderName = new System.Windows.Forms.TextBox();
            this.pnlSql = new System.Windows.Forms.Panel();
            this.txtSqlServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSqlPwd = new System.Windows.Forms.TextBox();
            this.btnUnConnSql = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSqlDb = new System.Windows.Forms.TextBox();
            this.txtSqlUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnConnSql = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDbDic = new System.Windows.Forms.Button();
            this.txtDbDicSaveFilePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlOracle = new System.Windows.Forms.Panel();
            this.txtOraclePwd = new System.Windows.Forms.TextBox();
            this.btnUnConnOracle = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOracleServer = new System.Windows.Forms.TextBox();
            this.txtOracleUser = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConnOracle = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelConnType = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOleDb = new System.Windows.Forms.Panel();
            this.txtOleDbPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOlePwd = new System.Windows.Forms.TextBox();
            this.btnConnOleDb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnConnOleDb = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblPercentProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.pnlSql.SuspendLayout();
            this.pnlOracle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlOleDb.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUnConn);
            this.groupBox2.Controls.Add(this.btnModel);
            this.groupBox2.Controls.Add(this.txtModelSaveFolderName);
            this.groupBox2.Controls.Add(this.pnlSql);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnDbDic);
            this.groupBox2.Controls.Add(this.txtDbDicSaveFilePath);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.pnlOracle);
            this.groupBox2.Location = new System.Drawing.Point(318, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 290);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成";
            // 
            // btnUnConn
            // 
            this.btnUnConn.Location = new System.Drawing.Point(240, 242);
            this.btnUnConn.Name = "btnUnConn";
            this.btnUnConn.Size = new System.Drawing.Size(69, 25);
            this.btnUnConn.TabIndex = 18;
            this.btnUnConn.Text = "断开连接";
            this.btnUnConn.UseVisualStyleBackColor = true;
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(240, 132);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(69, 25);
            this.btnModel.TabIndex = 9;
            this.btnModel.Text = "开始生成";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // txtModelSaveFolderName
            // 
            this.txtModelSaveFolderName.Location = new System.Drawing.Point(71, 135);
            this.txtModelSaveFolderName.Name = "txtModelSaveFolderName";
            this.txtModelSaveFolderName.ReadOnly = true;
            this.txtModelSaveFolderName.Size = new System.Drawing.Size(163, 21);
            this.txtModelSaveFolderName.TabIndex = 7;
            // 
            // pnlSql
            // 
            this.pnlSql.Controls.Add(this.txtSqlServer);
            this.pnlSql.Controls.Add(this.label6);
            this.pnlSql.Controls.Add(this.txtSqlPwd);
            this.pnlSql.Controls.Add(this.btnUnConnSql);
            this.pnlSql.Controls.Add(this.label4);
            this.pnlSql.Controls.Add(this.txtSqlDb);
            this.pnlSql.Controls.Add(this.txtSqlUser);
            this.pnlSql.Controls.Add(this.label14);
            this.pnlSql.Controls.Add(this.btnConnSql);
            this.pnlSql.Controls.Add(this.label15);
            this.pnlSql.Location = new System.Drawing.Point(6, 273);
            this.pnlSql.Name = "pnlSql";
            this.pnlSql.Size = new System.Drawing.Size(260, 153);
            this.pnlSql.TabIndex = 3;
            this.pnlSql.Visible = false;
            // 
            // txtSqlServer
            // 
            this.txtSqlServer.Location = new System.Drawing.Point(69, 3);
            this.txtSqlServer.Name = "txtSqlServer";
            this.txtSqlServer.Size = new System.Drawing.Size(135, 21);
            this.txtSqlServer.TabIndex = 1;
            this.txtSqlServer.Text = ".\\SqlExpress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "服务器：";
            // 
            // txtSqlPwd
            // 
            this.txtSqlPwd.Location = new System.Drawing.Point(69, 88);
            this.txtSqlPwd.Name = "txtSqlPwd";
            this.txtSqlPwd.PasswordChar = '*';
            this.txtSqlPwd.Size = new System.Drawing.Size(135, 21);
            this.txtSqlPwd.TabIndex = 6;
            this.txtSqlPwd.Text = "123456";
            // 
            // btnUnConnSql
            // 
            this.btnUnConnSql.Enabled = false;
            this.btnUnConnSql.Location = new System.Drawing.Point(135, 114);
            this.btnUnConnSql.Name = "btnUnConnSql";
            this.btnUnConnSql.Size = new System.Drawing.Size(69, 25);
            this.btnUnConnSql.TabIndex = 13;
            this.btnUnConnSql.Text = "断开连接";
            this.btnUnConnSql.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "密  码：";
            // 
            // txtSqlDb
            // 
            this.txtSqlDb.Location = new System.Drawing.Point(69, 30);
            this.txtSqlDb.Name = "txtSqlDb";
            this.txtSqlDb.Size = new System.Drawing.Size(135, 21);
            this.txtSqlDb.TabIndex = 4;
            this.txtSqlDb.Text = "PrivateInfoDb";
            // 
            // txtSqlUser
            // 
            this.txtSqlUser.Location = new System.Drawing.Point(69, 59);
            this.txtSqlUser.Name = "txtSqlUser";
            this.txtSqlUser.Size = new System.Drawing.Size(135, 21);
            this.txtSqlUser.TabIndex = 5;
            this.txtSqlUser.Text = "sa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "用户名：";
            // 
            // btnConnSql
            // 
            this.btnConnSql.Location = new System.Drawing.Point(60, 114);
            this.btnConnSql.Name = "btnConnSql";
            this.btnConnSql.Size = new System.Drawing.Size(69, 25);
            this.btnConnSql.TabIndex = 8;
            this.btnConnSql.Text = "启动连接";
            this.btnConnSql.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "数据库：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "实体逻辑：";
            // 
            // btnDbDic
            // 
            this.btnDbDic.Location = new System.Drawing.Point(240, 42);
            this.btnDbDic.Name = "btnDbDic";
            this.btnDbDic.Size = new System.Drawing.Size(69, 25);
            this.btnDbDic.TabIndex = 4;
            this.btnDbDic.Text = "开始生成";
            this.btnDbDic.UseVisualStyleBackColor = true;
            this.btnDbDic.Click += new System.EventHandler(this.btnDbDic_Click);
            // 
            // txtDbDicSaveFilePath
            // 
            this.txtDbDicSaveFilePath.Location = new System.Drawing.Point(71, 45);
            this.txtDbDicSaveFilePath.Name = "txtDbDicSaveFilePath";
            this.txtDbDicSaveFilePath.ReadOnly = true;
            this.txtDbDicSaveFilePath.Size = new System.Drawing.Size(163, 21);
            this.txtDbDicSaveFilePath.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "数据字典：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "保存路径：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "保存路径：";
            // 
            // pnlOracle
            // 
            this.pnlOracle.Controls.Add(this.txtOraclePwd);
            this.pnlOracle.Controls.Add(this.btnUnConnOracle);
            this.pnlOracle.Controls.Add(this.label16);
            this.pnlOracle.Controls.Add(this.txtOracleServer);
            this.pnlOracle.Controls.Add(this.txtOracleUser);
            this.pnlOracle.Controls.Add(this.label17);
            this.pnlOracle.Controls.Add(this.btnConnOracle);
            this.pnlOracle.Controls.Add(this.label18);
            this.pnlOracle.Location = new System.Drawing.Point(272, 273);
            this.pnlOracle.Name = "pnlOracle";
            this.pnlOracle.Size = new System.Drawing.Size(257, 144);
            this.pnlOracle.TabIndex = 5;
            this.pnlOracle.Visible = false;
            // 
            // txtOraclePwd
            // 
            this.txtOraclePwd.Location = new System.Drawing.Point(70, 63);
            this.txtOraclePwd.Name = "txtOraclePwd";
            this.txtOraclePwd.PasswordChar = '*';
            this.txtOraclePwd.Size = new System.Drawing.Size(135, 21);
            this.txtOraclePwd.TabIndex = 6;
            // 
            // btnUnConnOracle
            // 
            this.btnUnConnOracle.Enabled = false;
            this.btnUnConnOracle.Location = new System.Drawing.Point(135, 90);
            this.btnUnConnOracle.Name = "btnUnConnOracle";
            this.btnUnConnOracle.Size = new System.Drawing.Size(69, 25);
            this.btnUnConnOracle.TabIndex = 13;
            this.btnUnConnOracle.Text = "断开连接";
            this.btnUnConnOracle.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 7;
            this.label16.Text = "密  码：";
            // 
            // txtOracleServer
            // 
            this.txtOracleServer.Location = new System.Drawing.Point(69, 6);
            this.txtOracleServer.Name = "txtOracleServer";
            this.txtOracleServer.Size = new System.Drawing.Size(135, 21);
            this.txtOracleServer.TabIndex = 4;
            // 
            // txtOracleUser
            // 
            this.txtOracleUser.Location = new System.Drawing.Point(69, 35);
            this.txtOracleUser.Name = "txtOracleUser";
            this.txtOracleUser.Size = new System.Drawing.Size(135, 21);
            this.txtOracleUser.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "用户名：";
            // 
            // btnConnOracle
            // 
            this.btnConnOracle.Location = new System.Drawing.Point(60, 90);
            this.btnConnOracle.Name = "btnConnOracle";
            this.btnConnOracle.Size = new System.Drawing.Size(69, 25);
            this.btnConnOracle.TabIndex = 7;
            this.btnConnOracle.Text = "启动连接";
            this.btnConnOracle.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "服务名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanelConnType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pnlOleDb);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库连接";
            // 
            // flowLayoutPanelConnType
            // 
            this.flowLayoutPanelConnType.Location = new System.Drawing.Point(30, 42);
            this.flowLayoutPanelConnType.Name = "flowLayoutPanelConnType";
            this.flowLayoutPanelConnType.Size = new System.Drawing.Size(259, 69);
            this.flowLayoutPanelConnType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "数据库参数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据库类型：";
            // 
            // pnlOleDb
            // 
            this.pnlOleDb.Controls.Add(this.txtOleDbPath);
            this.pnlOleDb.Controls.Add(this.label3);
            this.pnlOleDb.Controls.Add(this.txtOlePwd);
            this.pnlOleDb.Controls.Add(this.btnConnOleDb);
            this.pnlOleDb.Controls.Add(this.label5);
            this.pnlOleDb.Controls.Add(this.btnUnConnOleDb);
            this.pnlOleDb.Location = new System.Drawing.Point(10, 135);
            this.pnlOleDb.Name = "pnlOleDb";
            this.pnlOleDb.Size = new System.Drawing.Size(279, 112);
            this.pnlOleDb.TabIndex = 1;
            this.pnlOleDb.Visible = false;
            // 
            // txtOleDbPath
            // 
            this.txtOleDbPath.Location = new System.Drawing.Point(54, 10);
            this.txtOleDbPath.Name = "txtOleDbPath";
            this.txtOleDbPath.Size = new System.Drawing.Size(150, 21);
            this.txtOleDbPath.TabIndex = 1;
            this.txtOleDbPath.Enter += new System.EventHandler(this.txtOleDbPath_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "路径：";
            // 
            // txtOlePwd
            // 
            this.txtOlePwd.Location = new System.Drawing.Point(54, 47);
            this.txtOlePwd.Name = "txtOlePwd";
            this.txtOlePwd.PasswordChar = '*';
            this.txtOlePwd.Size = new System.Drawing.Size(150, 21);
            this.txtOlePwd.TabIndex = 2;
            // 
            // btnConnOleDb
            // 
            this.btnConnOleDb.Location = new System.Drawing.Point(61, 76);
            this.btnConnOleDb.Name = "btnConnOleDb";
            this.btnConnOleDb.Size = new System.Drawing.Size(69, 25);
            this.btnConnOleDb.TabIndex = 3;
            this.btnConnOleDb.Text = "启动连接";
            this.btnConnOleDb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "密码：";
            // 
            // btnUnConnOleDb
            // 
            this.btnUnConnOleDb.Enabled = false;
            this.btnUnConnOleDb.Location = new System.Drawing.Point(136, 75);
            this.btnUnConnOleDb.Name = "btnUnConnOleDb";
            this.btnUnConnOleDb.Size = new System.Drawing.Size(69, 25);
            this.btnUnConnOleDb.TabIndex = 4;
            this.btnUnConnOleDb.Text = "断开连接";
            this.btnUnConnOleDb.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbBar,
            this.lblPercentProgress,
            this.lblState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbBar
            // 
            this.pbBar.Name = "pbBar";
            this.pbBar.Size = new System.Drawing.Size(100, 16);
            // 
            // lblPercentProgress
            // 
            this.lblPercentProgress.Name = "lblPercentProgress";
            this.lblPercentProgress.Size = new System.Drawing.Size(23, 17);
            this.lblPercentProgress.Tag = "{0}/{1}";
            this.lblPercentProgress.Text = "0/0";
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(29, 17);
            this.lblState.Text = "就绪";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 328);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(654, 355);
            this.MinimumSize = new System.Drawing.Size(654, 355);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZofX.DbGenerator 1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlSql.ResumeLayout(false);
            this.pnlSql.PerformLayout();
            this.pnlOracle.ResumeLayout(false);
            this.pnlOracle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlOleDb.ResumeLayout(false);
            this.pnlOleDb.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.TextBox txtModelSaveFolderName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDbDic;
        private System.Windows.Forms.TextBox txtDbDicSaveFilePath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlOleDb;
        private System.Windows.Forms.TextBox txtOleDbPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOlePwd;
        private System.Windows.Forms.Button btnConnOleDb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnConnOleDb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbBar;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConnType;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel lblPercentProgress;
        private System.Windows.Forms.Panel pnlSql;
        private System.Windows.Forms.TextBox txtSqlPwd;
        private System.Windows.Forms.Button btnUnConnSql;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSqlDb;
        private System.Windows.Forms.TextBox txtSqlUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnConnSql;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlOracle;
        private System.Windows.Forms.TextBox txtOraclePwd;
        private System.Windows.Forms.Button btnUnConnOracle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOracleServer;
        private System.Windows.Forms.TextBox txtOracleUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnConnOracle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSqlServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUnConn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

