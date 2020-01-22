namespace WindowsFormsApplication3
{
    partial class updateMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateMedicine));
            this.product = new WindowsFormsApplication3.product();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateProduct = new WindowsFormsApplication3.updateProduct();
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new WindowsFormsApplication3.updateProductTableAdapters.PRODUCTTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearTextButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.nameTexBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.rackNoTexBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.quantityTexBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.priceTexBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.companyTexBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.mfgDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.expDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // product
            // 
            this.product.DataSetName = "product";
            this.product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = this.product;
            this.productBindingSource.Position = 0;
            // 
            // updateProduct
            // 
            this.updateProduct.DataSetName = "updateProduct";
            this.updateProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            this.pRODUCTBindingSource1.DataSource = this.updateProduct;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clearTextButton);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Controls.Add(this.nameTexBox);
            this.panel1.Controls.Add(this.typeComboBox);
            this.panel1.Controls.Add(this.rackNoTexBox);
            this.panel1.Controls.Add(this.quantityTexBox);
            this.panel1.Controls.Add(this.priceTexBox);
            this.panel1.Controls.Add(this.companyTexBox);
            this.panel1.Controls.Add(this.mfgDate);
            this.panel1.Controls.Add(this.expDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 16;
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
            this.clearTextButton.Location = new System.Drawing.Point(730, 543);
            this.clearTextButton.Name = "clearTextButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.clearTextButton.onHoverState = stateProperties1;
            this.clearTextButton.Size = new System.Drawing.Size(123, 35);
            this.clearTextButton.TabIndex = 38;
            this.clearTextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Update Row";
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
            this.bunifuButton1.Location = new System.Drawing.Point(576, 543);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(122, 35);
            this.bunifuButton1.TabIndex = 37;
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
            this.nameTexBox.Location = new System.Drawing.Point(617, 81);
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
            this.nameTexBox.TabIndex = 27;
            this.nameTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTexBox.TextMarginLeft = 5;
            this.nameTexBox.TextPlaceholder = "";
            this.nameTexBox.UseSystemPasswordChar = false;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownHeight = 100;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.typeComboBox.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.IntegralHeight = false;
            this.typeComboBox.ItemHeight = 21;
            this.typeComboBox.Location = new System.Drawing.Point(617, 142);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(239, 29);
            this.typeComboBox.TabIndex = 28;
            // 
            // rackNoTexBox
            // 
            this.rackNoTexBox.AcceptsReturn = false;
            this.rackNoTexBox.AcceptsTab = false;
            this.rackNoTexBox.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.rackNoTexBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rackNoTexBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rackNoTexBox.BackColor = System.Drawing.Color.Transparent;
            this.rackNoTexBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rackNoTexBox.BackgroundImage")));
            this.rackNoTexBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rackNoTexBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.rackNoTexBox.BorderColorHover = System.Drawing.Color.Silver;
            this.rackNoTexBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rackNoTexBox.BorderRadius = 1;
            this.rackNoTexBox.BorderThickness = 1;
            this.rackNoTexBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.rackNoTexBox.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.rackNoTexBox.DefaultText = "";
            this.rackNoTexBox.FillColor = System.Drawing.Color.White;
            this.rackNoTexBox.HideSelection = true;
            this.rackNoTexBox.IconLeft = null;
            this.rackNoTexBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.rackNoTexBox.IconPadding = 10;
            this.rackNoTexBox.IconRight = null;
            this.rackNoTexBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.rackNoTexBox.Location = new System.Drawing.Point(617, 195);
            this.rackNoTexBox.MaxLength = 32767;
            this.rackNoTexBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.rackNoTexBox.Modified = false;
            this.rackNoTexBox.Name = "rackNoTexBox";
            this.rackNoTexBox.PasswordChar = '\0';
            this.rackNoTexBox.ReadOnly = false;
            this.rackNoTexBox.SelectedText = "";
            this.rackNoTexBox.SelectionLength = 0;
            this.rackNoTexBox.SelectionStart = 0;
            this.rackNoTexBox.ShortcutsEnabled = true;
            this.rackNoTexBox.Size = new System.Drawing.Size(239, 37);
            this.rackNoTexBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.rackNoTexBox.TabIndex = 29;
            this.rackNoTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rackNoTexBox.TextMarginLeft = 5;
            this.rackNoTexBox.TextPlaceholder = "";
            this.rackNoTexBox.UseSystemPasswordChar = false;
            // 
            // quantityTexBox
            // 
            this.quantityTexBox.AcceptsReturn = false;
            this.quantityTexBox.AcceptsTab = false;
            this.quantityTexBox.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.quantityTexBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.quantityTexBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.quantityTexBox.BackColor = System.Drawing.Color.Transparent;
            this.quantityTexBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quantityTexBox.BackgroundImage")));
            this.quantityTexBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantityTexBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.quantityTexBox.BorderColorHover = System.Drawing.Color.Silver;
            this.quantityTexBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantityTexBox.BorderRadius = 1;
            this.quantityTexBox.BorderThickness = 1;
            this.quantityTexBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.quantityTexBox.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.quantityTexBox.DefaultText = "";
            this.quantityTexBox.FillColor = System.Drawing.Color.White;
            this.quantityTexBox.HideSelection = true;
            this.quantityTexBox.IconLeft = null;
            this.quantityTexBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.quantityTexBox.IconPadding = 10;
            this.quantityTexBox.IconRight = null;
            this.quantityTexBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.quantityTexBox.Location = new System.Drawing.Point(617, 250);
            this.quantityTexBox.MaxLength = 32767;
            this.quantityTexBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.quantityTexBox.Modified = false;
            this.quantityTexBox.Name = "quantityTexBox";
            this.quantityTexBox.PasswordChar = '\0';
            this.quantityTexBox.ReadOnly = false;
            this.quantityTexBox.SelectedText = "";
            this.quantityTexBox.SelectionLength = 0;
            this.quantityTexBox.SelectionStart = 0;
            this.quantityTexBox.ShortcutsEnabled = true;
            this.quantityTexBox.Size = new System.Drawing.Size(239, 37);
            this.quantityTexBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.quantityTexBox.TabIndex = 30;
            this.quantityTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantityTexBox.TextMarginLeft = 5;
            this.quantityTexBox.TextPlaceholder = "";
            this.quantityTexBox.UseSystemPasswordChar = false;
            // 
            // priceTexBox
            // 
            this.priceTexBox.AcceptsReturn = false;
            this.priceTexBox.AcceptsTab = false;
            this.priceTexBox.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.priceTexBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.priceTexBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.priceTexBox.BackColor = System.Drawing.Color.Transparent;
            this.priceTexBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("priceTexBox.BackgroundImage")));
            this.priceTexBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceTexBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.priceTexBox.BorderColorHover = System.Drawing.Color.Silver;
            this.priceTexBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceTexBox.BorderRadius = 1;
            this.priceTexBox.BorderThickness = 1;
            this.priceTexBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.priceTexBox.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.priceTexBox.DefaultText = "";
            this.priceTexBox.FillColor = System.Drawing.Color.White;
            this.priceTexBox.HideSelection = true;
            this.priceTexBox.IconLeft = null;
            this.priceTexBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.priceTexBox.IconPadding = 10;
            this.priceTexBox.IconRight = null;
            this.priceTexBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.priceTexBox.Location = new System.Drawing.Point(614, 310);
            this.priceTexBox.MaxLength = 32767;
            this.priceTexBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.priceTexBox.Modified = false;
            this.priceTexBox.Name = "priceTexBox";
            this.priceTexBox.PasswordChar = '\0';
            this.priceTexBox.ReadOnly = false;
            this.priceTexBox.SelectedText = "";
            this.priceTexBox.SelectionLength = 0;
            this.priceTexBox.SelectionStart = 0;
            this.priceTexBox.ShortcutsEnabled = true;
            this.priceTexBox.Size = new System.Drawing.Size(239, 37);
            this.priceTexBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.priceTexBox.TabIndex = 31;
            this.priceTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.priceTexBox.TextMarginLeft = 5;
            this.priceTexBox.TextPlaceholder = "";
            this.priceTexBox.UseSystemPasswordChar = false;
            // 
            // companyTexBox
            // 
            this.companyTexBox.AcceptsReturn = false;
            this.companyTexBox.AcceptsTab = false;
            this.companyTexBox.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.companyTexBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.companyTexBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.companyTexBox.BackColor = System.Drawing.Color.Transparent;
            this.companyTexBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("companyTexBox.BackgroundImage")));
            this.companyTexBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companyTexBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.companyTexBox.BorderColorHover = System.Drawing.Color.Silver;
            this.companyTexBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companyTexBox.BorderRadius = 1;
            this.companyTexBox.BorderThickness = 1;
            this.companyTexBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.companyTexBox.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.companyTexBox.DefaultText = "";
            this.companyTexBox.FillColor = System.Drawing.Color.White;
            this.companyTexBox.HideSelection = true;
            this.companyTexBox.IconLeft = null;
            this.companyTexBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.companyTexBox.IconPadding = 10;
            this.companyTexBox.IconRight = null;
            this.companyTexBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.companyTexBox.Location = new System.Drawing.Point(614, 362);
            this.companyTexBox.MaxLength = 32767;
            this.companyTexBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.companyTexBox.Modified = false;
            this.companyTexBox.Name = "companyTexBox";
            this.companyTexBox.PasswordChar = '\0';
            this.companyTexBox.ReadOnly = false;
            this.companyTexBox.SelectedText = "";
            this.companyTexBox.SelectionLength = 0;
            this.companyTexBox.SelectionStart = 0;
            this.companyTexBox.ShortcutsEnabled = true;
            this.companyTexBox.Size = new System.Drawing.Size(239, 37);
            this.companyTexBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.companyTexBox.TabIndex = 33;
            this.companyTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.companyTexBox.TextMarginLeft = 5;
            this.companyTexBox.TextPlaceholder = "";
            this.companyTexBox.UseSystemPasswordChar = false;
            // 
            // mfgDate
            // 
            this.mfgDate.BorderRadius = 1;
            this.mfgDate.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mfgDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.mfgDate.Color = System.Drawing.Color.Black;
            this.mfgDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.mfgDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.mfgDate.DisabledColor = System.Drawing.Color.Gray;
            this.mfgDate.DisplayWeekNumbers = false;
            this.mfgDate.DPHeight = 0;
            this.mfgDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.mfgDate.FillDatePicker = false;
            this.mfgDate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.mfgDate.ForeColor = System.Drawing.Color.Black;
            this.mfgDate.Icon = ((System.Drawing.Image)(resources.GetObject("mfgDate.Icon")));
            this.mfgDate.IconColor = System.Drawing.Color.Black;
            this.mfgDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.mfgDate.Location = new System.Drawing.Point(614, 418);
            this.mfgDate.MinimumSize = new System.Drawing.Size(239, 35);
            this.mfgDate.Name = "mfgDate";
            this.mfgDate.Size = new System.Drawing.Size(239, 35);
            this.mfgDate.TabIndex = 34;
            // 
            // expDate
            // 
            this.expDate.BorderRadius = 1;
            this.expDate.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.expDate.Color = System.Drawing.Color.Black;
            this.expDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.expDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.expDate.DisabledColor = System.Drawing.Color.Gray;
            this.expDate.DisplayWeekNumbers = false;
            this.expDate.DPHeight = 0;
            this.expDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.expDate.FillDatePicker = false;
            this.expDate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.expDate.ForeColor = System.Drawing.Color.Black;
            this.expDate.Icon = ((System.Drawing.Image)(resources.GetObject("expDate.Icon")));
            this.expDate.IconColor = System.Drawing.Color.Black;
            this.expDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.expDate.Location = new System.Drawing.Point(614, 467);
            this.expDate.MinimumSize = new System.Drawing.Size(239, 35);
            this.expDate.Name = "expDate";
            this.expDate.Size = new System.Drawing.Size(239, 35);
            this.expDate.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label9.Location = new System.Drawing.Point(483, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Expiry Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label8.Location = new System.Drawing.Point(504, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Rack no";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label7.Location = new System.Drawing.Point(484, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 42;
            this.label7.Text = "Mfg. Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label6.Location = new System.Drawing.Point(483, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label5.Location = new System.Drawing.Point(458, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Product Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label4.Location = new System.Drawing.Point(495, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.Location = new System.Drawing.Point(492, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(522, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name";
            // 
            // idTextBox
            // 
            this.idTextBox.AcceptsReturn = false;
            this.idTextBox.AcceptsTab = false;
            this.idTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.idTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.idTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.idTextBox.BackColor = System.Drawing.Color.Transparent;
            this.idTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("idTextBox.BackgroundImage")));
            this.idTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.idTextBox.BorderColorHover = System.Drawing.Color.Silver;
            this.idTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idTextBox.BorderRadius = 1;
            this.idTextBox.BorderThickness = 1;
            this.idTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idTextBox.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.idTextBox.DefaultText = "";
            this.idTextBox.FillColor = System.Drawing.Color.White;
            this.idTextBox.HideSelection = true;
            this.idTextBox.IconLeft = null;
            this.idTextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.idTextBox.IconPadding = 10;
            this.idTextBox.IconRight = null;
            this.idTextBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.idTextBox.Location = new System.Drawing.Point(617, 27);
            this.idTextBox.MaxLength = 32767;
            this.idTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.idTextBox.Modified = false;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PasswordChar = '\0';
            this.idTextBox.ReadOnly = false;
            this.idTextBox.SelectedText = "";
            this.idTextBox.SelectionLength = 0;
            this.idTextBox.SelectionStart = 0;
            this.idTextBox.ShortcutsEnabled = true;
            this.idTextBox.Size = new System.Drawing.Size(239, 37);
            this.idTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.idTextBox.TabIndex = 45;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idTextBox.TextMarginLeft = 5;
            this.idTextBox.TextPlaceholder = "";
            this.idTextBox.UseSystemPasswordChar = false;
            this.idTextBox.TextChange += new System.EventHandler(this.idTextBox_TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(482, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Product No";
            // 
            // updateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "updateMedicine";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.updateMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private product product;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private updateProduct updateProduct;
        private updateProductTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton clearTextButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nameTexBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox rackNoTexBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox quantityTexBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox priceTexBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox companyTexBox;
        private Bunifu.UI.WinForms.BunifuDatePicker mfgDate;
        private Bunifu.UI.WinForms.BunifuDatePicker expDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
