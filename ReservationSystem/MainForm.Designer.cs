
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FirstNameTextBox = new Guna.UI.WinForms.GunaLabel();
            this.StatusComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.RoomNumberTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.PersonCountNumeric = new Guna.UI.WinForms.GunaNumeric();
            this.PriceTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.DetailsTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BrowseButton = new Guna.UI2.WinForms.Guna2Button();
            this.RoomDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SignoutPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SignOutButton = new Guna.UI.WinForms.GunaLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SignoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTextBox.AutoSize = true;
            this.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(188, 10);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(45, 36);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Text = "Hi User";
            this.FirstNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusComboBox.ForeColor = System.Drawing.Color.Black;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Available",
            "Reserved"});
            this.StatusComboBox.Location = new System.Drawing.Point(78, 159);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.StatusComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.StatusComboBox.Radius = 10;
            this.StatusComboBox.Size = new System.Drawing.Size(194, 26);
            this.StatusComboBox.TabIndex = 2;
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
            this.RoomNumberTextbox.Location = new System.Drawing.Point(78, 63);
            this.RoomNumberTextbox.Name = "RoomNumberTextbox";
            this.RoomNumberTextbox.PasswordChar = '\0';
            this.RoomNumberTextbox.Radius = 10;
            this.RoomNumberTextbox.SelectedText = "";
            this.RoomNumberTextbox.Size = new System.Drawing.Size(194, 42);
            this.RoomNumberTextbox.TabIndex = 0;
            this.RoomNumberTextbox.Text = "Room number";
            this.RoomNumberTextbox.TextOffsetX = 10;
            this.RoomNumberTextbox.TextChanged += new System.EventHandler(this.RoomNumberTextbox_TextChanged);
            // 
            // PersonCountNumeric
            // 
            this.PersonCountNumeric.BackColor = System.Drawing.Color.Transparent;
            this.PersonCountNumeric.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.PersonCountNumeric.BorderColor = System.Drawing.Color.Silver;
            this.PersonCountNumeric.BorderSize = 0;
            this.PersonCountNumeric.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.PersonCountNumeric.ButtonForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.PersonCountNumeric, 2);
            this.PersonCountNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonCountNumeric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PersonCountNumeric.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PersonCountNumeric.Location = new System.Drawing.Point(78, 111);
            this.PersonCountNumeric.Maximum = ((long)(9999999));
            this.PersonCountNumeric.Minimum = ((long)(0));
            this.PersonCountNumeric.Name = "PersonCountNumeric";
            this.PersonCountNumeric.Radius = 10;
            this.PersonCountNumeric.Size = new System.Drawing.Size(194, 30);
            this.PersonCountNumeric.TabIndex = 1;
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
            this.PriceTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PriceTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PriceTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PriceTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PriceTextBox.Location = new System.Drawing.Point(78, 207);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.Radius = 10;
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.Size = new System.Drawing.Size(194, 40);
            this.PriceTextBox.TabIndex = 3;
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
            this.DetailsTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.DetailsTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DetailsTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.DetailsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DetailsTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DetailsTextBox.Location = new System.Drawing.Point(78, 255);
            this.DetailsTextBox.MaxLength = 0;
            this.DetailsTextBox.Multiline = true;
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.PasswordChar = '\0';
            this.DetailsTextBox.Radius = 10;
            this.tableLayoutPanel1.SetRowSpan(this.DetailsTextBox, 2);
            this.DetailsTextBox.SelectedText = "";
            this.DetailsTextBox.Size = new System.Drawing.Size(194, 164);
            this.DetailsTextBox.TabIndex = 4;
            this.DetailsTextBox.Text = "Details";
            this.DetailsTextBox.TextOffsetX = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Controls.Add(this.PersonCountNumeric, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BrowseButton, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.RoomNumberTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RoomDataGrid, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StatusComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriceTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunaTextBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2PictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PictureBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.DetailsTextBox, 5, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Animated = true;
            this.BrowseButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseButton.BorderRadius = 10;
            this.BrowseButton.CheckedState.Parent = this.BrowseButton;
            this.BrowseButton.CustomImages.Parent = this.BrowseButton;
            this.BrowseButton.FillColor = System.Drawing.Color.White;
            this.BrowseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BrowseButton.ForeColor = System.Drawing.Color.Black;
            this.BrowseButton.HoverState.Parent = this.BrowseButton;
            this.BrowseButton.Image = global::ReservationSystem.Properties.Resources.icons8_plus_24;
            this.BrowseButton.ImageSize = new System.Drawing.Size(15, 15);
            this.BrowseButton.Location = new System.Drawing.Point(278, 402);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.ShadowDecoration.BorderRadius = 10;
            this.BrowseButton.ShadowDecoration.Depth = 20;
            this.BrowseButton.ShadowDecoration.Enabled = true;
            this.BrowseButton.ShadowDecoration.Parent = this.BrowseButton;
            this.BrowseButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.BrowseButton.Size = new System.Drawing.Size(231, 30);
            this.BrowseButton.TabIndex = 16;
            this.BrowseButton.Text = "Open";
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RoomDataGrid
            // 
            this.RoomDataGrid.AllowUserToAddRows = false;
            this.RoomDataGrid.AllowUserToDeleteRows = false;
            this.RoomDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RoomDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RoomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.RoomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.RoomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RoomDataGrid.ColumnHeadersHeight = 40;
            this.RoomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RoomDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomID,
            this.PersonCount,
            this.Status,
            this.Price,
            this.Details,
            this.OutDate,
            this.InDate,
            this.Picture});
            this.tableLayoutPanel1.SetColumnSpan(this.RoomDataGrid, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoomDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RoomDataGrid.EnableHeadersVisualStyles = false;
            this.RoomDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomDataGrid.Location = new System.Drawing.Point(278, 63);
            this.RoomDataGrid.MultiSelect = false;
            this.RoomDataGrid.Name = "RoomDataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RoomDataGrid.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.RoomDataGrid, 7);
            this.RoomDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomDataGrid.Size = new System.Drawing.Size(468, 330);
            this.RoomDataGrid.TabIndex = 14;
            this.RoomDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(117)))), ((int)(((byte)(237)))));
            this.RoomDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            // OutDate
            // 
            this.OutDate.DataPropertyName = "roomOutDate";
            this.OutDate.HeaderText = "Out Date";
            this.OutDate.Name = "OutDate";
            this.OutDate.Visible = false;
            // 
            // InDate
            // 
            this.InDate.DataPropertyName = "roomInDate";
            this.InDate.HeaderText = "In Date";
            this.InDate.Name = "InDate";
            this.InDate.Visible = false;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "roomPicture";
            this.Picture.HeaderText = "Picture";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Picture.Name = "Picture";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gunaLabel1);
            this.flowLayoutPanel1.Controls.Add(this.AddButton);
            this.flowLayoutPanel1.Controls.Add(this.SaveButton);
            this.flowLayoutPanel1.Controls.Add(this.DeleteButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 384);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gunaLabel1.Location = new System.Drawing.Point(19, 60);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(27, 12);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tools";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.Click += new System.EventHandler(this.FirstNameTextBox_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Animated = true;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BorderRadius = 10;
            this.AddButton.CheckedState.Parent = this.AddButton;
            this.AddButton.CustomImages.Parent = this.AddButton;
            this.AddButton.Enabled = false;
            this.AddButton.FillColor = System.Drawing.Color.White;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.HoverState.Parent = this.AddButton;
            this.AddButton.Image = global::ReservationSystem.Properties.Resources.icons8_plus_24;
            this.AddButton.ImageSize = new System.Drawing.Size(15, 15);
            this.AddButton.Location = new System.Drawing.Point(19, 81);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.ShadowDecoration.BorderRadius = 10;
            this.AddButton.ShadowDecoration.Depth = 20;
            this.AddButton.ShadowDecoration.Enabled = true;
            this.AddButton.ShadowDecoration.Parent = this.AddButton;
            this.AddButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.AddButton.Size = new System.Drawing.Size(30, 30);
            this.AddButton.TabIndex = 16;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Animated = true;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BorderRadius = 10;
            this.SaveButton.CheckedState.Parent = this.SaveButton;
            this.SaveButton.CustomImages.Parent = this.SaveButton;
            this.SaveButton.Enabled = false;
            this.SaveButton.FillColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.HoverState.Parent = this.SaveButton;
            this.SaveButton.Image = global::ReservationSystem.Properties.Resources.icons8_box_24;
            this.SaveButton.ImageSize = new System.Drawing.Size(15, 15);
            this.SaveButton.Location = new System.Drawing.Point(19, 120);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.ShadowDecoration.BorderRadius = 10;
            this.SaveButton.ShadowDecoration.Depth = 20;
            this.SaveButton.ShadowDecoration.Enabled = true;
            this.SaveButton.ShadowDecoration.Parent = this.SaveButton;
            this.SaveButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.SaveButton.Size = new System.Drawing.Size(30, 30);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Animated = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BorderRadius = 10;
            this.DeleteButton.CheckedState.Parent = this.DeleteButton;
            this.DeleteButton.CustomImages.Parent = this.DeleteButton;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FillColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.HoverState.Parent = this.DeleteButton;
            this.DeleteButton.Image = global::ReservationSystem.Properties.Resources.icons8_remove_24;
            this.DeleteButton.ImageSize = new System.Drawing.Size(15, 15);
            this.DeleteButton.Location = new System.Drawing.Point(19, 159);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShadowDecoration.BorderRadius = 10;
            this.DeleteButton.ShadowDecoration.Depth = 20;
            this.DeleteButton.ShadowDecoration.Enabled = true;
            this.DeleteButton.ShadowDecoration.Parent = this.DeleteButton;
            this.DeleteButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.DeleteButton.Size = new System.Drawing.Size(30, 30);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.guna2CirclePictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.FirstNameTextBox);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(515, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(282, 54);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = global::ReservationSystem.Properties.Resources.R659c780bf2f1f39858dd05c7e022ddb8;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(239, 13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 15;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.FirstNameTextBox_Click);
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
            this.gunaTextBox1.Location = new System.Drawing.Point(278, 10);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(194, 40);
            this.gunaTextBox1.TabIndex = 9;
            this.gunaTextBox1.Text = "Search a room";
            this.gunaTextBox1.TextOffsetX = 10;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::ReservationSystem.Properties.Resources.Asset_1a;
            this.guna2PictureBox1.Location = new System.Drawing.Point(20, 15);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(20, 15, 3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PictureBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PictureBox, 2);
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(78, 351);
            this.PictureBox.Name = "PictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.PictureBox, 2);
            this.PictureBox.ShadowDecoration.Parent = this.PictureBox;
            this.PictureBox.Size = new System.Drawing.Size(194, 96);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 20;
            this.PictureBox.TabStop = false;
            // 
            // SignoutPanel
            // 
            this.SignoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.SignoutPanel.BorderRadius = 10;
            this.SignoutPanel.Controls.Add(this.gunaPictureBox2);
            this.SignoutPanel.Controls.Add(this.gunaPictureBox1);
            this.SignoutPanel.Controls.Add(this.gunaLabel2);
            this.SignoutPanel.Controls.Add(this.SignOutButton);
            this.SignoutPanel.FillColor = System.Drawing.Color.White;
            this.SignoutPanel.Location = new System.Drawing.Point(606, 51);
            this.SignoutPanel.Name = "SignoutPanel";
            this.SignoutPanel.ShadowDecoration.BorderRadius = 10;
            this.SignoutPanel.ShadowDecoration.Depth = 20;
            this.SignoutPanel.ShadowDecoration.Enabled = true;
            this.SignoutPanel.ShadowDecoration.Parent = this.SignoutPanel;
            this.SignoutPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.SignoutPanel.Size = new System.Drawing.Size(184, 65);
            this.SignoutPanel.TabIndex = 17;
            this.SignoutPanel.Visible = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::ReservationSystem.Properties.Resources.icons8_sign_out_24;
            this.gunaPictureBox2.Location = new System.Drawing.Point(9, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(15, 15);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 1;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::ReservationSystem.Properties.Resources.icons8_sign_out_24;
            this.gunaPictureBox1.Location = new System.Drawing.Point(9, 38);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(15, 15);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(25, 12);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaLabel2.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Preference";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixel;
            this.gunaLabel2.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SignOutButton.AutoSize = true;
            this.SignOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignOutButton.ForeColor = System.Drawing.Color.Black;
            this.SignOutButton.Location = new System.Drawing.Point(25, 38);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SignOutButton.Size = new System.Drawing.Size(51, 15);
            this.SignOutButton.TabIndex = 0;
            this.SignOutButton.Text = "Sign out";
            this.SignOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignOutButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixel;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.SignoutPanel.ResumeLayout(false);
            this.SignoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel FirstNameTextBox;
        private Guna.UI.WinForms.GunaComboBox StatusComboBox;
        private Guna.UI.WinForms.GunaTextBox RoomNumberTextbox;
        private Guna.UI.WinForms.GunaNumeric PersonCountNumeric;
        private Guna.UI.WinForms.GunaTextBox PriceTextBox;
        private Guna.UI.WinForms.GunaTextBox DetailsTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView RoomDataGrid;
        private Guna.UI.WinForms.GunaLabel SignOutButton;
        private Guna.UI2.WinForms.Guna2Panel SignoutPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button BrowseButton;
        public Guna.UI2.WinForms.Guna2PictureBox PictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InDate;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
    }
}