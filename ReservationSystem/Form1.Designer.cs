
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
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BaseColor = System.Drawing.Color.White;
            this.UserNameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.UserNameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserNameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.UserNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserNameTextBox.Location = new System.Drawing.Point(260, 79);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.Size = new System.Drawing.Size(243, 30);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.Text = "username , email, or number";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BaseColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBox.Location = new System.Drawing.Point(260, 115);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(243, 30);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "password";
            // 
            // LogInButton
            // 
            this.LogInButton.AnimationHoverSpeed = 0.07F;
            this.LogInButton.AnimationSpeed = 0.03F;
            this.LogInButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LogInButton.BorderColor = System.Drawing.Color.Black;
            this.LogInButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogInButton.FocusedColor = System.Drawing.Color.Empty;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.Image = ((System.Drawing.Image)(resources.GetObject("LogInButton.Image")));
            this.LogInButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LogInButton.Location = new System.Drawing.Point(343, 151);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LogInButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogInButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LogInButton.OnHoverImage = null;
            this.LogInButton.OnPressedColor = System.Drawing.Color.Black;
            this.LogInButton.Radius = 20;
            this.LogInButton.Size = new System.Drawing.Size(160, 42);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "Sign in";
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 424);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox UserNameTextBox;
        private Guna.UI.WinForms.GunaTextBox PasswordTextBox;
        private Guna.UI.WinForms.GunaButton LogInButton;
    }
}

