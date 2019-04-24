using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZofX.DbGenerator.Model;
using ZofX.DbGenerator.Core;
using System.Threading;
using System.Text.RegularExpressions;

namespace ZofX.DbGenerator
{
    public partial class FormMain : Form
    {
        TplExporter exporter = new TplExporter();
        DbDicManager dbManager;

        public FormMain()
        {
            InitializeComponent();

            exporter.OnExport += new Action<object, TplExporter.ExportEventArgs>(exporter_OnExport);
        }

        private void exporter_OnExport(object sender, TplExporter.ExportEventArgs e)
        {
            this.Invoke(new Action(delegate()
            {
                lblState.Text = e.Info;
                lblPercentProgress.Text = string.Format(lblPercentProgress.Tag.ToString(), e.NowIndex, e.TotalNum);
                if (e.NowIndex > 0 && e.TotalNum > 0)
                {
                    pbBar.Value = (int)(Math.Round(e.NowIndex * 1.0 / e.TotalNum, 2) * 100);
                }

                if (e.IsFinished)
                {
                    lblPercentProgress.Text = "100%";
                    btnDbDic.Enabled = true;
                    btnModel.Enabled = true;
                    btnUnConn.Enabled = true;
                }                
            }));
        }

        private void dbManager_OnConn(object sender, DbDicManager.ConnEventArgs e)
        {
            this.Invoke(new Action(delegate()
                {
                    lblState.Text = e.Info;
                    lblPercentProgress.Text = string.Format(lblPercentProgress.Tag.ToString(), e.NowIndex, e.TotalNum);
                    if (e.NowIndex > 0 && e.TotalNum > 0)
                    {
                        pbBar.Value = (int)(Math.Round(e.NowIndex * 1.0 / e.TotalNum, 2) * 100);
                    }

                    if (e.IsFinished)
                    {
                        lblPercentProgress.Text = "100%";
                    }
                }));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.CloseConn();

            groupBox2.Controls.Remove(pnlOracle);
            groupBox2.Controls.Remove(pnlSql);
            groupBox1.Controls.Add(pnlOracle);
            groupBox1.Controls.Add(pnlSql);

            for (Enums.EnumConnType connType = Enums.EnumConnType.OleDb;
                connType <= Enums.EnumConnType.Oracle;
                connType++)
            {
                RadioButton radio = new RadioButton();
                radio.Text = connType.ToString();
                radio.CheckedChanged += new EventHandler(radio_CheckedChanged);
                radio.Height = 25;
                radio.Width = 80;
                flowLayoutPanelConnType.Controls.Add(radio);
                if (connType == Enums.EnumConnType.MsSql2008)
                {
                    radio.Checked = true;
                }
            }

            btnConnOleDb.Click += new EventHandler(btnConn_Click);
            btnConnSql.Click += new EventHandler(btnConn_Click);
            btnConnOracle.Click += new EventHandler(btnConn_Click);

            btnUnConnOleDb.Click += new EventHandler(btnUnConn_Click);
            btnUnConnSql.Click += new EventHandler(btnUnConn_Click);
            btnUnConnOracle.Click += new EventHandler(btnUnConn_Click);
            btnUnConn.Click += new EventHandler(btnUnConn_Click);
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            switch (Config.ConnType)
            {
                case Enums.EnumConnType.OleDb:
                    Config.ConnStr = string.Format("Provider=microsoft.jet.oledb.4.0;Data Source={0};Jet OleDb:DataBase Password='{1}';", txtOleDbPath.Text.Trim(), txtOlePwd.Text.Trim());
                    Config.DatabaseName = txtOleDbPath.Text.Trim();
                    Config.DatabaseName = Config.DatabaseName.Substring(Config.DatabaseName.LastIndexOf('\\') + 1);
                    break;
                case Enums.EnumConnType.Oracle:
                    Config.ConnStr = string.Format("data source={0};uid={1};pwd={2}", txtOracleServer.Text.Trim(), txtOracleUser.Text.Trim(), txtOraclePwd.Text.Trim());
                    Config.DatabaseName = txtOracleServer.Text.Trim();
                    break;
                case Enums.EnumConnType.MySql:
                    Regex regex = new Regex(@"(.+):(\d+)");
                    string server = txtSqlServer.Text.Trim();
                    string port = "3306";
                    Match m = regex.Match(server);
                    if (m.Success)
                    {
                        server = m.Groups[1].Value;
                        port= m.Groups[2].Value;
                    }
                    Config.ConnStr = string.Format("host={0};port={1};database={2};uid={3};pwd={4}", server, port, txtSqlDb.Text.Trim(), txtSqlUser.Text.Trim(), txtSqlPwd.Text.Trim());
                    Config.DatabaseName = txtSqlDb.Text.Trim();
                    break;
                default:
                    Config.ConnStr = string.Format("data source={0};Initial Catalog={1};uid={2};pwd={3}", txtSqlServer.Text.Trim(), txtSqlDb.Text.Trim(), txtSqlUser.Text.Trim(), txtSqlPwd.Text.Trim());
                    Config.DatabaseName = txtSqlDb.Text.Trim();
                    break;
            }            

            Config.ConnState = Enums.EnumConnState.Open;
            this.OpenConn();

            try
            {
                dbManager = new DbDicManager(Config.ConnType.Value, Config.ConnStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.btnUnConn_Click(this, null);
                return;
            }
            
            dbManager.OnConn += new Action<object, DbDicManager.ConnEventArgs>(dbManager_OnConn);
        }

        private void btnUnConn_Click(object sender, EventArgs e)
        {
            Config.ConnState = Enums.EnumConnState.Closed;
            this.CloseConn();

            if (null != Config.DbSchema)
            {
                Config.DbSchema.Clear();
            }
            Config.DbSchema = null;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                Enums.EnumConnType connType = (Enums.EnumConnType)Enum.Parse(typeof(Enums.EnumConnType), radio.Text);
                Config.ConnState = Enums.EnumConnState.Closed;
                Config.ConnType = connType;

                switch (connType)
                {
                    case Enums.EnumConnType.OleDb:
                        pnlOleDb.Visible = true;
                        pnlSql.Visible = false;
                        pnlOracle.Visible = false;
                        this.AcceptButton = btnConnOleDb;
                        break;
                    case Enums.EnumConnType.Oracle:
                        pnlOleDb.Visible = false;
                        pnlSql.Visible = false;
                        pnlOracle.Visible = true;
                        pnlOracle.Location = pnlOleDb.Location;
                        this.AcceptButton = btnConnOracle;
                        break;
                    default:
                        pnlOleDb.Visible = false;
                        pnlSql.Visible = true;
                        pnlOracle.Visible = false;
                        pnlSql.Location = pnlOleDb.Location;
                        this.AcceptButton = btnConnSql;
                        break;
                }
            }
        }

        private void OpenConn()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void CloseConn()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void btnDbDic_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".html";
            saveFileDialog1.FileName = Config.DatabaseName + ".html";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string filePath = saveFileDialog1.FileName;
                txtDbDicSaveFilePath.Text = filePath;
                
                btnDbDic.Enabled = false;
                btnModel.Enabled = false;
                btnUnConn.Enabled = false;

                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object obj)
                {
                    if (null == Config.DbSchema)
                    {
                        Config.DbSchema = dbManager.GetTables("");
                    }
                    exporter.ExportDbDic(Config.DatabaseName, Config.DbSchema, filePath);
                }));
            }
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                txtModelSaveFolderName.Text = folderPath;
                folderPath = folderPath.TrimEnd('\\');
                folderPath += "\\";
                
                btnDbDic.Enabled = false;
                btnModel.Enabled = false;
                btnUnConn.Enabled = false;

                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object obj)
                {
                    if (null == Config.DbSchema)
                    {
                        Config.DbSchema = dbManager.GetTables("");
                    }
                    exporter.ExportModel(Config.DatabaseName, Config.DbSchema, folderPath);
                }));
            }
        }

        private void txtOleDbPath_Enter(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                txtOleDbPath.Text = openFileDialog1.FileName;
            }
        }
    }
}