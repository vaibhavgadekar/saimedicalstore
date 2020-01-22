namespace WindowsFormsApplication3
{
    partial class updateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateCategory));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clearTextButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.category_name = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.category_id = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet9 = new WindowsFormsApplication3.DataSet9();
            this.cATEGORYTableAdapter = new WindowsFormsApplication3.DataSet9TableAdapters.CATEGORYTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newUpdateCategory = new WindowsFormsApplication3.newUpdateCategory();
            this.cATEGORYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYTableAdapter1 = new WindowsFormsApplication3.newUpdateCategoryTableAdapters.CATEGORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newUpdateCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.clearTextButton.Location = new System.Drawing.Point(725, 186);
            this.clearTextButton.Name = "clearTextButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.clearTextButton.onHoverState = stateProperties1;
            this.clearTextButton.Size = new System.Drawing.Size(123, 35);
            this.clearTextButton.TabIndex = 60;
            this.clearTextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // category_name
            // 
            this.category_name.AcceptsReturn = false;
            this.category_name.AcceptsTab = false;
            this.category_name.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.category_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.category_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.category_name.BackColor = System.Drawing.Color.Transparent;
            this.category_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category_name.BackgroundImage")));
            this.category_name.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.category_name.BorderColorHover = System.Drawing.Color.Silver;
            this.category_name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_name.BorderRadius = 1;
            this.category_name.BorderThickness = 1;
            this.category_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.category_name.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.category_name.DefaultText = "";
            this.category_name.FillColor = System.Drawing.Color.White;
            this.category_name.HideSelection = true;
            this.category_name.IconLeft = null;
            this.category_name.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.category_name.IconPadding = 10;
            this.category_name.IconRight = null;
            this.category_name.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.category_name.Location = new System.Drawing.Point(609, 106);
            this.category_name.MaxLength = 32767;
            this.category_name.MinimumSize = new System.Drawing.Size(100, 35);
            this.category_name.Modified = false;
            this.category_name.Name = "category_name";
            this.category_name.PasswordChar = '\0';
            this.category_name.ReadOnly = false;
            this.category_name.SelectedText = "";
            this.category_name.SelectionLength = 0;
            this.category_name.SelectionStart = 0;
            this.category_name.ShortcutsEnabled = true;
            this.category_name.Size = new System.Drawing.Size(239, 37);
            this.category_name.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.category_name.TabIndex = 51;
            this.category_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.category_name.TextMarginLeft = 5;
            this.category_name.TextPlaceholder = "";
            this.category_name.UseSystemPasswordChar = false;
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
            this.bunifuButton1.Location = new System.Drawing.Point(571, 186);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(122, 35);
            this.bunifuButton1.TabIndex = 59;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // category_id
            // 
            this.category_id.AcceptsReturn = false;
            this.category_id.AcceptsTab = false;
            this.category_id.AutoCompleteCustomSource.AddRange(new string[] {
            "hello"});
            this.category_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.category_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.category_id.BackColor = System.Drawing.Color.Transparent;
            this.category_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category_id.BackgroundImage")));
            this.category_id.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_id.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.category_id.BorderColorHover = System.Drawing.Color.Silver;
            this.category_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_id.BorderRadius = 1;
            this.category_id.BorderThickness = 1;
            this.category_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.category_id.DefaultFont = new System.Drawing.Font("Century Gothic", 13F);
            this.category_id.DefaultText = "";
            this.category_id.FillColor = System.Drawing.Color.White;
            this.category_id.HideSelection = true;
            this.category_id.IconLeft = null;
            this.category_id.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.category_id.IconPadding = 10;
            this.category_id.IconRight = null;
            this.category_id.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.category_id.Location = new System.Drawing.Point(609, 37);
            this.category_id.MaxLength = 32767;
            this.category_id.MinimumSize = new System.Drawing.Size(100, 35);
            this.category_id.Modified = false;
            this.category_id.Name = "category_id";
            this.category_id.PasswordChar = '\0';
            this.category_id.ReadOnly = false;
            this.category_id.SelectedText = "";
            this.category_id.SelectionLength = 0;
            this.category_id.SelectionStart = 0;
            this.category_id.ShortcutsEnabled = true;
            this.category_id.Size = new System.Drawing.Size(239, 37);
            this.category_id.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.category_id.TabIndex = 57;
            this.category_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.category_id.TextMarginLeft = 5;
            this.category_id.TextPlaceholder = "";
            this.category_id.UseSystemPasswordChar = false;
            this.category_id.TextChange += new System.EventHandler(this.category_id_TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(458, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Category ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(422, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Category Name";
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
            this.cIDDataGridViewTextBoxColumn,
            this.cNAMEDataGridViewTextBoxColumn,
            this.aNODataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.cATEGORYBindingSource1;
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
            this.metroGrid1.Location = new System.Drawing.Point(0, 305);
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
            this.metroGrid1.Size = new System.Drawing.Size(1366, 463);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 61;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CATEGORY ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // cNAMEDataGridViewTextBoxColumn
            // 
            this.cNAMEDataGridViewTextBoxColumn.DataPropertyName = "CNAME";
            this.cNAMEDataGridViewTextBoxColumn.HeaderText = "CATEGORY NAME";
            this.cNAMEDataGridViewTextBoxColumn.Name = "cNAMEDataGridViewTextBoxColumn";
            this.cNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNAMEDataGridViewTextBoxColumn.Width = 600;
            // 
            // aNODataGridViewTextBoxColumn
            // 
            this.aNODataGridViewTextBoxColumn.DataPropertyName = "ANO";
            this.aNODataGridViewTextBoxColumn.HeaderText = "ADMIN NO";
            this.aNODataGridViewTextBoxColumn.Name = "aNODataGridViewTextBoxColumn";
            this.aNODataGridViewTextBoxColumn.ReadOnly = true;
            this.aNODataGridViewTextBoxColumn.Width = 600;
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.dataSet9;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.clearTextButton);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 305);
            this.panel1.TabIndex = 64;
            // 
            // newUpdateCategory
            // 
            this.newUpdateCategory.DataSetName = "newUpdateCategory";
            this.newUpdateCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYBindingSource1
            // 
            this.cATEGORYBindingSource1.DataMember = "CATEGORY";
            this.cATEGORYBindingSource1.DataSource = this.newUpdateCategory;
            // 
            // cATEGORYTableAdapter1
            // 
            this.cATEGORYTableAdapter1.ClearBeforeFill = true;
            // 
            // updateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.category_name);
            this.Controls.Add(this.category_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "updateCategory";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.updateCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newUpdateCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton clearTextButton;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox category_name;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox category_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private DataSet9 dataSet9;
        private DataSet9TableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource1;
        private newUpdateCategory newUpdateCategory;
        private newUpdateCategoryTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter1;
    }
}
