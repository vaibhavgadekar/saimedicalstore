namespace WindowsFormsApplication3
{
    partial class deleteCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteCompany));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.nameTexBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.companyAdd = new WindowsFormsApplication3.companyAdd();
            this.companyAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteComp = new WindowsFormsApplication3.deleteComp();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYTableAdapter = new WindowsFormsApplication3.deleteCompTableAdapters.COMPANYTableAdapter();
            this.cNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Controls.Add(this.nameTexBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 172);
            this.panel1.TabIndex = 22;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Delete";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.White;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Teal;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(791, 70);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            this.bunifuButton1.Size = new System.Drawing.Size(122, 35);
            this.bunifuButton1.TabIndex = 18;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // nameTexBox
            // 
            this.nameTexBox.AcceptsReturn = false;
            this.nameTexBox.AcceptsTab = false;
            this.nameTexBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTexBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameTexBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTexBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameTexBox.BackgroundImage")));
            this.nameTexBox.BorderColorActive = System.Drawing.Color.Teal;
            this.nameTexBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.nameTexBox.BorderColorHover = System.Drawing.Color.Silver;
            this.nameTexBox.BorderColorIdle = System.Drawing.Color.Teal;
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
            this.nameTexBox.Location = new System.Drawing.Point(531, 68);
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
            this.nameTexBox.TabIndex = 16;
            this.nameTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTexBox.TextMarginLeft = 5;
            this.nameTexBox.TextPlaceholder = "";
            this.nameTexBox.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(329, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Company Id";
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 172);
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
            this.metroGrid1.Size = new System.Drawing.Size(1366, 596);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 23;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // companyAdd
            // 
            this.companyAdd.DataSetName = "companyAdd";
            this.companyAdd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyAddBindingSource
            // 
            this.companyAddBindingSource.DataSource = this.companyAdd;
            this.companyAddBindingSource.Position = 0;
            // 
            // deleteComp
            // 
            this.deleteComp.DataSetName = "deleteComp";
            this.deleteComp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.deleteComp;
            // 
            // cOMPANYTableAdapter
            // 
            this.cOMPANYTableAdapter.ClearBeforeFill = true;
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
            this.cADDRDataGridViewTextBoxColumn.Width = 300;
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
            this.aNODataGridViewTextBoxColumn.Width = 250;
            // 
            // deleteCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "deleteCompany";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.deleteCompany_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nameTexBox;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource companyAddBindingSource;
        private companyAdd companyAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private deleteComp deleteComp;
        private deleteCompTableAdapters.COMPANYTableAdapter cOMPANYTableAdapter;
    }
}
