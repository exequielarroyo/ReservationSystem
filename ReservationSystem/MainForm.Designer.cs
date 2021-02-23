
namespace ReservationSystem
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FirstNameTextBox = new Guna.UI.WinForms.GunaLabel();
            this.StatusComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.SaveButton = new Guna.UI.WinForms.GunaButton();
            this.RoomNumberTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.PersonCountNumeric = new Guna.UI.WinForms.GunaNumeric();
            this.PriceTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.DetailsTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.DeleteButton = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RoomDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddButton = new Guna.UI.WinForms.GunaButton();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.SignOutButton = new Guna.UI.WinForms.GunaLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGrid)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.AutoSize = true;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(703, 0);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(68, 15);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Text = "gunaLabel1";
            this.FirstNameTextBox.LocationChanged += new System.EventHandler(this.FirstNameTextBox_LocationChanged);
            this.FirstNameTextBox.Click += new System.EventHandler(this.FirstNameTextBox_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusComboBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.StatusComboBox.BorderColor = System.Drawing.Color.Silver;
            this.StatusComboBox.BorderSize = 0;
            this.tableLayoutPanel1.SetColumnSpan(this.StatusComboBox, 2);
            this.StatusComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusComboBox.ForeColor = System.Drawing.Color.Black;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Available",
            "Reserved"});
            this.StatusComboBox.Location = new System.Drawing.Point(3, 203);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.StatusComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.StatusComboBox.Radius = 10;
            this.StatusComboBox.Size = new System.Drawing.Size(294, 26);
            this.StatusComboBox.TabIndex = 11;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.AnimationHoverSpeed = 0.07F;
            this.SaveButton.AnimationSpeed = 0.03F;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.SaveButton.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Image = null;
            this.SaveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveButton.Location = new System.Drawing.Point(3, 403);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(163)))), ((int)(((byte)(243)))));
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveButton.OnHoverImage = null;
            this.SaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButton.Radius = 10;
            this.SaveButton.Size = new System.Drawing.Size(94, 31);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RoomNumberTextbox
            // 
            this.RoomNumberTextbox.BackColor = System.Drawing.Color.Transparent;
            this.RoomNumberTextbox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.RoomNumberTextbox.BorderColor = System.Drawing.Color.Silver;
            this.RoomNumberTextbox.BorderSize = 0;
            this.tableLayoutPanel1.SetColumnSpan(this.RoomNumberTextbox, 2);
            this.RoomNumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNumberTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomNumberTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.RoomNumberTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomNumberTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.RoomNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoomNumberTextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RoomNumberTextbox.Location = new System.Drawing.Point(3, 53);
            this.RoomNumberTextbox.Name = "RoomNumberTextbox";
            this.RoomNumberTextbox.PasswordChar = '\0';
            this.RoomNumberTextbox.Radius = 10;
            this.RoomNumberTextbox.SelectedText = "";
            this.RoomNumberTextbox.Size = new System.Drawing.Size(294, 44);
            this.RoomNumberTextbox.TabIndex = 9;
            this.RoomNumberTextbox.Text = "Room number";
            this.RoomNumberTextbox.TextOffsetX = 10;
            this.RoomNumberTextbox.TextChanged += new System.EventHandler(this.RoomNumberTextbox_TextChanged);
            // 
            // PersonCountNumeric
            // 
            this.PersonCountNumeric.BaseColor = System.Drawing.Color.White;
            this.PersonCountNumeric.BorderColor = System.Drawing.Color.Silver;
            this.PersonCountNumeric.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PersonCountNumeric.ButtonForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.PersonCountNumeric, 2);
            this.PersonCountNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonCountNumeric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PersonCountNumeric.ForeColor = System.Drawing.Color.Black;
            this.PersonCountNumeric.Location = new System.Drawing.Point(3, 103);
            this.PersonCountNumeric.Maximum = ((long)(9999999));
            this.PersonCountNumeric.Minimum = ((long)(0));
            this.PersonCountNumeric.Name = "PersonCountNumeric";
            this.PersonCountNumeric.Size = new System.Drawing.Size(294, 30);
            this.PersonCountNumeric.TabIndex = 13;
            this.PersonCountNumeric.Text = "gunaNumeric1";
            this.PersonCountNumeric.Value = ((long)(0));
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PriceTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.PriceTextBox.BorderColor = System.Drawing.Color.Silver;
            this.PriceTextBox.BorderSize = 0;
            this.tableLayoutPanel1.SetColumnSpan(this.PriceTextBox, 2);
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PriceTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PriceTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PriceTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PriceTextBox.Location = new System.Drawing.Point(3, 253);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.Radius = 10;
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.Size = new System.Drawing.Size(294, 44);
            this.PriceTextBox.TabIndex = 9;
            this.PriceTextBox.Text = "0.00";
            this.PriceTextBox.TextOffsetX = 10;
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.DetailsTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.DetailsTextBox.BorderColor = System.Drawing.Color.Silver;
            this.DetailsTextBox.BorderSize = 0;
            this.tableLayoutPanel1.SetColumnSpan(this.DetailsTextBox, 2);
            this.DetailsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DetailsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.DetailsTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DetailsTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.DetailsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DetailsTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DetailsTextBox.Location = new System.Drawing.Point(3, 303);
            this.DetailsTextBox.MaxLength = 255;
            this.DetailsTextBox.Multiline = true;
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.PasswordChar = '\0';
            this.DetailsTextBox.Radius = 10;
            this.tableLayoutPanel1.SetRowSpan(this.DetailsTextBox, 2);
            this.DetailsTextBox.SelectedText = "";
            this.DetailsTextBox.Size = new System.Drawing.Size(294, 94);
            this.DetailsTextBox.TabIndex = 9;
            this.DetailsTextBox.Text = "Details";
            this.DetailsTextBox.TextOffsetX = 10;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.AnimationHoverSpeed = 0.07F;
            this.DeleteButton.AnimationSpeed = 0.03F;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.DeleteButton.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButton.FocusedColor = System.Drawing.Color.Empty;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Image = null;
            this.DeleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.DeleteButton.Location = new System.Drawing.Point(103, 403);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(163)))), ((int)(((byte)(243)))));
            this.DeleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.DeleteButton.OnHoverImage = null;
            this.DeleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.DeleteButton.Radius = 10;
            this.DeleteButton.Size = new System.Drawing.Size(194, 31);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PersonCountNumeric, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StatusComboBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DetailsTextBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.RoomNumberTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PriceTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameTextBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.RoomDataGrid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 2, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // RoomDataGrid
            // 
            this.RoomDataGrid.AllowUserToAddRows = false;
            this.RoomDataGrid.AllowUserToDeleteRows = false;
            this.RoomDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.RoomDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RoomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.RoomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RoomDataGrid.ColumnHeadersHeight = 40;
            this.RoomDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomID,
            this.PersonCount,
            this.Status,
            this.Price,
            this.Details});
            this.tableLayoutPanel1.SetColumnSpan(this.RoomDataGrid, 2);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.RoomDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RoomDataGrid.EnableHeadersVisualStyles = false;
            this.RoomDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomDataGrid.Location = new System.Drawing.Point(303, 53);
            this.RoomDataGrid.Name = "RoomDataGrid";
            this.RoomDataGrid.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.RoomDataGrid, 7);
            this.RoomDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomDataGrid.Size = new System.Drawing.Size(394, 344);
            this.RoomDataGrid.TabIndex = 14;
            this.RoomDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.RoomDataGrid.ThemeStyle.ReadOnly = false;
            this.RoomDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.RoomDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomDataGrid_CellClick);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.AnimationHoverSpeed = 0.07F;
            this.AddButton.AnimationSpeed = 0.03F;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.AddButton.BorderColor = System.Drawing.Color.Black;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Image = null;
            this.AddButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddButton.Location = new System.Drawing.Point(303, 403);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(163)))), ((int)(((byte)(243)))));
            this.AddButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddButton.OnHoverImage = null;
            this.AddButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddButton.Radius = 10;
            this.AddButton.Size = new System.Drawing.Size(194, 31);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "roomNumber";
            this.RoomNumber.HeaderText = "Room Number";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "roomID";
            this.RoomID.HeaderText = "Room ID";
            this.RoomID.Name = "RoomID";
            this.RoomID.Visible = false;
            // 
            // PersonCount
            // 
            this.PersonCount.DataPropertyName = "roomPersonCount";
            this.PersonCount.HeaderText = "Person Count";
            this.PersonCount.Name = "PersonCount";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "roomStatus";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "roomPrice";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Details
            // 
            this.Details.DataPropertyName = "roomDetails";
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaPanel1.Controls.Add(this.SignOutButton);
            this.gunaPanel1.Location = new System.Drawing.Point(604, 27);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(184, 106);
            this.gunaPanel1.TabIndex = 16;
            this.gunaPanel1.Visible = false;
            // 
            // SignOutButton
            // 
            this.SignOutButton.AutoSize = true;
            this.SignOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignOutButton.Location = new System.Drawing.Point(15, 77);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(51, 15);
            this.SignOutButton.TabIndex = 0;
            this.SignOutButton.Text = "Sign out";
            this.SignOutButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixel;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGrid)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel FirstNameTextBox;
        private Guna.UI.WinForms.GunaComboBox StatusComboBox;
        private Guna.UI.WinForms.GunaButton SaveButton;
        private Guna.UI.WinForms.GunaTextBox RoomNumberTextbox;
        private Guna.UI.WinForms.GunaNumeric PersonCountNumeric;
        private Guna.UI.WinForms.GunaTextBox PriceTextBox;
        private Guna.UI.WinForms.GunaTextBox DetailsTextBox;
        private Guna.UI.WinForms.GunaButton DeleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView RoomDataGrid;
        private Guna.UI.WinForms.GunaButton AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel SignOutButton;
    }
}