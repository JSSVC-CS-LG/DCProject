namespace DCApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.accountLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.accountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.accountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountLabelControl
            // 
            this.accountLabelControl.Location = new System.Drawing.Point(141, 84);
            this.accountLabelControl.Name = "accountLabelControl";
            this.accountLabelControl.Size = new System.Drawing.Size(24, 14);
            this.accountLabelControl.TabIndex = 0;
            this.accountLabelControl.Text = "账号";
            // 
            // accountTextEdit
            // 
            this.accountTextEdit.Location = new System.Drawing.Point(185, 83);
            this.accountTextEdit.Name = "accountTextEdit";
            this.accountTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.accountTextEdit.Properties.NullValuePrompt = "用户名或手机号";
            this.accountTextEdit.Size = new System.Drawing.Size(146, 20);
            this.accountTextEdit.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Snow;
            this.panelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cancelButton);
            this.panelControl1.Controls.Add(this.loginButton);
            this.panelControl1.Controls.Add(this.passwordTextEdit);
            this.panelControl1.Controls.Add(this.passwordLabelControl);
            this.panelControl1.Controls.Add(this.accountTextEdit);
            this.panelControl1.Controls.Add(this.accountLabelControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(483, 301);
            this.panelControl1.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(249, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "退出";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
            this.loginButton.Location = new System.Drawing.Point(150, 189);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "登录";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(185, 129);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.passwordTextEdit.Properties.NullValuePrompt = "密码";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Properties.ShowNullValuePromptWhenFocused = true;
            this.passwordTextEdit.Size = new System.Drawing.Size(146, 20);
            this.passwordTextEdit.TabIndex = 1;
            // 
            // passwordLabelControl
            // 
            this.passwordLabelControl.Location = new System.Drawing.Point(141, 130);
            this.passwordLabelControl.Name = "passwordLabelControl";
            this.passwordLabelControl.Size = new System.Drawing.Size(24, 14);
            this.passwordLabelControl.TabIndex = 0;
            this.passwordLabelControl.Text = "密码";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 307);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.BackColor2 = System.Drawing.Color.Snow;
            this.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.accountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl accountLabelControl;
        private DevExpress.XtraEditors.TextEdit accountTextEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.LabelControl passwordLabelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}