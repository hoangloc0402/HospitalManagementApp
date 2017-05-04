namespace HospitalManagementApp
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
            this.loginButton = new System.Windows.Forms.Button();
            this.textEditorName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.textEditorPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.textEditorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(496, 264);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(114, 38);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textEditorName
            // 
            this.textEditorName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013;
            this.textEditorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textEditorName.Location = new System.Drawing.Point(421, 174);
            this.textEditorName.Name = "textEditorName";
            this.textEditorName.Size = new System.Drawing.Size(189, 28);
            this.textEditorName.TabIndex = 1;
            this.textEditorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditorName_KeyDown);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ultraLabel1.Location = new System.Drawing.Point(326, 179);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(89, 23);
            this.ultraLabel1.TabIndex = 2;
            this.ultraLabel1.Text = "Tài khoản";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ultraLabel2.Location = new System.Drawing.Point(326, 226);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(77, 23);
            this.ultraLabel2.TabIndex = 3;
            this.ultraLabel2.Text = "Mật khẩu";
            // 
            // textEditorPassword
            // 
            this.textEditorPassword.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013;
            this.textEditorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textEditorPassword.Location = new System.Drawing.Point(421, 221);
            this.textEditorPassword.Name = "textEditorPassword";
            this.textEditorPassword.PasswordChar = '●';
            this.textEditorPassword.Size = new System.Drawing.Size(189, 28);
            this.textEditorPassword.TabIndex = 4;
            this.textEditorPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditorPassword_KeyDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.textEditorPassword);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.textEditorName);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Hopital Management";
            ((System.ComponentModel.ISupportInitialize)(this.textEditorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditorPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor textEditorName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor textEditorPassword;
    }
}