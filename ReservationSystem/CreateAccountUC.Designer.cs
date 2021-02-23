
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
            this.EmailTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.FirstnameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.UserNameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.LastnameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.PasswordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.NumberTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.SexComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.BirthdatePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(308, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Birthdate";
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
            this.CreateAccountButton.TabIndex = 8;
            this.CreateAccountButton.Text = "Create account";
            this.CreateAccountButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.EmailTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.EmailTextBox.BorderColor = System.Drawing.Color.Silver;
            this.EmailTextBox.BorderSize = 0;
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.EmailTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EmailTextBox.Location = new System.Drawing.Point(299, 127);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.Radius = 10;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(243, 48);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.Text = "Email";
            this.EmailTextBox.TextOffsetX = 10;
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FirstnameTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.FirstnameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.FirstnameTextBox.BorderSize = 0;
            this.FirstnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstnameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.FirstnameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FirstnameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirstnameTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FirstnameTextBox.Location = new System.Drawing.Point(299, 73);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.PasswordChar = '\0';
            this.FirstnameTextBox.Radius = 10;
            this.FirstnameTextBox.SelectedText = "";
            this.FirstnameTextBox.Size = new System.Drawing.Size(119, 48);
            this.FirstnameTextBox.TabIndex = 1;
            this.FirstnameTextBox.Text = "First name";
            this.FirstnameTextBox.TextOffsetX = 10;
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
            this.UserNameTextBox.Location = new System.Drawing.Point(299, 19);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.Radius = 10;
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.Size = new System.Drawing.Size(243, 48);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.Text = "Username";
            this.UserNameTextBox.TextOffsetX = 10;
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.LastnameTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.LastnameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.LastnameTextBox.BorderSize = 0;
            this.LastnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastnameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.LastnameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LastnameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.LastnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LastnameTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LastnameTextBox.Location = new System.Drawing.Point(424, 73);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.PasswordChar = '\0';
            this.LastnameTextBox.Radius = 10;
            this.LastnameTextBox.SelectedText = "";
            this.LastnameTextBox.Size = new System.Drawing.Size(118, 48);
            this.LastnameTextBox.TabIndex = 2;
            this.LastnameTextBox.Text = "Last name";
            this.LastnameTextBox.TextOffsetX = 10;
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
            this.PasswordTextBox.Location = new System.Drawing.Point(299, 181);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.Radius = 10;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(243, 48);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextOffsetX = 10;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.BackColor = System.Drawing.Color.Transparent;
            this.NumberTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.NumberTextBox.BorderColor = System.Drawing.Color.Silver;
            this.NumberTextBox.BorderSize = 0;
            this.NumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.NumberTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NumberTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.NumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumberTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NumberTextBox.Location = new System.Drawing.Point(299, 235);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.PasswordChar = '\0';
            this.NumberTextBox.Radius = 10;
            this.NumberTextBox.SelectedText = "";
            this.NumberTextBox.Size = new System.Drawing.Size(243, 48);
            this.NumberTextBox.TabIndex = 5;
            this.NumberTextBox.Text = "Mobile or phone number";
            this.NumberTextBox.TextOffsetX = 10;
            // 
            // SexComboBox
            // 
            this.SexComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SexComboBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.SexComboBox.BorderColor = System.Drawing.Color.Silver;
            this.SexComboBox.BorderSize = 0;
            this.SexComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SexComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.SexComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SexComboBox.ForeColor = System.Drawing.Color.Black;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexComboBox.Location = new System.Drawing.Point(424, 289);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.SexComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.SexComboBox.Radius = 10;
            this.SexComboBox.Size = new System.Drawing.Size(118, 26);
            this.SexComboBox.TabIndex = 7;
            // 
            // BirthdatePicker
            // 
            this.BirthdatePicker.BackColor = System.Drawing.Color.Transparent;
            this.BirthdatePicker.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.BirthdatePicker.BorderColor = System.Drawing.Color.Silver;
            this.BirthdatePicker.BorderSize = 0;
            this.BirthdatePicker.CustomFormat = "yyyy-MM-dd";
            this.BirthdatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.BirthdatePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.BirthdatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BirthdatePicker.ForeColor = System.Drawing.Color.Black;
            this.BirthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdatePicker.Location = new System.Drawing.Point(299, 289);
            this.BirthdatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthdatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BirthdatePicker.Name = "BirthdatePicker";
            this.BirthdatePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.BirthdatePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.BirthdatePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.BirthdatePicker.OnPressedColor = System.Drawing.Color.Black;
            this.BirthdatePicker.Radius = 10;
            this.BirthdatePicker.Size = new System.Drawing.Size(119, 26);
            this.BirthdatePicker.TabIndex = 6;
            this.BirthdatePicker.Text = "2000-01-01";
            this.BirthdatePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(433, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sex";
            // 
            // CreateAccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BirthdatePicker);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.LastnameTextBox);
            this.Controls.Add(this.FirstnameTextBox);
            this.Name = "CreateAccountUC";
            this.Size = new System.Drawing.Size(841, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton CreateAccountButton;
        private Guna.UI.WinForms.GunaTextBox EmailTextBox;
        private Guna.UI.WinForms.GunaTextBox FirstnameTextBox;
        private Guna.UI.WinForms.GunaTextBox UserNameTextBox;
        private Guna.UI.WinForms.GunaTextBox LastnameTextBox;
        private Guna.UI.WinForms.GunaTextBox PasswordTextBox;
        private Guna.UI.WinForms.GunaTextBox NumberTextBox;
        private Guna.UI.WinForms.GunaComboBox SexComboBox;
        private Guna.UI.WinForms.GunaDateTimePicker BirthdatePicker;
        private System.Windows.Forms.Label label2;
    }
}
