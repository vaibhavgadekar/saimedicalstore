namespace WindowsFormsApplication3
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCheckBox2 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errormessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UserLogo = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LogoAnim = new System.Windows.Forms.Timer(this.components);
            this.LoginAnim = new System.Windows.Forms.Timer(this.components);
            this.loader = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.loader);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCheckBox2);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.errormessage);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.LoginButton);
            this.bunifuGradientPanel1.Controls.Add(this.password);
            this.bunifuGradientPanel1.Controls.Add(this.username);
            this.bunifuGradientPanel1.Controls.Add(this.UserLogo);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.Window;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(833, 544);
            this.bunifuGradientPanel1.TabIndex = 15;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(754, 22);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(49, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // bunifuCheckBox2
            // 
            this.bunifuCheckBox2.AllowBindingControlAnimation = true;
            this.bunifuCheckBox2.AllowBindingControlLocation = true;
            this.bunifuCheckBox2.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox2.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox2.AllowOnHoverStates = true;
            this.bunifuCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox2.BackgroundImage")));
            this.bunifuCheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox2.BindingControl = null;
            this.bunifuCheckBox2.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox2.Checked = false;
            this.bunifuCheckBox2.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.bunifuCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox2.CustomCheckmarkImage = null;
            this.bunifuTransition1.SetDecoration(this.bunifuCheckBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCheckBox2.Location = new System.Drawing.Point(360, 352);
            this.bunifuCheckBox2.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox2.Name = "bunifuCheckBox2";
            this.bunifuCheckBox2.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox2.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox2.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox2.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCheckBox2.OnCheck.CheckmarkColor = System.Drawing.Color.Lime;
            this.bunifuCheckBox2.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox2.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox2.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox2.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox2.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox2.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox2.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox2.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox2.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox2.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox2.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox2.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox2.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.OnUncheck.BorderColor = System.Drawing.Color.Cyan;
            this.bunifuCheckBox2.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox2.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox2.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckBox2.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox2.TabIndex = 31;
            this.bunifuCheckBox2.ThreeState = false;
            this.bunifuCheckBox2.ToolTipText = null;
            this.bunifuCheckBox2.Click += new System.EventHandler(this.bunifuCheckBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(386, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Show password";
            // 
            // errormessage
            // 
            this.errormessage.AutoSize = true;
            this.errormessage.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.errormessage, BunifuAnimatorNS.DecorationType.None);
            this.errormessage.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessage.ForeColor = System.Drawing.Color.Yellow;
            this.errormessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errormessage.Location = new System.Drawing.Point(320, 462);
            this.errormessage.Name = "errormessage";
            this.errormessage.Size = new System.Drawing.Size(0, 20);
            this.errormessage.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bunifuTransition1.SetDecoration(this.LoginButton, BunifuAnimatorNS.DecorationType.None);
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(306, 388);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(283, 41);
            this.LoginButton.TabIndex = 19;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.MediumAquamarine;
            this.password.BorderColorFocused = System.Drawing.Color.White;
            this.password.BorderColorIdle = System.Drawing.Color.White;
            this.password.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.password.BorderThickness = 1;
            this.password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.password, BunifuAnimatorNS.DecorationType.None);
            this.password.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.isPassword = true;
            this.password.Location = new System.Drawing.Point(305, 276);
            this.password.Margin = new System.Windows.Forms.Padding(5);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(284, 45);
            this.password.TabIndex = 26;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Enter += new System.EventHandler(this.passwordfocus);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.MediumAquamarine;
            this.username.BorderColorFocused = System.Drawing.Color.PaleGreen;
            this.username.BorderColorIdle = System.Drawing.Color.White;
            this.username.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.username.BorderThickness = 1;
            this.username.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.username, BunifuAnimatorNS.DecorationType.None);
            this.username.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.isPassword = false;
            this.username.Location = new System.Drawing.Point(305, 220);
            this.username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(283, 46);
            this.username.TabIndex = 25;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.Enter += new System.EventHandler(this.LoginFocus);
            // 
            // UserLogo
            // 
            this.UserLogo.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.UserLogo, BunifuAnimatorNS.DecorationType.None);
            this.UserLogo.Image = ((System.Drawing.Image)(resources.GetObject("UserLogo.Image")));
            this.UserLogo.Location = new System.Drawing.Point(389, 38);
            this.UserLogo.Name = "UserLogo";
            this.UserLogo.Size = new System.Drawing.Size(107, 91);
            this.UserLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserLogo.TabIndex = 0;
            this.UserLogo.TabStop = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 15;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LogoAnim
            // 
            this.LogoAnim.Enabled = true;
            this.LogoAnim.Interval = 2;
            this.LogoAnim.Tick += new System.EventHandler(this.LogoAnim_Tick);
            // 
            // LoginAnim
            // 
            this.LoginAnim.Enabled = true;
            this.LoginAnim.Interval = 2;
            this.LoginAnim.Tick += new System.EventHandler(this.LoginAnim_Tick);
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.loader, BunifuAnimatorNS.DecorationType.None);
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(306, 435);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(282, 111);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loader.TabIndex = 32;
            this.loader.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 544);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button LoginButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox UserLogo;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuMetroTextbox username;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errormessage;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer LogoAnim;
        private System.Windows.Forms.Timer LoginAnim;
        private System.Windows.Forms.PictureBox loader;
    }
}