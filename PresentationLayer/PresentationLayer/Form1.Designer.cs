namespace PresentationLayer
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NavbarTop = new System.Windows.Forms.Panel();
            this.NormalForm = new System.Windows.Forms.PictureBox();
            this.MinimizeForm = new System.Windows.Forms.PictureBox();
            this.MaximizeForm = new System.Windows.Forms.PictureBox();
            this.FormClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SideWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LineSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.bunifuFlatButtonRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonLogIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipseCurveSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimationSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimationSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.labelMainFormText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NavbarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SideWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavbarTop
            // 
            this.NavbarTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.NavbarTop.Controls.Add(this.NormalForm);
            this.NavbarTop.Controls.Add(this.MinimizeForm);
            this.NavbarTop.Controls.Add(this.MaximizeForm);
            this.NavbarTop.Controls.Add(this.FormClose);
            this.NavbarTop.Controls.Add(this.label1);
            this.NavbarTop.Controls.Add(this.MenuSidebar);
            this.AnimationSidebarBack.SetDecoration(this.NavbarTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.NavbarTop, BunifuAnimatorNS.DecorationType.None);
            this.NavbarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarTop.Location = new System.Drawing.Point(0, 0);
            this.NavbarTop.Name = "NavbarTop";
            this.NavbarTop.Size = new System.Drawing.Size(1400, 80);
            this.NavbarTop.TabIndex = 0;
            this.NavbarTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavbarTop_MouseDown);
            this.NavbarTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavbarTop_MouseMove);
            // 
            // NormalForm
            // 
            this.NormalForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimationSidebar.SetDecoration(this.NormalForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.NormalForm, BunifuAnimatorNS.DecorationType.None);
            this.NormalForm.Image = ((System.Drawing.Image)(resources.GetObject("NormalForm.Image")));
            this.NormalForm.Location = new System.Drawing.Point(1307, 23);
            this.NormalForm.Name = "NormalForm";
            this.NormalForm.Size = new System.Drawing.Size(30, 30);
            this.NormalForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NormalForm.TabIndex = 5;
            this.NormalForm.TabStop = false;
            this.NormalForm.Visible = false;
            this.NormalForm.Click += new System.EventHandler(this.NormalForm_Click);
            // 
            // MinimizeForm
            // 
            this.MinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimationSidebar.SetDecoration(this.MinimizeForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.MinimizeForm, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeForm.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeForm.Image")));
            this.MinimizeForm.Location = new System.Drawing.Point(1271, 23);
            this.MinimizeForm.Name = "MinimizeForm";
            this.MinimizeForm.Size = new System.Drawing.Size(30, 30);
            this.MinimizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeForm.TabIndex = 4;
            this.MinimizeForm.TabStop = false;
            this.MinimizeForm.Click += new System.EventHandler(this.MinimizeForm_Click);
            // 
            // MaximizeForm
            // 
            this.MaximizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimationSidebar.SetDecoration(this.MaximizeForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.MaximizeForm, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeForm.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeForm.Image")));
            this.MaximizeForm.Location = new System.Drawing.Point(1307, 23);
            this.MaximizeForm.Name = "MaximizeForm";
            this.MaximizeForm.Size = new System.Drawing.Size(30, 30);
            this.MaximizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizeForm.TabIndex = 3;
            this.MaximizeForm.TabStop = false;
            this.MaximizeForm.Click += new System.EventHandler(this.MaximizeForm_Click);
            // 
            // FormClose
            // 
            this.FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimationSidebar.SetDecoration(this.FormClose, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.FormClose, BunifuAnimatorNS.DecorationType.None);
            this.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("FormClose.Image")));
            this.FormClose.Location = new System.Drawing.Point(1343, 23);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(30, 30);
            this.FormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormClose.TabIndex = 2;
            this.FormClose.TabStop = false;
            this.FormClose.Click += new System.EventHandler(this.FormClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // MenuSidebar
            // 
            this.AnimationSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(23, 23);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SideWrapper
            // 
            this.SideWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideWrapper.Controls.Add(this.Sidebar);
            this.AnimationSidebarBack.SetDecoration(this.SideWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.SideWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SideWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideWrapper.ForeColor = System.Drawing.Color.White;
            this.SideWrapper.Location = new System.Drawing.Point(0, 80);
            this.SideWrapper.Name = "SideWrapper";
            this.SideWrapper.Size = new System.Drawing.Size(300, 820);
            this.SideWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.bunifuFlatButtonLogIn);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonRegister);
            this.Sidebar.Controls.Add(this.LineSidebar);
            this.AnimationSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(15, 17);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 784);
            this.Sidebar.TabIndex = 0;
            // 
            // LineSidebar
            // 
            this.LineSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimationSidebarBack.SetDecoration(this.LineSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.LineSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineSidebar.LineColor = System.Drawing.Color.White;
            this.LineSidebar.LineThickness = 1;
            this.LineSidebar.Location = new System.Drawing.Point(10, 94);
            this.LineSidebar.Name = "LineSidebar";
            this.LineSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineSidebar.TabIndex = 0;
            this.LineSidebar.Transparency = 255;
            this.LineSidebar.Vertical = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.label3);
            this.Wrapper.Controls.Add(this.label2);
            this.Wrapper.Controls.Add(this.labelMainFormText);
            this.AnimationSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1100, 820);
            this.Wrapper.TabIndex = 2;
            // 
            // bunifuFlatButtonRegister
            // 
            this.bunifuFlatButtonRegister.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonRegister.BorderRadius = 0;
            this.bunifuFlatButtonRegister.ButtonText = "       REGISTER";
            this.bunifuFlatButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButtonRegister, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButtonRegister, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonRegister.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonRegister.Iconimage")));
            this.bunifuFlatButtonRegister.Iconimage_right = null;
            this.bunifuFlatButtonRegister.Iconimage_right_Selected = null;
            this.bunifuFlatButtonRegister.Iconimage_Selected = null;
            this.bunifuFlatButtonRegister.IconMarginLeft = 0;
            this.bunifuFlatButtonRegister.IconMarginRight = 0;
            this.bunifuFlatButtonRegister.IconRightVisible = true;
            this.bunifuFlatButtonRegister.IconRightZoom = 0D;
            this.bunifuFlatButtonRegister.IconVisible = true;
            this.bunifuFlatButtonRegister.IconZoom = 50D;
            this.bunifuFlatButtonRegister.IsTab = false;
            this.bunifuFlatButtonRegister.Location = new System.Drawing.Point(8, 141);
            this.bunifuFlatButtonRegister.Name = "bunifuFlatButtonRegister";
            this.bunifuFlatButtonRegister.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonRegister.selected = false;
            this.bunifuFlatButtonRegister.Size = new System.Drawing.Size(252, 48);
            this.bunifuFlatButtonRegister.TabIndex = 2;
            this.bunifuFlatButtonRegister.Text = "       REGISTER";
            this.bunifuFlatButtonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonRegister.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonRegister.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButtonLogIn
            // 
            this.bunifuFlatButtonLogIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonLogIn.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonLogIn.BorderRadius = 0;
            this.bunifuFlatButtonLogIn.ButtonText = "       LOG IN";
            this.bunifuFlatButtonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButtonLogIn, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButtonLogIn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonLogIn.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonLogIn.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonLogIn.Iconimage")));
            this.bunifuFlatButtonLogIn.Iconimage_right = null;
            this.bunifuFlatButtonLogIn.Iconimage_right_Selected = null;
            this.bunifuFlatButtonLogIn.Iconimage_Selected = null;
            this.bunifuFlatButtonLogIn.IconMarginLeft = 0;
            this.bunifuFlatButtonLogIn.IconMarginRight = 0;
            this.bunifuFlatButtonLogIn.IconRightVisible = true;
            this.bunifuFlatButtonLogIn.IconRightZoom = 0D;
            this.bunifuFlatButtonLogIn.IconVisible = true;
            this.bunifuFlatButtonLogIn.IconZoom = 50D;
            this.bunifuFlatButtonLogIn.IsTab = false;
            this.bunifuFlatButtonLogIn.Location = new System.Drawing.Point(8, 195);
            this.bunifuFlatButtonLogIn.Name = "bunifuFlatButtonLogIn";
            this.bunifuFlatButtonLogIn.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonLogIn.selected = false;
            this.bunifuFlatButtonLogIn.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButtonLogIn.TabIndex = 3;
            this.bunifuFlatButtonLogIn.Text = "       LOG IN";
            this.bunifuFlatButtonLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonLogIn.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonLogIn.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipseCurveSidebar
            // 
            this.bunifuElipseCurveSidebar.ElipseRadius = 7;
            this.bunifuElipseCurveSidebar.TargetControl = this.Sidebar;
            // 
            // AnimationSidebar
            // 
            this.AnimationSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimationSidebar.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 1;
            animation10.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 2F;
            animation10.TransparencyCoeff = 0F;
            this.AnimationSidebar.DefaultAnimation = animation10;
            // 
            // AnimationSidebarBack
            // 
            this.AnimationSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimationSidebarBack.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.AnimationSidebarBack.DefaultAnimation = animation9;
            // 
            // labelMainFormText
            // 
            this.labelMainFormText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainFormText.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.labelMainFormText, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.labelMainFormText, BunifuAnimatorNS.DecorationType.None);
            this.labelMainFormText.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainFormText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.labelMainFormText.Location = new System.Drawing.Point(450, 301);
            this.labelMainFormText.Name = "labelMainFormText";
            this.labelMainFormText.Size = new System.Drawing.Size(185, 86);
            this.labelMainFormText.TabIndex = 0;
            this.labelMainFormText.Text = "2048";
            this.labelMainFormText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(495, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "MADE BY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(468, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 72);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danilo Korać\r\nNenad Penezić\r\nNikola Tomić\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SideWrapper);
            this.Controls.Add(this.NavbarTop);
            this.AnimationSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.NavbarTop.ResumeLayout(false);
            this.NavbarTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SideWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavbarTop;
        private System.Windows.Forms.PictureBox NormalForm;
        private System.Windows.Forms.PictureBox MinimizeForm;
        private System.Windows.Forms.PictureBox MaximizeForm;
        private System.Windows.Forms.PictureBox FormClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SideWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuSeparator LineSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonLogIn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonRegister;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseCurveSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimationSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimationSidebarBack;
        private System.Windows.Forms.Label labelMainFormText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

