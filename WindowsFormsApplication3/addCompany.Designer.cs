namespace WindowsFormsApplication3
{
    partial class addCompany
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCompany));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressTextbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.clearTextButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.nameTexBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.contactTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.cNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addcomp = new WindowsFormsApplication3.addcomp();
            this.cOMPANYTableAdapter = new WindowsFormsApplication3.addcompTableAdapters.COMPANYTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcomp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addressTextbox);
            this.panel1.Controls.Add(this.clearTextButton);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Controls.Add(this.nameTexBox);
            this.panel1.Controls.Add(this.contactTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 313);
            this.panel1.TabIndex = 1;
            // 
            // addressTextbox
            // 
            this.addressTextbox.AcceptsReturn = false;
            this.addressTextbox.AcceptsTab = false;
            this.addressTextbox.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.addressTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addressTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressTextbox.BackColor = System.Drawing.Color.Transparent;
            this.addressTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addressTextbox.BackgroundImage")));
            this.addressTextbox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressTextbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.addressTextbox.BorderColorHover = System.Drawing.Color.Silver;
            this.addressTextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressTextbox.BorderRadius = 1;
            this.addressTextbox.BorderThickness = 1;
            this.addressTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addressTextbox.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.addressTextbox.DefaultText = "";
            this.addressTextbox.FillColor = System.Drawing.Color.White;
            this.addressTextbox.HideSelection = true;
            this.addressTextbox.IconLeft = null;
            this.addressTextbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addressTextbox.IconPadding = 10;
            this.addressTextbox.IconRight = null;
            this.addressTextbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addressTextbox.Location = new System.Drawing.Point(540, 110);
            this.addressTextbox.MaxLength = 32767;
            this.addressTextbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.addressTextbox.Modified = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.PasswordChar = '\0';
            this.addressTextbox.ReadOnly = false;
            this.addressTextbox.SelectedText = "";
            this.addressTextbox.SelectionLength = 0;
            this.addressTextbox.SelectionStart = 0;
            this.addressTextbox.ShortcutsEnabled = true;
            this.addressTextbox.Size = new System.Drawing.Size(239, 37);
            this.addressTextbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.addressTextbox.TabIndex = 2;
            this.addressTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addressTextbox.TextMarginLeft = 5;
            this.addressTextbox.TextPlaceholder = "";
            this.addressTextbox.UseSystemPasswordChar = false;
            // 
            // clearTextButton
            // 
            this.clearTextButton.BackColor = System.Drawing.Color.Transparent;
            this.clearTextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearTextButton.BackgroundImage")));
            this.clearTextButton.ButtonText = "Clear";
            this.clearTextButton.ButtonTextMarginLeft = 0;
            this.clearTextButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.clearTextButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.clearTextButton.DisabledForecolor = System.Drawing.Color.White;
            this.clearTextButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.clearTextButton.ForeColor = System.Drawing.Color.White;
            this.clearTextButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.clearTextButton.IconPadding = 10;
            this.clearTextButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.clearTextButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.clearTextButton.IdleBorderRadius = 1;
            this.clearTextButton.IdleBorderThickness = 0;
            this.clearTextButton.IdleFillColor = System.Drawing.Color.Teal;
            this.clearTextButton.IdleIconLeftImage = null;
            this.clearTextButton.IdleIconRightImage = null;
            this.clearTextButton.Location = new System.Drawing.Point(666, 242);
            this.clearTextButton.Name = "clearTextButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.clearTextButton.onHoverState = stateProperties1;
            this.clearTextButton.Size = new System.Drawing.Size(123, 35);
            this.clearTextButton.TabIndex = 5;
            this.clearTextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Add Company";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Teal;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(512, 242);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(122, 35);
            this.bunifuButton1.TabIndex = 4;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // nameTexBox
            // 
            this.nameTexBox.AcceptsReturn = false;
            this.nameTexBox.AcceptsTab = false;
            this.nameTexBox.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.nameTexBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTexBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameTexBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTexBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameTexBox.BackgroundImage")));
            this.nameTexBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTexBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.nameTexBox.BorderColorHover = System.Drawing.Color.Silver;
            this.nameTexBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTexBox.BorderRadius = 1;
            this.nameTexBox.BorderThickness = 1;
            this.nameTexBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTexBox.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.nameTexBox.DefaultText = "";
            this.nameTexBox.FillColor = System.Drawing.Color.White;
            this.nameTexBox.HideSelection = true;
            this.nameTexBox.IconLeft = null;
            this.nameTexBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.nameTexBox.IconPadding = 10;
            this.nameTexBox.IconRight = null;
            this.nameTexBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.nameTexBox.Location = new System.Drawing.Point(540, 50);
            this.nameTexBox.MaxLength = 32767;
            this.nameTexBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.nameTexBox.Modified = false;
            this.nameTexBox.Name = "nameTexBox";
            this.nameTexBox.PasswordChar = '\0';
            this.nameTexBox.ReadOnly = false;
            this.nameTexBox.SelectedText = "";
            this.nameTexBox.SelectionLength = 0;
            this.nameTexBox.SelectionStart = 0;
            this.nameTexBox.ShortcutsEnabled = true;
            this.nameTexBox.Size = new System.Drawing.Size(239, 37);
            this.nameTexBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.nameTexBox.TabIndex = 1;
            this.nameTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTexBox.TextMarginLeft = 5;
            this.nameTexBox.TextPlaceholder = "";
            this.nameTexBox.UseSystemPasswordChar = false;
            // 
            // contactTextBox
            // 
            this.contactTextBox.AcceptsReturn = false;
            this.contactTextBox.AcceptsTab = false;
            this.contactTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.contactTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.contactTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.contactTextBox.BackColor = System.Drawing.Color.Transparent;
            this.contactTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactTextBox.BackgroundImage")));
            this.contactTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.contactTextBox.BorderColorHover = System.Drawing.Color.Silver;
            this.contactTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactTextBox.BorderRadius = 1;
            this.contactTextBox.BorderThickness = 1;
            this.contactTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.contactTextBox.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.contactTextBox.DefaultText = "";
            this.contactTextBox.FillColor = System.Drawing.Color.White;
            this.contactTextBox.HideSelection = true;
            this.contactTextBox.IconLeft = null;
            this.contactTextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.contactTextBox.IconPadding = 10;
            this.contactTextBox.IconRight = null;
            this.contactTextBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.contactTextBox.Location = new System.Drawing.Point(540, 162);
            this.contactTextBox.MaxLength = 32767;
            this.contactTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.contactTextBox.Modified = false;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.PasswordChar = '\0';
            this.contactTextBox.ReadOnly = false;
            this.contactTextBox.SelectedText = "";
            this.contactTextBox.SelectionLength = 0;
            this.contactTextBox.SelectionStart = 0;
            this.contactTextBox.ShortcutsEnabled = true;
            this.contactTextBox.Size = new System.Drawing.Size(239, 37);
            this.contactTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.contactTextBox.TabIndex = 3;
            this.contactTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactTextBox.TextMarginLeft = 5;
            this.contactTextBox.TextPlaceholder = "";
            this.contactTextBox.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label8.Location = new System.Drawing.Point(427, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Address";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 304);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1360, 12);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label4.Location = new System.Drawing.Point(393, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contact no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(347, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Company Name";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNODataGridViewTextBoxColumn,
            this.cNAMEDataGridViewTextBoxColumn,
            this.cADDRDataGridViewTextBoxColumn,
            this.cONTACTNODataGridViewTextBoxColumn,
            this.aNODataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.cOMPANYBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 313);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1366, 455);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 6;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cNODataGridViewTextBoxColumn
            // 
            this.cNODataGridViewTextBoxColumn.DataPropertyName = "CNO";
            this.cNODataGridViewTextBoxColumn.HeaderText = "CNO";
            this.cNODataGridViewTextBoxColumn.Name = "cNODataGridViewTextBoxColumn";
            this.cNODataGridViewTextBoxColumn.ReadOnly = true;
            this.cNODataGridViewTextBoxColumn.Width = 300;
            // 
            // cNAMEDataGridViewTextBoxColumn
            // 
            this.cNAMEDataGridViewTextBoxColumn.DataPropertyName = "CNAME";
            this.cNAMEDataGridViewTextBoxColumn.HeaderText = "COMPANY NAME";
            this.cNAMEDataGridViewTextBoxColumn.Name = "cNAMEDataGridViewTextBoxColumn";
            this.cNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNAMEDataGridViewTextBoxColumn.Width = 350;
            // 
            // cADDRDataGridViewTextBoxColumn
            // 
            this.cADDRDataGridViewTextBoxColumn.DataPropertyName = "CADDR";
            this.cADDRDataGridViewTextBoxColumn.HeaderText = "COMPANY ADDRESS";
            this.cADDRDataGridViewTextBoxColumn.Name = "cADDRDataGridViewTextBoxColumn";
            this.cADDRDataGridViewTextBoxColumn.ReadOnly = true;
            this.cADDRDataGridViewTextBoxColumn.Width = 350;
            // 
            // cONTACTNODataGridViewTextBoxColumn
            // 
            this.cONTACTNODataGridViewTextBoxColumn.DataPropertyName = "CONTACT_NO";
            this.cONTACTNODataGridViewTextBoxColumn.HeaderText = "CONTACT NO";
            this.cONTACTNODataGridViewTextBoxColumn.Name = "cONTACTNODataGridViewTextBoxColumn";
            this.cONTACTNODataGridViewTextBoxColumn.ReadOnly = true;
            this.cONTACTNODataGridViewTextBoxColumn.Width = 200;
            // 
            // aNODataGridViewTextBoxColumn
            // 
            this.aNODataGridViewTextBoxColumn.DataPropertyName = "ANO";
            this.aNODataGridViewTextBoxColumn.HeaderText = "ANO";
            this.aNODataGridViewTextBoxColumn.Name = "aNODataGridViewTextBoxColumn";
            this.aNODataGridViewTextBoxColumn.ReadOnly = true;
            this.aNODataGridViewTextBoxColumn.Width = 200;
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.addcomp;
            // 
            // addcomp
            // 
            this.addcomp.DataSetName = "addcomp";
            this.addcomp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPANYTableAdapter
            // 
            this.cOMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // addCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "addCompany";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.addCompany_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcomp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox addressTextbox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton clearTextButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nameTexBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox contactTextBox;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private addcomp addcomp;
        private addcompTableAdapters.COMPANYTableAdapter cOMPANYTableAdapter;
    }
}
