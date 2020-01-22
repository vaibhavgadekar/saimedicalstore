namespace WindowsFormsApplication3
{
    partial class deleteEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteEmployee));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eid = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dataSet15 = new WindowsFormsApplication3.DataSet15();
            this.aDMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter = new WindowsFormsApplication3.DataSet15TableAdapters.ADMINTableAdapter();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aADDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.eid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 138);
            this.panel1.TabIndex = 3;
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
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Teal;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(751, 38);
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
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aNODataGridViewTextBoxColumn,
            this.aNAMEDataGridViewTextBoxColumn,
            this.aADDRDataGridViewTextBoxColumn,
            this.cONTACTNODataGridViewTextBoxColumn,
            this.aPASSWORDDataGridViewTextBoxColumn,
            this.aUSERNAMEDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.aDMINBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 138);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1366, 630);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 24;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dataSet15
            // 
            this.dataSet15.DataSetName = "DataSet15";
            this.dataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDMINBindingSource
            // 
            this.aDMINBindingSource.DataMember = "ADMIN";
            this.aDMINBindingSource.DataSource = this.dataSet15;
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
            // deleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "deleteEmployee";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.deleteEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox eid;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aDMINBindingSource;
        private DataSet15 dataSet15;
        private DataSet15TableAdapters.ADMINTableAdapter aDMINTableAdapter;
    }
}
