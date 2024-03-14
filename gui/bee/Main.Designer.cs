
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace bee
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.actionTabControl = new System.Windows.Forms.TabControl();
            this.actionMaterial = new System.Windows.Forms.TabPage();
            this.sendButton = new Sunny.UI.UIButton();
            this.importButton = new Sunny.UI.UIButton();
            this.fileData = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.actionUser = new System.Windows.Forms.TabPage();
            this.Label5comboBox = new Sunny.UI.UIComboBox();
            this.Label4comboBox = new Sunny.UI.UIComboBox();
            this.Label3comboBox = new Sunny.UI.UIComboBox();
            this.Label2comboBox = new Sunny.UI.UIComboBox();
            this.Label1comboBox = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.customernameTextBox = new Sunny.UI.UITextBox();
            this.phoneTextBox = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.statusComboBox = new Sunny.UI.UIComboBox();
            this.saveButton = new Sunny.UI.UIButton();
            this.customButton = new Sunny.UI.UIButton();
            this.customData = new Sunny.UI.UIDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.manageWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.actionTabControl.SuspendLayout();
            this.actionMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileData)).BeginInit();
            this.actionUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageWebView)).BeginInit();
            this.SuspendLayout();
            createWeb();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(865, 634);
            this.webView.Source = new System.Uri("https://web.whatsapp.com/", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // tab1
            // 
            this.tab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Margin = new System.Windows.Forms.Padding(0);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Drawing.Point(0, 0);
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1184, 664);
            this.tab1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.actionTabControl);
            this.tabPage1.Controls.Add(this.webView);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1176, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WhatsApp";
            // 
            // actionTabControl
            // 
            this.actionTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionTabControl.Controls.Add(this.actionMaterial);
            this.actionTabControl.Controls.Add(this.actionUser);
            this.actionTabControl.Location = new System.Drawing.Point(867, 1);
            this.actionTabControl.Name = "actionTabControl";
            this.actionTabControl.SelectedIndex = 0;
            this.actionTabControl.Size = new System.Drawing.Size(313, 633);
            this.actionTabControl.TabIndex = 20;
            this.actionTabControl.SelectedIndexChanged += new System.EventHandler(this.changeTableIndex);
            // 
            // actionMaterial
            // 
            this.actionMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.actionMaterial.Controls.Add(this.sendButton);
            this.actionMaterial.Controls.Add(this.importButton);
            this.actionMaterial.Controls.Add(this.fileData);
            this.actionMaterial.Location = new System.Drawing.Point(4, 29);
            this.actionMaterial.Name = "actionMaterial";
            this.actionMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.actionMaterial.Size = new System.Drawing.Size(305, 600);
            this.actionMaterial.TabIndex = 1;
            this.actionMaterial.Text = "素材管理";
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.sendButton.FillPressColor = System.Drawing.Color.SlateGray;
            this.sendButton.FillSelectedColor = System.Drawing.Color.SlateGray;
            this.sendButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendButton.Location = new System.Drawing.Point(178, 554);
            this.sendButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.sendButton.Name = "sendButton";
            this.sendButton.Radius = 30;
            this.sendButton.RectHoverColor = System.Drawing.Color.MediumPurple;
            this.sendButton.RectPressColor = System.Drawing.Color.SlateGray;
            this.sendButton.RectSelectedColor = System.Drawing.Color.SlateGray;
            this.sendButton.Size = new System.Drawing.Size(100, 35);
            this.sendButton.TabIndex = 23;
            this.sendButton.Text = "群    发";
            this.sendButton.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importButton.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.importButton.FillPressColor = System.Drawing.Color.SlateGray;
            this.importButton.FillSelectedColor = System.Drawing.Color.SlateGray;
            this.importButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importButton.Location = new System.Drawing.Point(30, 554);
            this.importButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.importButton.Name = "importButton";
            this.importButton.Radius = 30;
            this.importButton.RectHoverColor = System.Drawing.Color.MediumPurple;
            this.importButton.RectPressColor = System.Drawing.Color.SlateGray;
            this.importButton.RectSelectedColor = System.Drawing.Color.SlateGray;
            this.importButton.Size = new System.Drawing.Size(100, 35);
            this.importButton.TabIndex = 22;
            this.importButton.Text = "导入素材";
            this.importButton.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // fileData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.fileData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fileData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileData.BackgroundColor = System.Drawing.Color.White;
            this.fileData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fileData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fileData.ColumnHeadersHeight = 32;
            this.fileData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fileData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fileData.DefaultCellStyle = dataGridViewCellStyle3;
            this.fileData.EnableHeadersVisualStyles = false;
            this.fileData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.fileData.Location = new System.Drawing.Point(0, 0);
            this.fileData.Name = "fileData";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fileData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.fileData.RowTemplate.Height = 23;
            this.fileData.SelectedIndex = -1;
            this.fileData.Size = new System.Drawing.Size(305, 536);
            this.fileData.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.fileData.TabIndex = 21;
            this.fileData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fileData_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 156F;
            this.Column1.HeaderText = "文件名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 53F;
            this.Column2.HeaderText = "选中";
            this.Column2.Name = "Column2";
            this.Column2.Width = 53;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 53F;
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column3.HeaderText = "操作";
            this.Column3.Name = "Column3";
            this.Column3.Width = 53;
            // 
            // actionUser
            // 
            this.actionUser.BackColor = System.Drawing.SystemColors.Control;
            this.actionUser.Controls.Add(this.Label5comboBox);
            this.actionUser.Controls.Add(this.Label4comboBox);
            this.actionUser.Controls.Add(this.Label3comboBox);
            this.actionUser.Controls.Add(this.Label2comboBox);
            this.actionUser.Controls.Add(this.Label1comboBox);
            this.actionUser.Controls.Add(this.uiLabel4);
            this.actionUser.Controls.Add(this.customernameTextBox);
            this.actionUser.Controls.Add(this.phoneTextBox);
            this.actionUser.Controls.Add(this.uiLabel3);
            this.actionUser.Controls.Add(this.uiLabel2);
            this.actionUser.Controls.Add(this.uiLabel1);
            this.actionUser.Controls.Add(this.statusComboBox);
            this.actionUser.Controls.Add(this.saveButton);
            this.actionUser.Controls.Add(this.customButton);
            this.actionUser.Controls.Add(this.customData);
            this.actionUser.Location = new System.Drawing.Point(4, 29);
            this.actionUser.Name = "actionUser";
            this.actionUser.Padding = new System.Windows.Forms.Padding(3);
            this.actionUser.Size = new System.Drawing.Size(305, 600);
            this.actionUser.TabIndex = 0;
            this.actionUser.Text = "好友信息";
            // 
            // Label5comboBox
            // 
            this.Label5comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5comboBox.DataSource = null;
            this.Label5comboBox.FillColor = System.Drawing.Color.White;
            this.Label5comboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5comboBox.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.Label5comboBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Label5comboBox.Location = new System.Drawing.Point(98, 480);
            this.Label5comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Label5comboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.Label5comboBox.Name = "Label5comboBox";
            this.Label5comboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Label5comboBox.Radius = 15;
            this.Label5comboBox.Size = new System.Drawing.Size(180, 29);
            this.Label5comboBox.TabIndex = 26;
            this.Label5comboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label5comboBox.Watermark = "";
            // 
            // Label4comboBox
            // 
            this.Label4comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4comboBox.DataSource = null;
            this.Label4comboBox.FillColor = System.Drawing.Color.White;
            this.Label4comboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4comboBox.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.Label4comboBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Label4comboBox.Location = new System.Drawing.Point(98, 445);
            this.Label4comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Label4comboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.Label4comboBox.Name = "Label4comboBox";
            this.Label4comboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Label4comboBox.Radius = 15;
            this.Label4comboBox.Size = new System.Drawing.Size(180, 29);
            this.Label4comboBox.TabIndex = 25;
            this.Label4comboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label4comboBox.Watermark = "";
            // 
            // Label3comboBox
            // 
            this.Label3comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3comboBox.DataSource = null;
            this.Label3comboBox.FillColor = System.Drawing.Color.White;
            this.Label3comboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3comboBox.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.Label3comboBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Label3comboBox.Location = new System.Drawing.Point(98, 411);
            this.Label3comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Label3comboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.Label3comboBox.Name = "Label3comboBox";
            this.Label3comboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Label3comboBox.Radius = 15;
            this.Label3comboBox.Size = new System.Drawing.Size(180, 29);
            this.Label3comboBox.TabIndex = 24;
            this.Label3comboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label3comboBox.Watermark = "";
            // 
            // Label2comboBox
            // 
            this.Label2comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2comboBox.DataSource = null;
            this.Label2comboBox.FillColor = System.Drawing.Color.White;
            this.Label2comboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2comboBox.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.Label2comboBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Label2comboBox.Location = new System.Drawing.Point(98, 375);
            this.Label2comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Label2comboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.Label2comboBox.Name = "Label2comboBox";
            this.Label2comboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Label2comboBox.Radius = 15;
            this.Label2comboBox.Size = new System.Drawing.Size(180, 29);
            this.Label2comboBox.TabIndex = 23;
            this.Label2comboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label2comboBox.Watermark = "";
            // 
            // Label1comboBox
            // 
            this.Label1comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1comboBox.DataSource = null;
            this.Label1comboBox.FillColor = System.Drawing.Color.White;
            this.Label1comboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1comboBox.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.Label1comboBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Label1comboBox.Location = new System.Drawing.Point(98, 339);
            this.Label1comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Label1comboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.Label1comboBox.Name = "Label1comboBox";
            this.Label1comboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Label1comboBox.Radius = 15;
            this.Label1comboBox.Size = new System.Drawing.Size(180, 29);
            this.Label1comboBox.TabIndex = 22;
            this.Label1comboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label1comboBox.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(26, 411);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(43, 24);
            this.uiLabel4.TabIndex = 31;
            this.uiLabel4.Text = "标签";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customernameTextBox
            // 
            this.customernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customernameTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customernameTextBox.Location = new System.Drawing.Point(98, 304);
            this.customernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customernameTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.customernameTextBox.Name = "customernameTextBox";
            this.customernameTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.customernameTextBox.Radius = 15;
            this.customernameTextBox.ShowText = false;
            this.customernameTextBox.Size = new System.Drawing.Size(180, 29);
            this.customernameTextBox.TabIndex = 22;
            this.customernameTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.customernameTextBox.Watermark = "";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneTextBox.Location = new System.Drawing.Point(98, 269);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.phoneTextBox.Radius = 15;
            this.phoneTextBox.ShowText = false;
            this.phoneTextBox.Size = new System.Drawing.Size(180, 29);
            this.phoneTextBox.TabIndex = 21;
            this.phoneTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.phoneTextBox.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(26, 309);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(43, 24);
            this.uiLabel3.TabIndex = 30;
            this.uiLabel3.Text = "名称";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(26, 274);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(43, 24);
            this.uiLabel2.TabIndex = 29;
            this.uiLabel2.Text = "电话";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(26, 522);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(43, 24);
            this.uiLabel1.TabIndex = 28;
            this.uiLabel1.Text = "状态";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.DataSource = null;
            this.statusComboBox.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.statusComboBox.FillColor = System.Drawing.Color.White;
            this.statusComboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusComboBox.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.statusComboBox.Items.AddRange(new object[] {
            "",
            "待发送",
            "已发送"});
            this.statusComboBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.statusComboBox.Location = new System.Drawing.Point(98, 517);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.statusComboBox.Radius = 15;
            this.statusComboBox.Size = new System.Drawing.Size(180, 29);
            this.statusComboBox.TabIndex = 21;
            this.statusComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusComboBox.Watermark = "";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.saveButton.FillPressColor = System.Drawing.Color.SlateGray;
            this.saveButton.FillSelectedColor = System.Drawing.Color.SlateGray;
            this.saveButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(178, 554);
            this.saveButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Radius = 30;
            this.saveButton.RectHoverColor = System.Drawing.Color.MediumPurple;
            this.saveButton.RectPressColor = System.Drawing.Color.SlateGray;
            this.saveButton.RectSelectedColor = System.Drawing.Color.SlateGray;
            this.saveButton.Size = new System.Drawing.Size(100, 35);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "保存信息";
            this.saveButton.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // customButton
            // 
            this.customButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.customButton.FillPressColor = System.Drawing.Color.SlateGray;
            this.customButton.FillSelectedColor = System.Drawing.Color.SlateGray;
            this.customButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customButton.Location = new System.Drawing.Point(30, 554);
            this.customButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.customButton.Name = "customButton";
            this.customButton.Radius = 30;
            this.customButton.RectHoverColor = System.Drawing.Color.MediumPurple;
            this.customButton.RectPressColor = System.Drawing.Color.SlateGray;
            this.customButton.RectSelectedColor = System.Drawing.Color.SlateGray;
            this.customButton.Size = new System.Drawing.Size(100, 35);
            this.customButton.TabIndex = 26;
            this.customButton.Text = "导入好友";
            this.customButton.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // customData
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.customData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.customData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customData.BackgroundColor = System.Drawing.Color.White;
            this.customData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.customData.ColumnHeadersHeight = 32;
            this.customData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customData.DefaultCellStyle = dataGridViewCellStyle8;
            this.customData.EnableHeadersVisualStyles = false;
            this.customData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.customData.Location = new System.Drawing.Point(0, 0);
            this.customData.Name = "customData";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.customData.RowTemplate.Height = 23;
            this.customData.SelectedIndex = -1;
            this.customData.Size = new System.Drawing.Size(305, 259);
            this.customData.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.customData.TabIndex = 21;
            this.customData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customData_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.manageWebView);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "后台设置";
            // 
            // manageWebView
            // 
            this.manageWebView.AllowExternalDrop = true;
            this.manageWebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.manageWebView.CreationProperties = null;
            this.manageWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.manageWebView.Location = new System.Drawing.Point(0, 0);
            this.manageWebView.Name = "manageWebView";
            this.manageWebView.Size = new System.Drawing.Size(1176, 630);
            this.manageWebView.TabIndex = 1;
            this.manageWebView.ZoomFactor = 1D;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 160.7065F;
            this.Column4.HeaderText = "电话";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 54.66209F;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column5.HeaderText = "操作";
            this.Column5.Name = "Column5";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tab1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小蜜蜂";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.actionTabControl.ResumeLayout(false);
            this.actionMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileData)).EndInit();
            this.actionUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private async void createWeb()
        {
            // 自定义保存用户数据
            var cookiesPath = System.IO.Directory.GetCurrentDirectory();
            //if (Login.runMode == 1)
            //{
            //cookiesPath = "\\\\192.168.10.152\\config";
            //}
            var env = await CoreWebView2Environment.CreateAsync(userDataFolder: Path.Combine(cookiesPath, $"WebView2Data/{Login.username}"));
            var result = this.webView.EnsureCoreWebView2Async(env).GetAwaiter();
            var result1 = this.manageWebView.EnsureCoreWebView2Async(env).GetAwaiter();
            result.OnCompleted(() =>
            {
                result.GetResult();
            });
            result1.OnCompleted(() =>
            {
                result1.GetResult();
            });
        }

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Web.WebView2.WinForms.WebView2 manageWebView;
        private System.Windows.Forms.TabControl actionTabControl;
        private System.Windows.Forms.TabPage actionMaterial;
        private System.Windows.Forms.TabPage actionUser;
        private Sunny.UI.UIDataGridView fileData;
        private Sunny.UI.UIButton sendButton;
        private Sunny.UI.UIButton importButton;
        private Sunny.UI.UIDataGridView customData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private Sunny.UI.UIButton customButton;
        private Sunny.UI.UIButton saveButton;
        private Sunny.UI.UIComboBox statusComboBox;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox Label1comboBox;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox customernameTextBox;
        private Sunny.UI.UITextBox phoneTextBox;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox Label5comboBox;
        private Sunny.UI.UIComboBox Label4comboBox;
        private Sunny.UI.UIComboBox Label3comboBox;
        private Sunny.UI.UIComboBox Label2comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}

