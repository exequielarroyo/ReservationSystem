
namespace ReservationSystem
{
    partial class CreateAccountUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccountButton = new Guna.UI.WinForms.GunaButton();
            this.PasswordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.UserNameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(446, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recover password";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.AnimationHoverSpeed = 0.07F;
            this.CreateAccountButton.AnimationSpeed = 0.03F;
            this.CreateAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.CreateAccountButton.BorderColor = System.Drawing.Color.Black;
            this.CreateAccountButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateAccountButton.FocusedColor = System.Drawing.Color.Empty;
            this.CreateAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateAccountButton.ForeColor = System.Drawing.Color.White;
            this.CreateAccountButton.Image = null;
            this.CreateAccountButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CreateAccountButton.Location = new System.Drawing.Point(299, 364);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(163)))), ((int)(((byte)(243)))));
            this.CreateAccountButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CreateAccountButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CreateAccountButton.OnHoverImage = null;
            this.CreateAccountButton.OnPressedColor = System.Drawing.Color.Black;
            this.CreateAccountButton.Radius = 10;
            this.CreateAccountButton.Size = new System.Drawing.Size(243, 48);
            this.CreateAccountButton.TabIndex = 11;
            this.CreateAccountButton.Text = "Create account";
            this.CreateAccountButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
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
            this.PasswordTextBox.Location = new System.Drawing.Point(299, 127);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.Radius = 10;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(243, 48);
            this.PasswordTextBox.TabIndex = 10;
            this.PasswordTextBox.Text = "Email";
            this.PasswordTextBox.TextOffsetX = 10;
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
            this.UserNameTextBox.Location = new System.Drawing.Point(299, 73);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.Radius = 10;
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.Size = new System.Drawing.Size(119, 48);
            this.UserNameTextBox.TabIndex = 9;
            this.UserNameTextBox.Text = "First name";
            this.UserNameTextBox.TextOffsetX = 10;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 0;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gunaTextBox1.Location = new System.Drawing.Point(299, 19);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(243, 48);
            this.gunaTextBox1.TabIndex = 9;
            this.gunaTextBox1.Text = "Username";
            this.gunaTextBox1.TextOffsetX = 10;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.BorderSize = 0;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gunaTextBox2.Location = new System.Drawing.Point(424, 73);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(118, 48);
            this.gunaTextBox2.TabIndex = 9;
            this.gunaTextBox2.Text = "Last name";
            this.gunaTextBox2.TextOffsetX = 10;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.BorderSize = 0;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gunaTextBox3.Location = new System.Drawing.Point(299, 181);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(243, 48);
            this.gunaTextBox3.TabIndex = 10;
            this.gunaTextBox3.Text = "Password";
            this.gunaTextBox3.TextOffsetX = 10;
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.BorderSize = 0;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gunaTextBox4.Location = new System.Drawing.Point(299, 235);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 10;
            this.gunaTextBox4.SelectedText = "";
            this.gunaTextBox4.Size = new System.Drawing.Size(243, 48);
            this.gunaTextBox4.TabIndex = 10;
            this.gunaTextBox4.Text = "Mobile or phone number";
            this.gunaTextBox4.TextOffsetX = 10;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.BorderSize = 0;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gunaComboBox1.Location = new System.Drawing.Point(421, 289);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 10;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox1.TabIndex = 13;
            // 
            // CreateAccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.gunaTextBox4);
            this.Controls.Add(this.gunaTextBox3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.UserNameTextBox);
            this.Name = "CreateAccountUC";
            this.Size = new System.Drawing.Size(841, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton CreateAccountButton;
        private Guna.UI.WinForms.GunaTextBox PasswordTextBox;
        private Guna.UI.WinForms.GunaTextBox UserNameTextBox;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox4;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
    }
}
