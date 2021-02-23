
namespace ReservationSystem
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
            this.UserNameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.PasswordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.LogInButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.RegisterLink = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccountUC1 = new ReservationSystem.CreateAccountUC();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.UserNameTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.UserNameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.UserNameTextBox.BorderSize = 0;
            this.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.UserNameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserNameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.UserNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UserNameTextBox.Location = new System.Drawing.Point(447, 79);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.Radius = 10;
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.Size = new System.Drawing.Size(243, 48);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.Text = "username123";
            this.UserNameTextBox.TextOffsetX = 10;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.BorderSize = 0;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PasswordTextBox.Location = new System.Drawing.Point(447, 140);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.Radius = 10;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(243, 48);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "1233";
            this.PasswordTextBox.TextOffsetX = 10;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // LogInButton
            // 
            this.LogInButton.AnimationHoverSpeed = 0.07F;
            this.LogInButton.AnimationSpeed = 0.03F;
            this.LogInButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.LogInButton.BorderColor = System.Drawing.Color.Black;
            this.LogInButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogInButton.FocusedColor = System.Drawing.Color.Empty;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.Image = null;
            this.LogInButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LogInButton.Location = new System.Drawing.Point(447, 221);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(163)))), ((int)(((byte)(243)))));
            this.LogInButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogInButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LogInButton.OnHoverImage = null;
            this.LogInButton.OnPressedColor = System.Drawing.Color.Black;
            this.LogInButton.Radius = 10;
            this.LogInButton.Size = new System.Drawing.Size(243, 48);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "Sign in";
            this.LogInButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(132, 79);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(204, 100);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Sign in\r\nto Reserve";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(138, 221);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(154, 34);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "If you don\'t have account\r\nYou can";
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RegisterLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.RegisterLink.Location = new System.Drawing.Point(188, 240);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(87, 15);
            this.RegisterLink.TabIndex = 7;
            this.RegisterLink.Text = "Register here!";
            this.RegisterLink.Click += new System.EventHandler(this.RegisterLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(594, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recover password";
            // 
            // createAccountUC1
            // 
            this.createAccountUC1.BackColor = System.Drawing.Color.Transparent;
            this.createAccountUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createAccountUC1.Location = new System.Drawing.Point(0, 0);
            this.createAccountUC1.Name = "createAccountUC1";
            this.createAccountUC1.Size = new System.Drawing.Size(807, 424);
            this.createAccountUC1.TabIndex = 9;
            this.createAccountUC1.Visible = false;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::ReservationSystem.Properties.Resources.Asset_1a;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(12, 335);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(89, 67);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaTransfarantPictureBox1.TabIndex = 6;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 424);
            this.Controls.Add(this.createAccountUC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation System";
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox UserNameTextBox;
        private Guna.UI.WinForms.GunaTextBox PasswordTextBox;
        private Guna.UI.WinForms.GunaButton LogInButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaLabel RegisterLink;
        private System.Windows.Forms.Label label1;
        private CreateAccountUC createAccountUC1;
    }
}

