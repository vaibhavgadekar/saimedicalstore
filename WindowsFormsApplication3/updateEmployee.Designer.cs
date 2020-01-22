namespace WindowsFormsApplication3
{
    partial class updateEmployee
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.euser = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.epass = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eaddr = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.clearTextButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ename = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.econtact = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eid = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dataSet13 = new WindowsFormsApplication3.DataSet13();
            this.aDMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter = new WindowsFormsApplication3.DataSet13TableAdapters.ADMINTableAdapter();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aADDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.eid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.euser);
            this.panel1.Controls.Add(this.epass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.eaddr);
            this.panel1.Controls.Add(this.clearTextButton);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Controls.Add(this.ename);
            this.panel1.Controls.Add(this.econtact);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 256);
            this.panel1.TabIndex = 1;
            // 
            // euser
            // 
            this.euser.AcceptsReturn = false;
            this.euser.AcceptsTab = false;
            this.euser.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.euser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.euser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.euser.BackColor = System.Drawing.Color.Transparent;
            this.euser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("euser.BackgroundImage")));
            this.euser.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.euser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.euser.BorderColorHover = System.Drawing.Color.Silver;
            this.euser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.euser.BorderRadius = 1;
            this.euser.BorderThickness = 1;
            this.euser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.euser.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.euser.DefaultText = "";
            this.euser.FillColor = System.Drawing.Color.White;
            this.euser.HideSelection = true;
            this.euser.IconLeft = null;
            this.euser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.euser.IconPadding = 10;
            this.euser.IconRight = null;
            this.euser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.euser.Location = new System.Drawing.Point(804, 78);
            this.euser.MaxLength = 32767;
            this.euser.MinimumSize = new System.Drawing.Size(100, 35);
            this.euser.Modified = false;
            this.euser.Name = "euser";
            this.euser.PasswordChar = '\0';
            this.euser.ReadOnly = false;
            this.euser.SelectedText = "";
            this.euser.SelectionLength = 0;
            this.euser.SelectionStart = 0;
            this.euser.ShortcutsEnabled = true;
            this.euser.Size = new System.Drawing.Size(239, 37);
            this.euser.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.euser.TabIndex = 32;
            this.euser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.euser.TextMarginLeft = 5;
            this.euser.TextPlaceholder = "";
            this.euser.UseSystemPasswordChar = false;
            // 
            // epass
            // 
            this.epass.AcceptsReturn = false;
            this.epass.AcceptsTab = false;
            this.epass.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.epass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.epass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.epass.BackColor = System.Drawing.Color.Transparent;
            this.epass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("epass.BackgroundImage")));
            this.epass.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.epass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.epass.BorderColorHover = System.Drawing.Color.Silver;
            this.epass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.epass.BorderRadius = 1;
            this.epass.BorderThickness = 1;
            this.epass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.epass.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.epass.DefaultText = "";
            this.epass.FillColor = System.Drawing.Color.White;
            this.epass.HideSelection = true;
            this.epass.IconLeft = null;
            this.epass.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.epass.IconPadding = 10;
            this.epass.IconRight = null;
            this.epass.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.epass.Location = new System.Drawing.Point(804, 130);
            this.epass.MaxLength = 32767;
            this.epass.MinimumSize = new System.Drawing.Size(100, 35);
            this.epass.Modified = false;
            this.epass.Name = "epass";
            this.epass.PasswordChar = '\0';
            this.epass.ReadOnly = false;
            this.epass.SelectedText = "";
            this.epass.SelectionLength = 0;
            this.epass.SelectionStart = 0;
            this.epass.ShortcutsEnabled = true;
            this.epass.Size = new System.Drawing.Size(239, 37);
            this.epass.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.epass.TabIndex = 33;
            this.epass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.epass.TextMarginLeft = 5;
            this.epass.TextPlaceholder = "";
            this.epass.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(691, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Usename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.Location = new System.Drawing.Point(694, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Password";
            // 
            // eaddr
            // 
            this.eaddr.AcceptsReturn = false;
            this.eaddr.AcceptsTab = false;
            this.eaddr.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.eaddr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.eaddr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.eaddr.BackColor = System.Drawing.Color.Transparent;
            this.eaddr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eaddr.BackgroundImage")));
            this.eaddr.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eaddr.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.eaddr.BorderColorHover = System.Drawing.Color.Silver;
            this.eaddr.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eaddr.BorderRadius = 1;
            this.eaddr.BorderThickness = 1;
            this.eaddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.eaddr.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.eaddr.DefaultText = "";
            this.eaddr.FillColor = System.Drawing.Color.White;
            this.eaddr.HideSelection = true;
            this.eaddr.IconLeft = null;
            this.eaddr.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.eaddr.IconPadding = 10;
            this.eaddr.IconRight = null;
            this.eaddr.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.eaddr.Location = new System.Drawing.Point(348, 138);
            this.eaddr.MaxLength = 32767;
            this.eaddr.MinimumSize = new System.Drawing.Size(100, 35);
            this.eaddr.Modified = false;
            this.eaddr.Name = "eaddr";
            this.eaddr.PasswordChar = '\0';
            this.eaddr.ReadOnly = false;
            this.eaddr.SelectedText = "";
            this.eaddr.SelectionLength = 0;
            this.eaddr.SelectionStart = 0;
            this.eaddr.ShortcutsEnabled = true;
            this.eaddr.Size = new System.Drawing.Size(239, 37);
            this.eaddr.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.eaddr.TabIndex = 25;
            this.eaddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eaddr.TextMarginLeft = 5;
            this.eaddr.TextPlaceholder = "";
            this.eaddr.UseSystemPasswordChar = false;
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
            this.clearTextButton.Location = new System.Drawing.Point(708, 210);
            this.clearTextButton.Name = "clearTextButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.clearTextButton.onHoverState = stateProperties1;
            this.clearTextButton.Size = new System.Drawing.Size(123, 35);
            this.clearTextButton.TabIndex = 28;
            this.clearTextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Update";
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
            this.bunifuButton1.Location = new System.Drawing.Point(554, 210);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(122, 35);
            this.bunifuButton1.TabIndex = 27;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // ename
            // 
            this.ename.AcceptsReturn = false;
            this.ename.AcceptsTab = false;
            this.ename.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.ename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ename.BackColor = System.Drawing.Color.Transparent;
            this.ename.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ename.BackgroundImage")));
            this.ename.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ename.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ename.BorderColorHover = System.Drawing.Color.Silver;
            this.ename.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ename.BorderRadius = 1;
            this.ename.BorderThickness = 1;
            this.ename.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ename.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.ename.DefaultText = "";
            this.ename.FillColor = System.Drawing.Color.White;
            this.ename.HideSelection = true;
            this.ename.IconLeft = null;
            this.ename.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ename.IconPadding = 10;
            this.ename.IconRight = null;
            this.ename.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ename.Location = new System.Drawing.Point(348, 78);
            this.ename.MaxLength = 32767;
            this.ename.MinimumSize = new System.Drawing.Size(100, 35);
            this.ename.Modified = false;
            this.ename.Name = "ename";
            this.ename.PasswordChar = '\0';
            this.ename.ReadOnly = false;
            this.ename.SelectedText = "";
            this.ename.SelectionLength = 0;
            this.ename.SelectionStart = 0;
            this.ename.ShortcutsEnabled = true;
            this.ename.Size = new System.Drawing.Size(239, 37);
            this.ename.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.ename.TabIndex = 24;
            this.ename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ename.TextMarginLeft = 5;
            this.ename.TextPlaceholder = "";
            this.ename.UseSystemPasswordChar = false;
            // 
            // econtact
            // 
            this.econtact.AcceptsReturn = false;
            this.econtact.AcceptsTab = false;
            this.econtact.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.econtact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.econtact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.econtact.BackColor = System.Drawing.Color.Transparent;
            this.econtact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("econtact.BackgroundImage")));
            this.econtact.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.econtact.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.econtact.BorderColorHover = System.Drawing.Color.Silver;
            this.econtact.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.econtact.BorderRadius = 1;
            this.econtact.BorderThickness = 1;
            this.econtact.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.econtact.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.econtact.DefaultText = "";
            this.econtact.FillColor = System.Drawing.Color.White;
            this.econtact.HideSelection = true;
            this.econtact.IconLeft = null;
            this.econtact.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.econtact.IconPadding = 10;
            this.econtact.IconRight = null;
            this.econtact.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.econtact.Location = new System.Drawing.Point(804, 22);
            this.econtact.MaxLength = 32767;
            this.econtact.MinimumSize = new System.Drawing.Size(100, 35);
            this.econtact.Modified = false;
            this.econtact.Name = "econtact";
            this.econtact.PasswordChar = '\0';
            this.econtact.ReadOnly = false;
            this.econtact.SelectedText = "";
            this.econtact.SelectionLength = 0;
            this.econtact.SelectionStart = 0;
            this.econtact.ShortcutsEnabled = true;
            this.econtact.Size = new System.Drawing.Size(239, 37);
            this.econtact.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.econtact.TabIndex = 26;
            this.econtact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.econtact.TextMarginLeft = 5;
            this.econtact.TextPlaceholder = "";
            this.econtact.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label8.Location = new System.Drawing.Point(235, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label4.Location = new System.Drawing.Point(670, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Contact no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(246, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = " Name";
            // 
            // eid
            // 
            this.eid.AcceptsReturn = false;
            this.eid.AcceptsTab = false;
            this.eid.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.eid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.eid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.eid.BackColor = System.Drawing.Color.Transparent;
            this.eid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eid.BackgroundImage")));
            this.eid.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eid.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.eid.BorderColorHover = System.Drawing.Color.Silver;
            this.eid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eid.BorderRadius = 1;
            this.eid.BorderThickness = 1;
            this.eid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.eid.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.eid.DefaultText = "";
            this.eid.FillColor = System.Drawing.Color.White;
            this.eid.HideSelection = true;
            this.eid.IconLeft = null;
            this.eid.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.eid.IconPadding = 10;
            this.eid.IconRight = null;
            this.eid.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.eid.Location = new System.Drawing.Point(348, 22);
            this.eid.MaxLength = 32767;
            this.eid.MinimumSize = new System.Drawing.Size(100, 35);
            this.eid.Modified = false;
            this.eid.Name = "eid";
            this.eid.PasswordChar = '\0';
            this.eid.ReadOnly = false;
            this.eid.SelectedText = "";
            this.eid.SelectionLength = 0;
            this.eid.SelectionStart = 0;
            this.eid.ShortcutsEnabled = true;
            this.eid.Size = new System.Drawing.Size(239, 37);
            this.eid.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.eid.TabIndex = 36;
            this.eid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eid.TextMarginLeft = 5;
            this.eid.TextPlaceholder = "";
            this.eid.UseSystemPasswordChar = false;
            this.eid.TextChange += new System.EventHandler(this.bunifuTextBox1_TextChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label5.Location = new System.Drawing.Point(246, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "User ID";
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
            this.aNODataGridViewTextBoxColumn,
            this.aNAMEDataGridViewTextBoxColumn,
            this.aADDRDataGridViewTextBoxColumn,
            this.cONTACTNODataGridViewTextBoxColumn,
            this.aPASSWORDDataGridViewTextBoxColumn,
            this.aUSERNAMEDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.aDMINBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 256);
            this.metroGrid1.Name = "metroGrid1";
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
            this.metroGrid1.Size = new System.Drawing.Size(1366, 512);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 23;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet13";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDMINBindingSource
            // 
            this.aDMINBindingSource.DataMember = "ADMIN";
            this.aDMINBindingSource.DataSource = this.dataSet13;
            // 
            // aDMINTableAdapter
            // 
            this.aDMINTableAdapter.ClearBeforeFill = true;
            // 
            // aNODataGridViewTextBoxColumn
            // 
            this.aNODataGridViewTextBoxColumn.DataPropertyName = "ANO";
            this.aNODataGridViewTextBoxColumn.HeaderText = "USER ID";
            this.aNODataGridViewTextBoxColumn.Name = "aNODataGridViewTextBoxColumn";
            this.aNODataGridViewTextBoxColumn.Width = 220;
            // 
            // aNAMEDataGridViewTextBoxColumn
            // 
            this.aNAMEDataGridViewTextBoxColumn.DataPropertyName = "ANAME";
            this.aNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.aNAMEDataGridViewTextBoxColumn.Name = "aNAMEDataGridViewTextBoxColumn";
            this.aNAMEDataGridViewTextBoxColumn.Width = 220;
            // 
            // aADDRDataGridViewTextBoxColumn
            // 
            this.aADDRDataGridViewTextBoxColumn.DataPropertyName = "AADDR";
            this.aADDRDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aADDRDataGridViewTextBoxColumn.Name = "aADDRDataGridViewTextBoxColumn";
            this.aADDRDataGridViewTextBoxColumn.Width = 220;
            // 
            // cONTACTNODataGridViewTextBoxColumn
            // 
            this.cONTACTNODataGridViewTextBoxColumn.DataPropertyName = "CONTACTNO";
            this.cONTACTNODataGridViewTextBoxColumn.HeaderText = "CONTACT NO";
            this.cONTACTNODataGridViewTextBoxColumn.Name = "cONTACTNODataGridViewTextBoxColumn";
            this.cONTACTNODataGridViewTextBoxColumn.Width = 220;
            // 
            // aPASSWORDDataGridViewTextBoxColumn
            // 
            this.aPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "APASSWORD";
            this.aPASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.aPASSWORDDataGridViewTextBoxColumn.Name = "aPASSWORDDataGridViewTextBoxColumn";
            this.aPASSWORDDataGridViewTextBoxColumn.Width = 220;
            // 
            // aUSERNAMEDataGridViewTextBoxColumn
            // 
            this.aUSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "AUSERNAME";
            this.aUSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.aUSERNAMEDataGridViewTextBoxColumn.Name = "aUSERNAMEDataGridViewTextBoxColumn";
            this.aUSERNAMEDataGridViewTextBoxColumn.Width = 220;
            // 
            // updateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "updateEmployee";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.updateEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox euser;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox epass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox eaddr;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton clearTextButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox ename;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox econtact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox eid;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource aDMINBindingSource;
        private DataSet13 dataSet13;
        private DataSet13TableAdapters.ADMINTableAdapter aDMINTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUSERNAMEDataGridViewTextBoxColumn;
    }
}
