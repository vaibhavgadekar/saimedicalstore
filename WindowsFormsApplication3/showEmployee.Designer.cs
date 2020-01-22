namespace WindowsFormsApplication3
{
    partial class showEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showEmployee));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eid = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearTextButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.aDMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet14 = new WindowsFormsApplication3.DataSet14();
            this.aDMINTableAdapter = new WindowsFormsApplication3.DataSet14TableAdapters.ADMINTableAdapter();
            this.newAdminShow = new WindowsFormsApplication3.newAdminShow();
            this.aDMINBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter1 = new WindowsFormsApplication3.newAdminShowTableAdapters.ADMINTableAdapter();
            this.dataSet16 = new WindowsFormsApplication3.DataSet16();
            this.aDMINBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter2 = new WindowsFormsApplication3.DataSet16TableAdapters.ADMINTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAdminShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.eid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.clearTextButton);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 138);
            this.panel1.TabIndex = 2;
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
            this.eid.Location = new System.Drawing.Point(470, 38);
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label5.Location = new System.Drawing.Point(284, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Enter User ID";
            // 
            // clearTextButton
            // 
            this.clearTextButton.BackColor = System.Drawing.Color.Transparent;
            this.clearTextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearTextButton.BackgroundImage")));
            this.clearTextButton.ButtonText = "Reset";
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
            this.clearTextButton.Location = new System.Drawing.Point(905, 38);
            this.clearTextButton.Name = "clearTextButton";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.clearTextButton.onHoverState = stateProperties3;
            this.clearTextButton.Size = new System.Drawing.Size(123, 35);
            this.clearTextButton.TabIndex = 28;
            this.clearTextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Show";
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
            this.bunifuButton1.Location = new System.Drawing.Point(751, 38);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties4;
            this.bunifuButton1.Size = new System.Drawing.Size(122, 35);
            this.bunifuButton1.TabIndex = 27;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // aDMINBindingSource
            // 
            this.aDMINBindingSource.DataMember = "ADMIN";
            this.aDMINBindingSource.DataSource = this.dataSet14;
            // 
            // dataSet14
            // 
            this.dataSet14.DataSetName = "DataSet14";
            this.dataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDMINTableAdapter
            // 
            this.aDMINTableAdapter.ClearBeforeFill = true;
            // 
            // newAdminShow
            // 
            this.newAdminShow.DataSetName = "newAdminShow";
            this.newAdminShow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDMINBindingSource1
            // 
            this.aDMINBindingSource1.DataMember = "ADMIN";
            this.aDMINBindingSource1.DataSource = this.newAdminShow;
            // 
            // aDMINTableAdapter1
            // 
            this.aDMINTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet16
            // 
            this.dataSet16.DataSetName = "DataSet16";
            this.dataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDMINBindingSource2
            // 
            this.aDMINBindingSource2.DataMember = "ADMIN";
            this.aDMINBindingSource2.DataSource = this.dataSet16;
            // 
            // aDMINTableAdapter2
            // 
            this.aDMINTableAdapter2.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.aNAMEDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
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
            this.metroGrid1.Location = new System.Drawing.Point(0, 138);
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
            this.metroGrid1.Size = new System.Drawing.Size(1366, 630);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 24;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // aNODataGridViewTextBoxColumn
            // 
            this.aNODataGridViewTextBoxColumn.DataPropertyName = "ANO";
            this.aNODataGridViewTextBoxColumn.HeaderText = "USER ID";
            this.aNODataGridViewTextBoxColumn.Name = "aNODataGridViewTextBoxColumn";
            this.aNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AUSERNAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "USERNAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "APASSWORD";
            this.dataGridViewTextBoxColumn3.HeaderText = "PASSWORD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // aNAMEDataGridViewTextBoxColumn
            // 
            this.aNAMEDataGridViewTextBoxColumn.DataPropertyName = "ANAME";
            this.aNAMEDataGridViewTextBoxColumn.HeaderText = "ADMIN NAME";
            this.aNAMEDataGridViewTextBoxColumn.Name = "aNAMEDataGridViewTextBoxColumn";
            this.aNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNAMEDataGridViewTextBoxColumn.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AADDR";
            this.dataGridViewTextBoxColumn1.HeaderText = "ADMIN ADDR";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CONTACTNO";
            this.dataGridViewTextBoxColumn2.HeaderText = "CONTACTNO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // showEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "showEmployee";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.showEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAdminShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox eid;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton clearTextButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aDMINBindingSource;
        private DataSet14 dataSet14;
        private DataSet14TableAdapters.ADMINTableAdapter aDMINTableAdapter;
        private System.Windows.Forms.BindingSource aDMINBindingSource2;
        private DataSet16 dataSet16;
        private newAdminShow newAdminShow;
        private System.Windows.Forms.BindingSource aDMINBindingSource1;
        private newAdminShowTableAdapters.ADMINTableAdapter aDMINTableAdapter1;
        private DataSet16TableAdapters.ADMINTableAdapter aDMINTableAdapter2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
