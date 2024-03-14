
namespace bee
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.initializeButton = new Sunny.UI.UIButton();
            this.loginButton = new Sunny.UI.UIButton();
            this.clearButton = new Sunny.UI.UIButton();
            this.usernameText = new Sunny.UI.UITextBox();
            this.passwordText = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tips = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // initializeButton
            // 
            this.initializeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initializeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.initializeButton.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.initializeButton.FillPressColor = System.Drawing.Color.SlateGray;
            this.initializeButton.FillSelectedColor = System.Drawing.Color.SlateGray;
            this.initializeButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.initializeButton.Location = new System.Drawing.Point(60, 144);
            this.initializeButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Radius = 30;
            this.initializeButton.RectHoverColor = System.Drawing.Color.MediumPurple;
            this.initializeButton.RectPressColor = System.Drawing.Color.SlateGray;
            this.initializeButton.RectSelectedColor = System.Drawing.Color.SlateGray;
            this.initializeButton.Size = new System.Drawing.Size(75, 30);
            this.initializeButton.TabIndex = 3;
            this.initializeButton.Text = "初始化";
            this.initializeButton.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.initializeButton.Click += new System.EventHandler(this.initializeButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.loginButton.FillPressColor = System.Drawing.Color.SlateGray;
            this.loginButton.FillSelectedColor = System.Drawing.Color.SlateGray;
            this.loginButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginButton.Location = new System.Drawing.Point(156, 144);
            this.loginButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.loginButton.Name = "loginButton";
            this.loginButton.Radius = 30;
            this.loginButton.RectHoverColor = System.Drawing.Color.MediumPurple;
            this.loginButton.RectPressColor = System.Drawing.Color.SlateGray;
            this.loginButton.RectSelectedColor = System.Drawing.Color.SlateGray;
            this.loginButton.Size = new System.Drawing.Size(75, 30);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登录";
            this.loginButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearButton.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.clearButton.FillPressColor = System.Drawing.Color.SlateGray;
            this.clearButton.FillSelectedColor = System.Drawing.Color.SlateGray;
            this.clearButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearButton.Location = new System.Drawing.Point(248, 144);
            this.clearButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Radius = 30;
            this.clearButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearButton.RectHoverColor = System.Drawing.Color.MediumPurple;
            this.clearButton.RectPressColor = System.Drawing.Color.SlateGray;
            this.clearButton.RectSelectedColor = System.Drawing.Color.SlateGray;
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "清空";
            this.clearButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.usernameText.Location = new System.Drawing.Point(114, 30);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameText.MinimumSize = new System.Drawing.Size(1, 16);
            this.usernameText.Name = "usernameText";
            this.usernameText.Padding = new System.Windows.Forms.Padding(5);
            this.usernameText.ShowText = false;
            this.usernameText.Size = new System.Drawing.Size(209, 30);
            this.usernameText.TabIndex = 1;
            this.usernameText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameText.Watermark = "";
            // 
            // passwordText
            // 
            this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.passwordText.Location = new System.Drawing.Point(114, 73);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordText.MinimumSize = new System.Drawing.Size(1, 16);
            this.passwordText.Name = "passwordText";
            this.passwordText.Padding = new System.Windows.Forms.Padding(5);
            this.passwordText.PasswordChar = '*';
            this.passwordText.ShowText = false;
            this.passwordText.Size = new System.Drawing.Size(209, 30);
            this.passwordText.TabIndex = 2;
            this.passwordText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordText.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(57, 37);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(44, 23);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "账号";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(57, 80);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(44, 23);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tips
            // 
            this.tips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tips.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips.ForeColor = System.Drawing.Color.Red;
            this.tips.Location = new System.Drawing.Point(114, 109);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(209, 22);
            this.tips.TabIndex = 8;
            this.tips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 191);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.initializeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小蜜蜂";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton initializeButton;
        private Sunny.UI.UIButton loginButton;
        private Sunny.UI.UIButton clearButton;
        private Sunny.UI.UITextBox usernameText;
        private Sunny.UI.UITextBox passwordText;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel tips;
    }
}