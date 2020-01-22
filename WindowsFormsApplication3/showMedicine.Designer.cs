namespace WindowsFormsApplication3
{
    partial class showMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showMedicine));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.dataSet5 = new WindowsFormsApplication3.DataSet5();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new WindowsFormsApplication3.DataSet5TableAdapters.PRODUCTTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.pNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rACKNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFGDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.nameTexBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dataSet5;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
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
            this.pNODataGridViewTextBoxColumn,
            this.pNAMEDataGridViewTextBoxColumn,
            this.pTYPEDataGridViewTextBoxColumn,
            this.rACKNODataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.mFGDATEDataGridViewTextBoxColumn,
            this.eXPDATEDataGridViewTextBoxColumn,
            this.cOMPANYNAMEDataGridViewTextBoxColumn,
            this.aNODataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.pRODUCTBindingSource;
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
            this.metroGrid1.TabIndex = 15;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pNODataGridViewTextBoxColumn
            // 
            this.pNODataGridViewTextBoxColumn.DataPropertyName = "PNO";
            this.pNODataGridViewTextBoxColumn.HeaderText = "PRODUCT NO";
            this.pNODataGridViewTextBoxColumn.Name = "pNODataGridViewTextBoxColumn";
            this.pNODataGridViewTextBoxColumn.ReadOnly = true;
            this.pNODataGridViewTextBoxColumn.Width = 150;
            // 
            // pNAMEDataGridViewTextBoxColumn
            // 
            this.pNAMEDataGridViewTextBoxColumn.DataPropertyName = "PNAME";
            this.pNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT NAME";
            this.pNAMEDataGridViewTextBoxColumn.Name = "pNAMEDataGridViewTextBoxColumn";
            this.pNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pNAMEDataGridViewTextBoxColumn.Width = 180;
            // 
            // pTYPEDataGridViewTextBoxColumn
            // 
            this.pTYPEDataGridViewTextBoxColumn.DataPropertyName = "PTYPE";
            this.pTYPEDataGridViewTextBoxColumn.HeaderText = "PRODUCT TYPE";
            this.pTYPEDataGridViewTextBoxColumn.Name = "pTYPEDataGridViewTextBoxColumn";
            this.pTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pTYPEDataGridViewTextBoxColumn.Width = 180;
            // 
            // rACKNODataGridViewTextBoxColumn
            // 
            this.rACKNODataGridViewTextBoxColumn.DataPropertyName = "RACKNO";
            this.rACKNODataGridViewTextBoxColumn.HeaderText = "RACKNO";
            this.rACKNODataGridViewTextBoxColumn.Name = "rACKNODataGridViewTextBoxColumn";
            this.rACKNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            this.qUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.qUANTITYDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mFGDATEDataGridViewTextBoxColumn
            // 
            this.mFGDATEDataGridViewTextBoxColumn.DataPropertyName = "MFGDATE";
            this.mFGDATEDataGridViewTextBoxColumn.HeaderText = "MFG DATE";
            this.mFGDATEDataGridViewTextBoxColumn.Name = "mFGDATEDataGridViewTextBoxColumn";
            this.mFGDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mFGDATEDataGridViewTextBoxColumn.Width = 180;
            // 
            // eXPDATEDataGridViewTextBoxColumn
            // 
            this.eXPDATEDataGridViewTextBoxColumn.DataPropertyName = "EXPDATE";
            this.eXPDATEDataGridViewTextBoxColumn.HeaderText = "EXPIRY DATE";
            this.eXPDATEDataGridViewTextBoxColumn.Name = "eXPDATEDataGridViewTextBoxColumn";
            this.eXPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXPDATEDataGridViewTextBoxColumn.Width = 180;
            // 
            // cOMPANYNAMEDataGridViewTextBoxColumn
            // 
            this.cOMPANYNAMEDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.HeaderText = "COMPANY NAME";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.Name = "cOMPANYNAMEDataGridViewTextBoxColumn";
            this.cOMPANYNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPANYNAMEDataGridViewTextBoxColumn.Width = 180;
            // 
            // aNODataGridViewTextBoxColumn
            // 
            this.aNODataGridViewTextBoxColumn.DataPropertyName = "ANO";
            this.aNODataGridViewTextBoxColumn.HeaderText = "ADMIN NO";
            this.aNODataGridViewTextBoxColumn.Name = "aNODataGridViewTextBoxColumn";
            this.aNODataGridViewTextBoxColumn.ReadOnly = true;
            this.aNODataGridViewTextBoxColumn.Width = 150;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Show ";
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
            this.label2.Location = new System.Drawing.Point(324, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Medicine Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuButton2);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Controls.Add(this.nameTexBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 172);
            this.panel1.TabIndex = 19;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.ButtonText = "Reset";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.White;
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 0;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.Teal;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.Location = new System.Drawing.Point(919, 70);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties2;
            this.bunifuButton2.Size = new System.Drawing.Size(122, 35);
            this.bunifuButton2.TabIndex = 19;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // showMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "showMedicine";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.showMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private DataSet5 dataSet5;
        private DataSet5TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rACKNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nameTexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
    }
}
