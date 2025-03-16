namespace odev1gorsel
{
    partial class RegisterForm
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
            lblNewUsername = new Label();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            lblRegisterMessage = new Label();
            SuspendLayout();
            // 
            // lblNewUsername
            // 
            lblNewUsername.AutoSize = true;
            lblNewUsername.Location = new Point(80, 37);
            lblNewUsername.Name = "lblNewUsername";
            lblNewUsername.Size = new Size(95, 20);
            lblNewUsername.TabIndex = 0;
            lblNewUsername.Text = "Kullanıcı Adı:";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(208, 30);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(125, 27);
            txtNewUsername.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(208, 63);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(125, 27);
            txtNewPassword.TabIndex = 2;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(80, 70);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(42, 20);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "Şifre:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(80, 105);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(73, 20);
            lblRole.TabIndex = 4;
            lblRole.Text = "Rol Seçin:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "User", "Admin" });
            cmbRole.Location = new Point(208, 97);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 28);
            cmbRole.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(208, 131);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblRegisterMessage
            // 
            lblRegisterMessage.AutoSize = true;
            lblRegisterMessage.ForeColor = Color.Red;
            lblRegisterMessage.Location = new Point(30, 150);
            lblRegisterMessage.Name = "lblRegisterMessage";
            lblRegisterMessage.Size = new Size(0, 20);
            lblRegisterMessage.TabIndex = 5;
            lblRegisterMessage.Visible = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegisterMessage);
            Controls.Add(btnRegister);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Controls.Add(lblNewUsername);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblRegisterMessage;

        private Label lblNewUsername;
        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnRegister;
    }
}